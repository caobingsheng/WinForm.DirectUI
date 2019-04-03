namespace WinForm.DirectUI.Win32
{
    //SOMAXCONN定义
    public static partial class NativeMethods
    {
        /// <summary>
        /// Maximum queue length specifiable by listen.
        /// </summary>
        public const int SOMAXCONN = 0x7FFFFFFF;
    }
}
