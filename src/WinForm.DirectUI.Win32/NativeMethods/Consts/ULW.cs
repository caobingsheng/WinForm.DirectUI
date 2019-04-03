namespace WinForm.DirectUI.Win32
{
    //ULW定义
    public static partial class NativeMethods
    {
        /// <summary>
        /// Use crKey as the transparency color.
        /// </summary>
        public const uint ULW_COLORKEY = 0x00000001;
        /// <summary>
        /// Use pblend as the blend function. If the display mode is 256 colors or less, the effect of this value is the same as the effect of ULW_OPAQUE.
        /// </summary>
        public const uint ULW_ALPHA = 0x00000002;
        /// <summary>
        /// Draw an opaque layered window. 
        /// </summary>
        public const uint ULW_OPAQUE = 0x00000004;
        /// <summary>
        /// If hdcSrc is NULL, dwFlags should be zero.
        /// </summary>
        public const uint ULW_EX_NORESIZE = 0x00000008;
    }
}
