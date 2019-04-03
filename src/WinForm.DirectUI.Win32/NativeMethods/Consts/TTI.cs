namespace WinForm.DirectUI.Win32
{
    //TTI定义
    public static partial class NativeMethods
    {
        /// <summary>
        /// Use no icon.
        /// </summary>
        public const int TTI_NONE = 0;
        /// <summary>
        /// Use the information icon.
        /// </summary>
        public const int TTI_INFO = 1;
        /// <summary>
        /// Use the warning icon.
        /// </summary>
        public const int TTI_WARNING = 2;
        /// <summary>
        /// Use the error icon.
        /// </summary>
        public const int TTI_ERROR = 3;
        /// <summary>
        /// Use the large information icon. This is assumed to be an HICON value.
        /// </summary>
        public const int TTI_INFO_LARGE = 4;
        /// <summary>
        /// Use the large warning icon. This is assumed to be an HICON value.
        /// </summary>
        public const int TTI_WARNING_LARGE = 5;
        /// <summary>
        /// Use the large error icon. This is assumed to be an HICON value.
        /// </summary>
        public const int TTI_ERROR_LARGE = 6;
    }
}
