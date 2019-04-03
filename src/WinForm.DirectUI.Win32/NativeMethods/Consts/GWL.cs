namespace WinForm.DirectUI.Win32
{
    //GWL定义
    public static partial class NativeMethods
    {
        /// <summary>
        /// Retrieves the user data associated with the window. This data is intended for use by the application that created the window. Its value is initially zero.
        /// </summary>
        public const int GWL_USERDATA = -21;
        /// <summary>
        /// Retrieves the extended window styles.
        /// </summary>
        public const int GWL_EXSTYLE = -20;
        /// <summary>
        /// Retrieves the window styles.
        /// </summary>
        public const int GWL_STYLE = -16;
        /// <summary>
        /// Retrieves the identifier of the window.
        /// </summary>
        public const int GWL_ID = -12;
        /// <summary>
        /// Retrieves a handle to the parent window, if any.GetWindowLong return parent window handle,SetWindowLong set owner window handle.See also GetParent(if parent is NULL return owner window handle) Set Parent.Tim 2013.11.23
        /// </summary>
        public const int GWL_HWNDPARENT = -8;
        /// <summary>
        /// Retrieves a handle to the application instance.
        /// </summary>
        public const int GWL_HINSTANCE = -6;
        /// <summary>
        /// Retrieves the address of the window procedure, or a handle representing the address of the window procedure. You must use the CallWindowProc function to call the window procedure.
        /// </summary>
        public const int GWL_WNDPROC = -4;
    }
}
