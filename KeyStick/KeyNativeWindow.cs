// <copyright file="KeyNativeWindow.cs" company="Paradisus.io">
//     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
//     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// </copyright>

namespace KeyStick
{
    // Directives
    using System;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;

    /// <summary>
    /// KeyNativeWindow window.
    /// </summary>
    public class KeyNativeWindow : NativeWindow, IDisposable
    {
        /// <summary>
        /// The wm hotkey.
        /// </summary>
        private const int WM_HOTKEY = 0x0312;

        /// <summary>
        /// Registers a hotkey with the specified window, identifier, modifiers, and virtual key code.
        /// </summary>
        /// <param name="hWnd">The handle of the window to receive hotkey messages.</param>
        /// <param name="id">The identifier of the hotkey.</param>
        /// <param name="fsModifiers">The modifier keys for the hotkey.</param>
        /// <param name="vk">The virtual key code of the hotkey.</param>
        /// <returns>True if the hotkey was registered successfully, false otherwise.</returns>
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

        /// <summary>
        /// Unregisters a hotkey with the specified window and identifier.
        /// </summary>
        /// <param name="hWnd">The handle of the window to unregister the hotkey from.</param>
        /// <param name="id">The identifier of the hotkey to unregister.</param>
        /// <returns>True if the hotkey was unregistered successfully, false otherwise.</returns>
        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        /// <summary>
        /// The window message ID for a keydown event.
        /// </summary>
        private const int WM_KEYDOWN = 0x0100;

        /// <summary>
        /// The window message ID for a keyup event.
        /// </summary>
        private const int WM_KEYUP = 0x0101;

        /// <summary>
        /// Posts a message to a window.
        /// </summary>
        /// <param name="hWnd">The handle of the window to receive the message.</param>
        /// <param name="Msg">The message to send.</param>
        /// <param name="wParam">The first message parameter.</param>
        /// <param name="lParam">The second message parameter.</param>
        /// <returns>True if the message was posted successfully, false otherwise.</returns>
        [DllImport("user32.dll")]
        static extern IntPtr PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        /// <summary>
        /// Maps the virtual key.
        /// </summary>
        /// <returns>The virtual key.</returns>
        /// <param name="uCode">U code.</param>
        /// <param name="uMapType">U map type.</param>
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern uint MapVirtualKey(uint uCode, uint uMapType);

        /// <summary>
        /// Initializes a new instance of the <see cref="T:KeyStick.HotkeyWindow"/> class.
        /// </summary>
        public KeyNativeWindow()
        {
            // Create a hidden window for message handling
            CreateHandle(new CreateParams());
        }

        /// <summary>
        /// Registers a hotkey with the specified key and modifiers.
        /// </summary>
        /// <param name="key">The key to register.</param>
        /// <param name="modifiers">The modifier keys to combine with the key.</param>
        /// <param name="adviseUser">If set to <c>true</c> advise user.</param>
        public bool RegisterHotKey(Keys key, Modifiers modifiers, bool adviseUser)
        {
            bool success = false;

            int vk = (int)key;

            int fsModifiers = (int)modifiers;

            try
            {
                success = RegisterHotKey(this.Handle, 1, fsModifiers, vk);
            }
            catch
            {
                // Let it fall through
                ;
            }

            if (adviseUser && !success)
            {
                // Handle registration failure
                MessageBox.Show("Failed to register hotkey.");
            }

            return success;
        }

        /// <summary>
        /// Unregisters a previously registered hotkey.
        /// </summary>
        /// <param name="adviseUser">If set to <c>true</c> advise user.</param>
        public bool UnregisterHotkey(bool adviseUser)
        {
            bool success = false;

            try
            {
                success = UnregisterHotKey(this.Handle, 1);
            }
            catch
            {
                // Let it fall through
                ;
            }

            if (adviseUser && !success)
            {
                // Handle unregistration failure
                MessageBox.Show("Failed to unregister hotkey.");
            }

            return success;
        }

        /// <summary>
        /// Windows the proc.
        /// </summary>
        /// <param name="m">M.</param>
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_HOTKEY)
            {
                // Extract pressed key and modifier
                Keys key = (Keys)(((int)m.LParam >> 16) & 0xFFFF);
                Modifiers modifier = (Modifiers)((int)m.LParam & 0xFFFF);

                // Handle the hotkey press (e.g., call an event handler)
                OnHotkeyPressed?.Invoke(this, new KeyPressedEventArgs(modifier, key));
            }
        }

        /// <summary>
        /// Sends the key down.
        /// </summary>
        /// <param name="targetWindowHandle">Target window handle.</param>
        /// <param name="targetKey">Target key.</param>
        public void SendKeyDown(IntPtr targetWindowHandle, Keys targetKey)
        {
            uint virtualKeyCode = (uint)targetKey;
            uint scanCode = MapVirtualKey(virtualKeyCode, 0);
            IntPtr lParam = (IntPtr)((scanCode << 16) | 0x0001); // 0x0001 for key-down
            PostMessage(targetWindowHandle, 0x0100, (IntPtr)virtualKeyCode, lParam);
        }

        /// <summary>
        /// Sends the key up.
        /// </summary>
        /// <param name="targetWindowHandle">Target window handle.</param>
        /// <param name="targetKey">Target key.</param>
        public void SendKeyUp(IntPtr targetWindowHandle, Keys targetKey)
        {
            uint virtualKeyCode = (uint)targetKey;
            uint scanCode = MapVirtualKey(virtualKeyCode, 0);
            IntPtr lParam = (IntPtr)((scanCode << 16) | 0x0002); // 0x0002 for key-up
            PostMessage(targetWindowHandle, 0x0101, (IntPtr)virtualKeyCode, lParam);
        }

        /// <summary>
        /// Occurs when on hotkey pressed.
        /// </summary>
        public event EventHandler<KeyPressedEventArgs> OnHotkeyPressed;

        /// <summary>
        /// Releases all resource used by the <see cref="T:KeyStick.HotkeyWindow"/> object.
        /// </summary>
        /// <remarks>Call <see cref="Dispose"/> when you are finished using the <see cref="T:KeyStick.HotkeyWindow"/>. The
        /// <see cref="Dispose"/> method leaves the <see cref="T:KeyStick.HotkeyWindow"/> in an unusable state. After
        /// calling <see cref="Dispose"/>, you must release all references to the <see cref="T:KeyStick.HotkeyWindow"/>
        /// so the garbage collector can reclaim the memory that the <see cref="T:KeyStick.HotkeyWindow"/> was occupying.</remarks>
        public void Dispose()
        {
            DestroyHandle();
        }
    }
}