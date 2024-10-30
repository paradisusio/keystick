// <copyright file="MainForm.cs" company="Paradisus.io">
//     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
//     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// </copyright>

namespace KeyStick
{
    // Directives
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    /// <summary>
    /// Key item.
    /// </summary>
    public class KeyItem
    {
        /// <summary>
        /// Gets the key code.
        /// </summary>
        /// <value>The key code.</value>
        public Keys KeyCode { get; private set; }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; private set; }

        /// <summary>
        /// Gets the list.
        /// </summary>
        /// <value>The list.</value>
        public static List<KeyItem> List
        {
            get
            {
                List<KeyItem> keyItems = new List<KeyItem>();

                foreach (Keys key in Enum.GetValues(typeof(Keys)))
                {
                    // Substitutions here
                    string keyString = key.ToString();

                    keyItems.Add(new KeyItem((Keys)Enum.Parse(typeof(Keys), keyString), keyString));
                }

                return keyItems;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:KeyStick.KeyItem"/> class.
        /// </summary>
        /// <param name="key">Key.</param>
        /// <param name="name">Name.</param>
        public KeyItem(Keys key, string name)
        {
            KeyCode = key;
            Name = name;
        }
    }
}