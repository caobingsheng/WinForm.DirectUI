namespace WinForm.DirectUI.Win32
{
    //DCX定义
    public static partial class NativeMethods
    {
        /// <summary>
        /// Returns a DC that corresponds to the window rectangle rather than the client rectangle.
        /// </summary>
        public const int DCX_WINDOW = 0x00000001;
        /// <summary>
        /// Returns a DC from the cache, rather than the OWNDC or CLASSDC window. Essentially overrides CS_OWNDC and CS_CLASSDC.
        /// </summary>
        public const int DCX_CACHE = 0x00000002;
        /// <summary>
        /// Does not reset the attributes of this DC to the default attributes when this DC is released.
        /// </summary>
        public const int DCX_NORESETATTRS = 0x00000004;
        /// <summary>
        /// Excludes the visible regions of all child windows below the window identified by hWnd.
        /// </summary>
        public const int DCX_CLIPCHILDREN = 0x00000008;
        /// <summary>
        /// Excludes the visible regions of all sibling windows above the window identified by hWnd.
        /// </summary>
        public const int DCX_CLIPSIBLINGS = 0x00000010;
        /// <summary>
        /// Uses the visible region of the parent window. The parent's WS_CLIPCHILDREN and CS_PARENTDC style bits are ignored. The origin is set to the upper-left corner of the window identified by hWnd.
        /// </summary>
        public const int DCX_PARENTCLIP = 0x00000020;
        /// <summary>
        /// The clipping region identified by hrgnClip is excluded from the visible region of the returned DC.
        /// </summary>
        public const int DCX_EXCLUDERGN = 0x00000040;
        /// <summary>
        /// The clipping region identified by hrgnClip is intersected with the visible region of the returned DC.
        /// </summary>
        public const int DCX_INTERSECTRGN = 0x00000080;
        /// <summary>
        /// DCX_EXCLUDEUPDATE
        /// </summary>
        public const int DCX_EXCLUDEUPDATE = 0x00000100;
        /// <summary>
        /// Reserved; do not use.
        /// </summary>
        public const int DCX_INTERSECTUPDATE = 0x00000200;
        /// <summary>
        /// Allows drawing even if there is a LockWindowUpdate call in effect that would otherwise exclude this window. Used for drawing during tracking.
        /// </summary>
        public const int DCX_LOCKWINDOWUPDATE = 0x00000400;
        /// <summary>
        /// Reserved; do not use.
        /// </summary>
        public const int DCX_VALIDATE = 0x00200000;
    }
}
