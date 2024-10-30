using System;
namespace KeyStick
{
    [Flags]
    public enum ModifierKeys
    {
        None = 0x0000,
        Alt = 0x0001,
        Control = 0x0002,
        Shift = 0x0004,
        Windows = 0x0008
    }
}
