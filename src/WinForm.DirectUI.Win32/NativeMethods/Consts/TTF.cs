namespace WinForm.DirectUI.Win32
{
    //TTF定义
    public static partial class NativeMethods
    {
        /// <summary>
        /// Indicates that the uId member is the window handle to the tool. If this flag is not set, uId is the tool's identifier.
        /// </summary>
        public const int TTF_IDISHWND = 0x0001;
        /// <summary>
        /// Centers the tooltip window below the tool specified by the uId member.
        /// </summary>
        public const int TTF_CENTERTIP = 0x0002;
        /// <summary>
        /// Indicates that the tooltip text will be displayed in the opposite direction to the text in the parent window.
        /// </summary>
        public const int TTF_RTLREADING = 0x0004;
        /// <summary>
        /// Indicates that the tooltip control should subclass the tool's window to intercept messages, such as WM_MOUSEMOVE. If this flag is not set, you must use the TTM_RELAYEVENT message to forward messages to the tooltip control. For a list of messages that a tooltip control processes, see TTM_RELAYEVENT.
        /// </summary>
        public const int TTF_SUBCLASS = 0x0010;
        /// <summary>
        /// Version 4.70 and later. Positions the tooltip window next to the tool to which it corresponds and moves the window according to coordinates supplied by the TTM_TRACKPOSITION messages. You must activate this type of tool using the TTM_TRACKACTIVATE message.
        /// </summary>
        public const int TTF_TRACK = 0x0020;
        /// <summary>
        /// Version 4.70 and later. Positions the tooltip window at the same coordinates provided by TTM_TRACKPOSITION. This flag must be used with the TTF_TRACK flag.
        /// </summary>
        public const int TTF_ABSOLUTE = 0x0080;
        /// <summary>
        /// Version 4.70 and later. Causes the tooltip control to forward mouse event messages to the parent window. This is limited to mouse events that occur within the bounds of the tooltip window.
        /// </summary>
        public const int TTF_TRANSPARENT = 0x0100;
        /// <summary>
        /// Version 6.0 and later. Indicates that links in the tooltip text should be parsed.Note that Comctl32.dll version 6 is not redistributable but it is included in Windows XP or later. To use Comctl32.dll version 6, specify it in a manifest. For more information on manifests, see Enabling Visual Styles.
        /// </summary>
        public const int TTF_PARSELINKS = 0x1000;
        /// <summary>
        /// valid only on the TTN_NEEDTEXT callback
        /// </summary>
        public const int TTF_DI_SETITEM = 0x8000;
    }
}
