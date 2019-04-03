namespace WinForm.DirectUI.Win32
{
    //SB定义
    public static partial class NativeMethods
    {
        /// <summary>
        /// Shows or hides a window's standard horizontal scroll bars.
        /// </summary>
        public const int SB_HORZ = 0;
        /// <summary>
        /// Shows or hides a window's standard vertical scroll bar.
        /// </summary>
        public const int SB_VERT = 1;
        /// <summary>
        /// Shows or hides a scroll bar control. The hwnd parameter must be the handle to the scroll bar control.
        /// </summary>
        public const int SB_CTL = 2;
        /// <summary>
        /// Shows or hides a window's standard horizontal and vertical scroll bars.
        /// </summary>
        public const int SB_BOTH = 3;


        /// <summary>
        /// Scrolls one line up.
        /// </summary>
        public const int SB_LINEUP = 0;
        /// <summary>
        /// Scrolls left by one unit.
        /// </summary>
        public const int SB_LINELEFT = 0;
        /// <summary>
        /// Scrolls one line down.
        /// </summary>
        public const int SB_LINEDOWN = 1;
        /// <summary>
        /// Scrolls right by one unit.
        /// </summary>
        public const int SB_LINERIGHT = 1;
        /// <summary>
        /// Scrolls one page up.
        /// </summary>
        public const int SB_PAGEUP = 2;
        /// <summary>
        /// Scrolls left by the width of the window.
        /// </summary>
        public const int SB_PAGELEFT = 2;
        /// <summary>
        /// Scrolls one page down.
        /// </summary>
        public const int SB_PAGEDOWN = 3;
        /// <summary>
        /// Scrolls right by the width of the window.
        /// </summary>
        public const int SB_PAGERIGHT = 3;
        /// <summary>
        /// The user has dragged the scroll box (thumb) and released the mouse button. The HIWORD indicates the position of the scroll box at the end of the drag operation.
        /// </summary>
        public const int SB_THUMBPOSITION = 4;
        /// <summary>
        /// The user is dragging the scroll box. This message is sent repeatedly until the user releases the mouse button. The HIWORD indicates the position that the scroll box has been dragged to.
        /// </summary>
        public const int SB_THUMBTRACK = 5;
        /// <summary>
        /// Scrolls to the upper left.
        /// </summary>
        public const int SB_TOP = 6;
        /// <summary>
        /// Scrolls to the upper left.
        /// </summary>
        public const int SB_LEFT = 6;
        /// <summary>
        /// Scrolls to the lower right.
        /// </summary>
        public const int SB_BOTTOM = 7;
        /// <summary>
        /// Scrolls to the lower right.
        /// </summary>
        public const int SB_RIGHT = 7;
        /// <summary>
        /// Ends scroll.
        /// </summary>
        public const int SB_ENDSCROLL = 8;
    }
}
