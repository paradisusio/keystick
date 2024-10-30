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
    /// Key pressed event arguments.
    /// </summary>
    public class KeyPressedEventArgs : EventArgs
    {
        /// <summary>
        /// Gets the modifiers.
        /// </summary>
        /// <value>The modifiers.</value>
        public ModifierKeys Modifiers { get; }

        /// <summary>
        /// Gets the key.
        /// </summary>
        /// <value>The key.</value>
        public Keys Key { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:KeyStick.KeyPressedEventArgs"/> class.
        /// </summary>
        /// <param name="modifiers">Modifiers.</param>
        /// <param name="key">Key.</param>
        public KeyPressedEventArgs(ModifierKeys modifiers, Keys key)
        {
            Modifiers = modifiers;
            Key = key;
        }
    }
}
