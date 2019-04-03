namespace WinForm.DirectUI.Win32
{
    //KEYEVENTF定义
    public static partial class NativeMethods
    {
        /// <summary>
        /// If specified, the scan code was preceded by a prefix byte that has the value 0xE0 (224).
        /// </summary>
        public const int KEYEVENTF_EXTENDEDKEY = 0x0001;
        /// <summary>
        /// If specified, the key is being released. If not specified, the key is being pressed.
        /// </summary>
        public const int KEYEVENTF_KEYUP = 0x0002;
        /// <summary>
        /// If specified, the system synthesizes a VK_PACKET keystroke. The wVk parameter must be zero. This flag can only be combined with the KEYEVENTF_KEYUP flag. For more information, see the Remarks section.
        /// </summary>
        public const int KEYEVENTF_UNICODE = 0x0004;
        /// <summary>
        /// If specified, wScan identifies the key and wVk is ignored.
        /// </summary>
        public const int KEYEVENTF_SCANCODE = 0x0008;
    }
}
