namespace WinForm.DirectUI.Win32
{
    //KLF定义
    public static partial class NativeMethods
    {
        /// <summary>
        /// This flag is unsupported. Use the UnloadKeyboardLayout function instead.
        /// </summary>
        public const uint KLF_UNLOADPREVIOUS = 0x00000000;
        /// <summary>
        /// If this bit is set, the system's circular list of loaded locale identifiers is reordered by moving the locale identifier to the head of the list. If this bit is not set, the list is rotated without a change of order.For example, if a user had an English locale identifier active, as well as having French, German, and Spanish locale identifiers loaded (in that order), then activating the German locale identifier with the KLF_REORDER bit set would produce the following order: German, English, French, Spanish. Activating the German locale identifier without the KLF_REORDER bit set would produce the following order: German, Spanish, English, French.If less than three locale identifiers are loaded, the value of this flag is irrelevant.
        /// </summary>
        public const uint KLF_REORDER = 0x00000008;
        /// <summary>
        /// Activates the specified locale identifier for the entire process and sends the WM_INPUTLANGCHANGE message to the current thread's focus or active window.
        /// </summary>
        public const uint KLF_SETFORPROCESS = 0x00000100;
        /// <summary>
        /// This is used with KLF_RESET. See KLF_RESET for an explanation.
        /// </summary>
        public const uint KLF_SHIFTLOCK = 0x00010000;
        /// <summary>
        /// If set but KLF_SHIFTLOCK is not set, the Caps Lock state is turned off by pressing the Caps Lock key again. If set and KLF_SHIFTLOCK is also set, the Caps Lock state is turned off by pressing either SHIFT key.These two methods are mutually exclusive, and the setting persists as part of the User's profile in the registry.
        /// </summary>
        public const uint KLF_RESET = 0x40000000;
    }
}
