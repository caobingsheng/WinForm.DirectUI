namespace WinForm.DirectUI.Win32
{
    //TTN定义
    public static partial class NativeMethods
    {
        /// <summary>
        /// 开始
        /// </summary>
        public const int TTN_FIRST = -520;
        /// <summary>
        /// 结束
        /// </summary>
        public const int TTN_LAST = -549;
        /// <summary>
        /// Notifies the owner window that a tooltip control is about to be displayed. This notification code is sent in the form of a WM_NOTIFY message.
        /// </summary>
        public const int TTN_SHOW = TTN_FIRST - 1;
        /// <summary>
        /// Notifies the owner window that a tooltip is about to be hidden. This notification code is sent in the form of a WM_NOTIFY message.
        /// </summary>
        public const int TTN_POP = TTN_FIRST - 2;
        /// <summary>
        /// Sent when a text link inside a balloon tooltip is clicked. This notification code is sent in the form of a WM_NOTIFY message.
        /// </summary>
        public const int TTN_LINKCLICK = TTN_FIRST - 3;
        /// <summary>
        /// Sent by a tooltip control to retrieve information needed to display a tooltip window. This notification code is sent in the form of a WM_NOTIFY message.
        /// </summary>
        public const int TTN_GETDISPINFO = TTN_FIRST - 10;
        /// <summary>
        /// Sent by a tooltip control to retrieve information needed to display a tooltip window. This notification code is identical to TTN_GETDISPINFO. This notification code is sent in the form of a WM_NOTIFY message.
        /// </summary>
        public const int TTN_NEEDTEXT = TTN_FIRST - 10;
    }
}
