namespace WinForm.DirectUI.Win32
{
    //SBM定义
    public static partial class NativeMethods
    {
        /// <summary>
        /// <para>The SBM_SETPOS message is sent to set the position of the scroll box (thumb) and, if requested, redraw the scroll bar to reflect the new position of the scroll box.</para>
        /// <para>Applications should not send this message directly.</para>
        /// <para>Instead, they should use the SetScrollPos function.</para>
        /// <para>A window receives this message through its WindowProc function.</para>
        /// <para>Applications which implement a custom scroll bar control must respond to these messages for the SetScrollPos function to work properly.</para>
        /// </summary>
        public const int SBM_SETPOS = 0x00E0;
        /// <summary>
        /// <para>The SBM_GETPOS message is sent to retrieve the current position of the scroll box of a scroll bar control.</para>
        /// <para>The current position is a relative value that depends on the current scrolling range.</para>
        /// <para>For example, if the scrolling range is 0 through 100 and the scroll box is in the middle of the bar, the current position is 50.</para>
        /// <para>Applications should not send this message directly. Instead, they should use the GetScrollPos function.</para>
        /// <para>A window receives this message through its WindowProc function.</para>
        /// <para>Applications which implement a custom scroll bar control must respond to these messages for the GetScrollPos function to function properly.</para>
        /// </summary> 
        public const int SBM_GETPOS = 0x00E1;
        /// <summary>
        /// <para>The SBM_SETRANGE message is sent to set the minimum and maximum position values for the scroll bar control.</para>
        /// <para>Applications should not send this message directly.</para>
        /// <para>Instead, they should use the SetScrollRange function.</para>
        /// <para>A window receives this message through its WindowProc function.</para>
        /// <para>Applications which implement a custom scroll bar control must respond to these messages for the SetScrollRange function to work properly.</para>
        /// </summary> 
        public const int SBM_SETRANGE = 0x00E2;
        /// <summary>
        /// An application sends the SBM_SETRANGEREDRAW message to a scroll bar control to set the minimum and maximum position values and to redraw the control.to work properly.
        /// </summary>
        public const int SBM_SETRANGEREDRAW = 0x00E6;
        /// <summary>
        /// <para>The SBM_GETRANGE message is sent to retrieve the minimum and maximum position values for the scroll bar control.</para>
        /// <para>Applications should not send this message directly. Instead, they should use the GetScrollRange function.</para>
        /// <para>A window receives this message through its WindowProc function.</para>
        /// <para>Applications which implement a custom scroll bar control must respond to these messages for the GetScrollRange function to work properly.</para>
        /// </summary>
        public const int SBM_GETRANGE = 0x00E3;
        /// <summary>
        /// An application sends the SBM_ENABLE_ARROWS message to enable or disable one or both arrows of a scroll bar control.
        /// </summary>
        public const int SBM_ENABLE_ARROWS = 0x00E4;
        /// <summary>
        /// <para>The SBM_SETSCROLLINFO message is sent to set the parameters of a scroll bar.</para>
        /// <para>Applications should not send this message directly.</para>
        /// <para>Instead, they should use the SetScrollInfo function.</para>
        /// <para>A window receives this message through its WindowProc function.</para>
        /// <para>Applications which implement a custom scroll bar control must respond to these messages for the SetScrollInfo function to function properly.</para>
        /// </summary>
        public const int SBM_SETSCROLLINFO = 0x00E9;
        /// <summary>
        /// <para>The SBM_GETSCROLLINFO message is sent to retrieve the parameters of a scroll bar.</para>
        /// <para>Applications should not send this message directly. Instead, they should use the GetScrollInfo function.</para>
        /// <para>A window receives this message through its WindowProc function.</para>
        /// <para>Applications which implement a custom scroll bar control must respond to these messages for the GetScrollInfo function to work properly.</para>
        /// </summary>
        public const int SBM_GETSCROLLINFO = 0x00EA;
        /// <summary>
        /// Sent by an application to retrieve information about the specified scroll bar.
        /// </summary>
        public const int SBM_GETSCROLLBARINFO = 0x00EB;
    }
}
