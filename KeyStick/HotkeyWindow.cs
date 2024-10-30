// <copyright file="HotkeyWindow.cs" company="Paradisus.io">
//     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
//     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// </copyright>

namespace KeyStick
{
    // Directives
    using System;
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
        /// Initializes a new instance of the <see cref="T:KeyStick.HotkeyWindow"/> class.
        /// </summary>
        public HotkeyWindow()
        {
            // Create a hidden window for message handling
            CreateHandle(new CreateParams());
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
                ModifierKeys modifier = (ModifierKeys)((int)m.LParam & 0xFFFF);

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