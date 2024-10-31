// <copyright file="MainForm.cs" company="Paradisus.io">
//     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
//     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// </copyright>

namespace KeyStick
{
    // Directives
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.InteropServices;
    using System.Text;
    using System.Windows.Forms;
    using ParadisusIo;

    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool IsWindowVisible(IntPtr hWnd);

        [DllImport("user32.dll", EntryPoint = "GetWindowText", ExactSpelling = false, CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int GetWindowText(IntPtr hWnd, StringBuilder lpWindowText, int nMaxCount);

        [DllImport("user32.dll", EntryPoint = "EnumDesktopWindows", ExactSpelling = false, CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool EnumDesktopWindows(IntPtr hDesktop, EnumDelegate lpEnumCallbackFunction, IntPtr lParam);

        private delegate bool EnumDelegate(IntPtr hWnd, int lParam);

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
        /// The window message ID for a keydown event.
        /// </summary>
        private const int WM_KEYDOWN = 0x0100;

        /// <summary>
        /// The window message ID for a keyup event.
        /// </summary>
        private const int WM_KEYUP = 0x0101;

        /// <summary>
        /// The target window handle.
        /// </summary>
        private IntPtr targetWindowHandle = IntPtr.Zero;

        /// <summary>
        /// Gets or sets the associated icon.
        /// </summary>
        /// <value>The associated icon.</value>
        private Icon associatedIcon = null;

        /// <summary>
        /// The settings data.
        /// </summary>
        private SettingsData settingsData = null;

        /// <summary>
        /// The settings data path.
        /// </summary>
        private string settingsDataPath = $"{Application.ProductName}-SettingsData.txt";

        /// <summary>
        /// The target window dictionary.
        /// </summary>
        private Dictionary<IntPtr, string> targetWindowDictionary = new Dictionary<IntPtr, string>();

        /// <summary>
        /// The hotkey window.
        /// </summary>
        private HotkeyWindow hotkeyWindow;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:KeyStick.MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            this.InitializeComponent();

            // Set associated icon from exe file
            this.associatedIcon = Icon.ExtractAssociatedIcon(typeof(MainForm).GetTypeInfo().Assembly.Location);

            // Set the key items list
            List<KeyItem> keyItems = KeyItem.List;

            // Populate hotkey combo box
            this.hotkeyComboBox.DataSource = keyItems;
            this.hotkeyComboBox.DisplayMember = nameof(KeyItem.Name);
            this.hotkeyComboBox.ValueMember = nameof(KeyItem.KeyCode);

            // Populate key combo box
            this.keyComboBox.DataSource = keyItems;
            this.keyComboBox.DisplayMember = nameof(KeyItem.Name);
            this.keyComboBox.ValueMember = nameof(KeyItem.KeyCode);

            // Set the hotkey window
            this.hotkeyWindow = new HotkeyWindow();

            // Subscribe to the hotkey pressed event
            this.hotkeyWindow.OnHotkeyPressed += this.OnHotkeyPressed;
        }

        /// <summary>
        /// Populates the target window list.
        /// </summary>
        private void PopulateTargetWindowList()
        {
            // Begin updating
            this.targetListView.BeginUpdate();

            // Reset 
            this.targetWindowDictionary.Clear();
            this.targetListView.Items.Clear();

            // Add windows
            if (EnumDesktopWindows(IntPtr.Zero, EnumDesktopWindowsCallback, IntPtr.Zero))
            {
                foreach (var window in targetWindowDictionary)
                {
                    // Add 
                    var listVIewItem = new ListViewItem()
                    {
                        Text = window.Value,
                        Tag = window.Key
                    };

                    this.targetListView.Items.Add(listVIewItem);
                }
            }

            // Adjust column width 
            this.targetListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

            // End updating
            this.targetListView.EndUpdate();
        }

        /// <summary>
        /// Enums the desktop windows callback.
        /// </summary>
        /// <returns><c>true</c>, if desktop windows callback was enumed, <c>false</c> otherwise.</returns>
        /// <param name="hWnd">H window.</param>
        /// <param name="lParam">L parameter.</param>
        private bool EnumDesktopWindowsCallback(IntPtr hWnd, int lParam)
        {
            StringBuilder titleStringBuilder = new StringBuilder(1024);

            GetWindowText(hWnd, titleStringBuilder, titleStringBuilder.Capacity + 1);

            string windowTitle = titleStringBuilder.ToString();

            // TODO Visible, with text and not self [May be good to handle the start and manager additions]
            if (IsWindowVisible(hWnd) && string.IsNullOrEmpty(windowTitle) == false && hWnd != this.Handle)
            {
                targetWindowDictionary.Add(hWnd, windowTitle);
            }

            return true;
        }

        /// <summary>
        /// Sets the hotkey.
        /// </summary>
        private void SetHotkey()
        {
            /* Checks */

            // At least one checkbox and a key
            if ((!this.controlCheckBox.Checked && !this.altCheckBox.Checked && !this.shiftCheckBox.Checked) || this.hotkeyComboBox.SelectedText.ToLowerInvariant() == "none")
            {
                // Halt flow
                return;
            }

            /* Set it */

            // Unregister any previous hotkey
            this.hotkeyWindow.UnregisterHotkey(false);

            // Register the current hotkey 
            this.hotkeyWindow.RegisterHotKey((Keys)this.hotkeyComboBox.SelectedItem, (this.controlCheckBox.Checked ? Modifiers.Control : 0) | (this.shiftCheckBox.Checked ? Modifiers.Shift : 0) | (this.altCheckBox.Checked ? Modifiers.Alt : 0), false);
        }

        /// <summary>
        /// Handles the pressed hotkey.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">E.</param>
        private void OnHotkeyPressed(object sender, KeyPressedEventArgs e)
        {
            // Handle hotkey press
            MessageBox.Show("Hotkey pressed: " + e.Key.ToString() + " with modifiers: " + e.Modifiers.ToString());
        }

        /// <summary>
        /// Handles the key press check box checked changed.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">E.</param>
        private void OnKeyPressCheckBoxCheckedChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the refresh button click.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">E.</param>
        private void OnRefreshButtonClick(object sender, EventArgs e)
        {
            // Populate list
            this.PopulateTargetWindowList();
        }

        /// <summary>
        /// Handles the main form load.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">E.</param>
        private void OnMainFormLoad(object sender, EventArgs e)
        {
            // Populate list
            this.PopulateTargetWindowList();
        }

        /// <summary>
        /// Handles the main form form closing.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">E.</param>
        private void OnMainFormFormClosing(object sender, FormClosingEventArgs e)
        {
            // Dispose of the hotkey window
            this.hotkeyWindow.Dispose();
        }

        /// <summary>
        /// Handles the new tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">E.</param>
        private void OnNewToolStripMenuItemClick(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the options tool strip menu item drop down item clicked.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">E.</param>
        private void OnOptionsToolStripMenuItemDropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        /// <summary>
        /// Handles the free Releases @ Paradisus.io tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">E.</param>
        private void OnFreeReleasesParadisusioToolStripMenuItemClick(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the original thread donation codercom tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">E.</param>
        private void OnOriginalThreadDonationCodercomToolStripMenuItemClick(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the source code githubcom tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">E.</param>
        private void OnSourceCodeGithubcomToolStripMenuItemClick(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the about tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">E.</param>
        private void OnAboutToolStripMenuItemClick(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the exit tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">E.</param>
        private void OnExitToolStripMenuItemClick(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the key press timer tick.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">E.</param>
        private void OnKeyPressTimerTick(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the check box checked changed.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">E.</param>
        private void OnCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            // Set the hotkey
            this.SetHotkey();
        }

        /// <summary>
        /// Handles the hotkey combo box selected index changed.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">E.</param>
        private void OnHotkeyComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            // Set the hotkey
            this.SetHotkey();
        }
    }
}
