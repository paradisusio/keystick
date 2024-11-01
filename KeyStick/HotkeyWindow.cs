// <copyright file="HotkeyWindow.cs" company="Paradisus.io">
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
    /// Hotkey window.
    /// </summary>
    public class HotkeyWindow : NativeWindow, IDisposable
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
        /// Initializes a new instance of the <see cref="T:KeyStick.HotkeyWindow"/> class.
        /// </summary>
        public HotkeyWindow()
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