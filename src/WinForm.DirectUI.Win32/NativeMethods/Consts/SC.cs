namespace WinForm.DirectUI.Win32
{
    //SC定义
    public static partial class NativeMethods
    {
        /// <summary>
        /// Sizes the window.
        /// </summary>
        public const int SC_SIZE = 0xF000;
        /// <summary>
        /// Moves the window.
        /// </summary>
        public const int SC_MOVE = 0xF010;
        /// <summary>
        /// Minimizes the window.
        /// </summary>
        public const int SC_MINIMIZE = 0xF020;
        /// <summary>
        /// Maximizes the window.
        /// </summary>
        public const int SC_MAXIMIZE = 0xF030;
        /// <summary>
        /// Moves to the next window.
        /// </summary>
        public const int SC_NEXTWINDOW = 0xF040;
        /// <summary>
        /// Moves to the previous window.
        /// </summary>
        public const int SC_PREVWINDOW = 0xF050;
        /// <summary>
        /// Closes the window.
        /// </summary>
        public const int SC_CLOSE = 0xF060;
        /// <summary>
        /// Scrolls vertically.
        /// </summary>
        public const int SC_VSCROLL = 0xF070;
        /// <summary>
        /// Scrolls horizontally.
        /// </summary>
        public const int SC_HSCROLL = 0xF080;
        /// <summary>
        /// Retrieves the window menu as a result of a mouse click.
        /// </summary>
        public const int SC_MOUSEMENU = 0xF090;
        /// <summary>
        /// Retrieves the window menu as a result of a keystroke.For more information, see the Remarks section.
        /// </summary>
        public const int SC_KEYMENU = 0xF100;
        /// <summary>
        /// TODO
        /// </summary>
        public const int SC_ARRANGE = 0xF110;
        /// <summary>
        /// Restores the window to its normal position and size.
        /// </summary>
        public const int SC_RESTORE = 0xF120;
        /// <summary>
        /// Activates the Start menu.
        /// </summary>
        public const int SC_TASKLIST = 0xF130;
        /// <summary>
        /// Executes the screen saver application specified in the [boot] section of the System.ini file.
        /// </summary>
        public const int SC_SCREENSAVE = 0xF140;
        /// <summary>
        /// Activates the window associated with the application-specified hot key.The lParam parameter identifies the window to activate.
        /// </summary>
        public const int SC_HOTKEY = 0xF150;

        //#if(WINVER >= 0x0400) //Win95
        /// <summary>
        /// Selects the default item; the user double-clicked the window menu.
        /// </summary>
        public const int SC_DEFAULT = 0xF160;
        /// <summary>
        /// Sets the state of the display. This command supports devices that have power-saving features, such as a battery-powered personal computer.
        /// The lParam parameter can have the following values: -1 = the display is powering on,1 = the display is going to low power, 2 = the display is being shut off
        /// </summary>
        public const int SC_MONITORPOWER = 0xF170;
        /// <summary>
        /// Changes the cursor to a question mark with a pointer. If the user then clicks a control in the dialog box, the control receives a WM_HELP message.
        /// </summary>
        public const int SC_CONTEXTHELP = 0xF180;
        /// <summary>
        /// TODO
        /// </summary>
        public const int SC_SEPARATOR = 0xF00F;
        //#endif /* WINVER >= 0x0400 */

        //#if(WINVER >= 0x0600) //Vista
        /// <summary>
        /// Indicates whether the screen saver is secure.
        /// </summary>
        public const int SCF_ISSECURE = 0x00000001;
        //#endif /* WINVER >= 0x0600 */

        /// <summary>
        /// Obsolete names
        /// </summary>
        public const int SC_ICON = SC_MINIMIZE;
        /// <summary>
        /// Obsolete names
        /// </summary>
        public const int SC_ZOOM = SC_MAXIMIZE;
    }
}
