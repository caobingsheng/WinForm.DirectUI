namespace WinForm.DirectUI.Win32
{
    //BKMODE定义
    public static partial class NativeMethods
    {
        /// <summary>
        /// Background remains untouched.
        /// </summary>
        public const int TRANSPARENT = 1;
        /// <summary>
        /// Background is filled with the current background color before the text, hatched brush, or pen is drawn.
        /// </summary>
        public const int OPAQUE = 2;
        /// <summary>
        /// 无效,值与OPAQUE相同
        /// </summary>
        public const int BKMODE_LAST = 2;
    }
}
