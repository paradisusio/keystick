// <copyright file="KeyPressedEventArgs.cs" company="Paradisus.io">
//     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
//     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// </copyright>

namespace KeyStick
{
    // Directives
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// Provides data for the <see cref="HotkeyWindow.OnHotkeyPressed"/> event.
    /// </summary>
    public class KeyPressedEventArgs : EventArgs
    {
        /// <summary>
        /// Gets the modifier keys that were pressed along with the keystroke.
        /// </summary>
        public Modifiers Modifiers { get; }

        /// <summary>
        /// Gets the key that was pressed.
        /// </summary>
        public Keys Key { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyPressedEventArgs"/> class.
        /// </summary>
        /// <param name="modifiers">The modifier keys that were pressed.</param>
        /// <param name="key">The key that was pressed.</param>
        public KeyPressedEventArgs(Modifiers modifiers, Keys key)
        {
            Modifiers = modifiers;
            Key = key;
        }
    }
}


