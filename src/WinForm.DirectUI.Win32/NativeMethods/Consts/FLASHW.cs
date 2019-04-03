namespace WinForm.DirectUI.Win32
{
    //FLASHW定义
    public static partial class NativeMethods
    {
        /// <summary>
        /// Stop flashing. The system restores the window to its original state.
        /// </summary>
        public const int FLASHW_STOP = 0x00000000;
        /// <summary>
        /// Flash the window caption.
        /// </summary>
        public const int FLASHW_CAPTION = 0x00000001;
        /// <summary>
        /// Flash the taskbar button.
        /// </summary>
        public const int FLASHW_TRAY = 0x00000002;
        /// <summary>
        /// Flash both the window caption and taskbar button. This is equivalent to setting the FLASHW_CAPTION | FLASHW_TRAY flags.
        /// </summary>
        public const int FLASHW_ALL = 0x00000003;
        /// <summary>
        /// Flash continuously, until the FLASHW_STOP flag is set.
        /// </summary>
        public const int FLASHW_TIMER = 0x00000004;
        /// <summary>
        /// Flash continuously until the window comes to the foreground.
        /// </summary>
        public const int FLASHW_TIMERNOFG = 0x0000000C;
    }
}
