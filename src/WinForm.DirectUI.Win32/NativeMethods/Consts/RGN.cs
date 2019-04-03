namespace WinForm.DirectUI.Win32
{
    //RGN定义
    public static partial class NativeMethods
    {
        /// <summary>
        /// 新的剪切区域与当前剪切区域的重叠部分合并，该区域由hrgn标识。
        /// </summary>
        public const int RGN_AND = 1;
        /// <summary>
        /// 新的剪切区域与当前的剪切区域合并，并且该区域由hrgn标识。
        /// </summary>
        public const int RGN_OR = 2;
        /// <summary>
        /// 新的剪切区域与当前的剪切区域合并，并且该区域由hrgn指定，但是不包括任何重叠区域。
        /// </summary>
        public const int RGN_XOR = 3;
        /// <summary>
        /// 新的剪切区域与由hrgn定义的区域之外的区域合并。
        /// </summary>
        public const int RGN_DIFF = 4;
        /// <summary>
        /// 新的剪切区域是由hrgn标识区域的一个拷贝，这和SelectClipRgn是统一的。如果由hrgn所定义的区域为空。那么新的剪切区域就是缺省的剪切区域（缺省的剪切区域是个空区域）。
        /// </summary>
        public const int RGN_COPY = 5;
        /// <summary>
        /// 新的剪切区域与当前剪切区域的重叠部分合并，该区域由hrgn标识。
        /// </summary>
        public const int RGN_MIN = RGN_AND;
        /// <summary>
        /// 新的剪切区域是由hrgn标识区域的一个拷贝，这和SelectClipRgn是统一的。如果由hrgn所定义的区域为空。那么新的剪切区域就是缺省的剪切区域（缺省的剪切区域是个空区域）。
        /// </summary>
        public const int RGN_MAX = RGN_COPY;
    }
}
