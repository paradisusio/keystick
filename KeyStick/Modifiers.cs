namespace KeyStick
{
    using System;

    [Flags]
    public enum Modifiers
    {
        None = 0x0000,
        Alt = 0x0001,
        Control = 0x0002,
        Shift = 0x0004,
        Windows = 0x0008
    }
}