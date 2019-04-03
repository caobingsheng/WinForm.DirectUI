namespace WinForm.DirectUI.Win32
{
    //MOUSEEVENTF定义
    public static partial class NativeMethods
    {
        /// <summary>
        /// Movement occurred.
        /// </summary>
        public const int MOUSEEVENTF_MOVE = 0x0001;
        /// <summary>
        /// The left button was pressed.
        /// </summary>
        public const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        /// <summary>
        /// The left button was released.
        /// </summary>
        public const int MOUSEEVENTF_LEFTUP = 0x0004;
        /// <summary>
        /// The right button was pressed.
        /// </summary>
        public const int MOUSEEVENTF_RIGHTDOWN = 0x0008;
        /// <summary>
        /// The right button was released.
        /// </summary>
        public const int MOUSEEVENTF_RIGHTUP = 0x0010;
        /// <summary>
        /// The middle button was pressed.
        /// </summary>
        public const int MOUSEEVENTF_MIDDLEDOWN = 0x0020;
        /// <summary>
        /// The middle button was released.
        /// </summary>
        public const int MOUSEEVENTF_MIDDLEUP = 0x0040;
        /// <summary>
        /// An X button was pressed.
        /// </summary>
        public const int MOUSEEVENTF_XDOWN = 0x0080;
        /// <summary>
        /// An X button was released.
        /// </summary>
        public const int MOUSEEVENTF_XUP = 0x0100;
        /// <summary>
        /// The wheel was moved, if the mouse has a wheel. The amount of movement is specified in mouseData.
        /// </summary>
        public const int MOUSEEVENTF_WHEEL = 0x0800;
        /// <summary>
        /// The wheel was moved horizontally, if the mouse has a wheel. The amount of movement is specified in mouseData.Windows XP/2000:  This value is not supported.
        /// </summary>
        public const int MOUSEEVENTF_HWHEEL = 0x01000;
        /// <summary>
        /// The WM_MOUSEMOVE messages will not be coalesced. The default behavior is to coalesce WM_MOUSEMOVE messages.Windows XP/2000:  This value is not supported.
        /// </summary>
        public const int MOUSEEVENTF_MOVE_NOCOALESCE = 0x2000;
        /// <summary>
        /// Maps coordinates to the entire desktop. Must be used with MOUSEEVENTF_ABSOLUTE.
        /// </summary>
        public const int MOUSEEVENTF_VIRTUALDESK = 0x4000;
        /// <summary>
        /// The dx and dy members contain normalized absolute coordinates. If the flag is not set, dxand dy contain relative data (the change in position since the last reported position). This flag can be set, or not set, regardless of what kind of mouse or other pointing device, if any, is connected to the system. For further information about relative mouse motion, see the following Remarks section.
        /// </summary>
        public const int MOUSEEVENTF_ABSOLUTE = 0x8000;
    }
}
