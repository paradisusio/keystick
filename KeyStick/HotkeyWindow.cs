/*#using System;
using System.Windows.Forms;

namespace KeyStick
{
    public class HotkeyWindow : NativeWindow, IDisposable
{
    private const int WM_HOTKEY = 0x0312;

    public HotkeyWindow()
    {
        // Create a hidden window for message handling
        CreateHandle(new CreateParams());
    }

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

    public event EventHandler<KeyPressedEventArgs> OnHotkeyPressed;

    public void Dispose()
    {
        DestroyHandle();
    }
}
}*/