namespace WinForm.DirectUI.Win32
{
    //SelectClipRgn返回值定义
    public static partial class NativeMethods
    {
        /// <summary>
        /// 发生错误（以前的剪切区域不受影响）
        /// </summary>
        public const int ERROR = 0;
        /// <summary>
        /// 区域为空
        /// </summary>
        public const int NULLREGION = 1;
        /// <summary>
        /// 区域为单个矩形
        /// </summary>
        public const int SIMPLEREGION = 2;
        /// <summary>
        /// 区域为多个矩形
        /// </summary>
        public const int COMPLEXREGION = 3;
        /// <summary>
        /// 发生错误（以前的剪切区域不受影响）
        /// </summary>
        public const int RGN_ERROR = ERROR;
    }
}
