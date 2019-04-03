namespace WinForm.DirectUI.Win32
{
    //TTM定义
    public static partial class NativeMethods
    {
        /// <summary>
        /// Activates or deactivates a tooltip control.
        /// </summary>
        public const int TTM_ACTIVATE = WM_USER + 1;
        /// <summary>
        /// Sets the initial, pop-up, and reshow durations for a tooltip control.
        /// </summary>
        public const int TTM_SETDELAYTIME = WM_USER + 3;
        /// <summary>
        /// Registers a tool with a tooltip control.
        /// </summary>
        public const int TTM_ADDTOOL = WM_USER + 50;
        /// <summary>
        /// Removes a tool from a tooltip control.
        /// </summary>
        public const int TTM_DELTOOL = WM_USER + 51;
        /// <summary>
        /// Sets a new bounding rectangle for a tool.
        /// </summary>
        public const int TTM_NEWTOOLRECT = WM_USER + 52;
        /// <summary>
        /// Passes a mouse message to a tooltip control for processing.
        /// </summary>
        public const int TTM_RELAYEVENT = WM_USER + 7;
        /// <summary>
        /// Retrieves the information that a tooltip control maintains about a tool.
        /// </summary>
        public const int TTM_GETTOOLINFO = WM_USER + 53;
        /// <summary>
        /// Sets the information that a tooltip control maintains for a tool.
        /// </summary>
        public const int TTM_SETTOOLINFO = WM_USER + 54;
        /// <summary>
        /// Tests a point to determine whether it is within the bounding rectangle of the specified tool and, if it is, retrieves information about the tool.
        /// </summary>
        public const int TTM_HITTEST = WM_USER + 55;
        /// <summary>
        /// Retrieves the information a tooltip control maintains about a tool.
        /// </summary>
        public const int TTM_GETTEXT = WM_USER + 56;
        /// <summary>
        /// Sets the tooltip text for a tool.
        /// </summary>
        public const int TTM_UPDATETIPTEXT = WM_USER + 57;
        /// <summary>
        /// Retrieves a count of the tools maintained by a tooltip control.
        /// </summary>
        public const int TTM_GETTOOLCOUNT = WM_USER + 13;
        /// <summary>
        /// Retrieves the information that a tooltip control maintains about the current tool—that is, the tool for which the tooltip is currently displaying text.
        /// </summary>
        public const int TTM_ENUMTOOLS = WM_USER + 58;
        /// <summary>
        /// Retrieves the information for the current tool in a tooltip control.
        /// </summary>
        public const int TTM_GETCURRENTTOOL = WM_USER + 59;
        /// <summary>
        /// Allows a subclass procedure to cause a tooltip to display text for a window other than the one beneath the mouse cursor.
        /// </summary>
        public const int TTM_WINDOWFROMPOINT = WM_USER + 16;
        /// <summary>
        /// Activates or deactivates a tracking tooltip.
        /// </summary>
        public const int TTM_TRACKACTIVATE = WM_USER + 17;
        /// <summary>
        /// Sets the position of a tracking tooltip.
        /// </summary>
        public const int TTM_TRACKPOSITION = WM_USER + 18;
        /// <summary>
        /// Sets the background color in a tooltip window.
        /// </summary>
        public const int TTM_SETTIPBKCOLOR = WM_USER + 19;
        /// <summary>
        /// Sets the text color in a tooltip window.
        /// </summary>
        public const int TTM_SETTIPTEXTCOLOR = WM_USER + 20;
        /// <summary>
        /// Retrieves the initial, pop-up, and reshow durations currently set for a tooltip control.
        /// </summary>
        public const int TTM_GETDELAYTIME = WM_USER + 21;
        /// <summary>
        /// Retrieves the background color in a tooltip window.
        /// </summary>
        public const int TTM_GETTIPBKCOLOR = WM_USER + 22;
        /// <summary>
        /// Retrieves the text color in a tooltip window.
        /// </summary>
        public const int TTM_GETTIPTEXTCOLOR = WM_USER + 23;
        /// <summary>
        /// Sets the maximum width for a tooltip window.
        /// </summary>
        public const int TTM_SETMAXTIPWIDTH = WM_USER + 24;
        /// <summary>
        /// Retrieves the maximum width for a tooltip window.
        /// </summary>
        public const int TTM_GETMAXTIPWIDTH = WM_USER + 25;
        /// <summary>
        /// Sets the top, left, bottom, and right margins for a tooltip window. A margin is the distance, in pixels, between the tooltip window border and the text contained within the tooltip window.
        /// </summary>
        public const int TTM_SETMARGIN = WM_USER + 26;
        /// <summary>
        /// Retrieves the top, left, bottom, and right margins set for a tooltip window. A margin is the distance, in pixels, between the tooltip window border and the text contained within the tooltip window.
        /// </summary>
        public const int TTM_GETMARGIN = WM_USER + 27;
        /// <summary>
        /// Removes a displayed tooltip window from view.
        /// </summary>
        public const int TTM_POP = WM_USER + 28;
        /// <summary>
        /// Forces the current tooltip to be redrawn.
        /// </summary>
        public const int TTM_UPDATE = WM_USER + 29;
        /// <summary>
        /// Returns the width and height of a tooltip control.
        /// </summary>
        public const int TTM_GETBUBBLESIZE = WM_USER + 30;
        /// <summary>
        /// Calculates a tooltip control's text display rectangle from its window rectangle, or the tooltip window rectangle needed to display a specified text display rectangle.
        /// </summary>
        public const int TTM_ADJUSTRECT = WM_USER + 31;
        /// <summary>
        /// Adds a standard icon and title string to a tooltip.
        /// </summary>
        public const int TTM_SETTITLE = WM_USER + 33;
        /// <summary>
        /// Causes the tooltip to display at the coordinates of the last mouse message.
        /// </summary>
        public const int TTM_POPUP = WM_USER + 34;
        /// <summary>
        /// Retrieve information concerning the title of a tooltip control.
        /// </summary>
        public const int TTM_GETTITLE = WM_USER + 35;
        /// <summary>
        /// Sets the visual style of a tooltip control.
        /// </summary>
        public const int TTM_SETWINDOWTHEME = 0x200B;
    }
}
