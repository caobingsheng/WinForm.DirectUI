namespace WinForm.DirectUI.Win32
{
    //GRADIENT_FILL定义
    public static partial class NativeMethods
    {
        /// <summary>
        /// 在该模式下，两个端点表示一个矩形。该矩形被定义成左右边界具有固定颜色（由TRIVERTEX结构指定）。GDI从上至下插入颜色，并填充内部区域。
        /// </summary>
        public const uint GRADIENT_FILL_RECT_H = 0x00000000;
        /// <summary>
        /// 在该模式下，两个端点表示一个矩形。该矩形定义其顶部和底部边界的颜色为固定值（通过TRIVERTEX结构指定），GDI从顶至底部边界插入颜色，并填充内部区域。
        /// </summary>
        public const uint GRADIENT_FILL_RECT_V = 0x00000001;
        /// <summary>
        /// 在该模式下，TRIVERTEX结构数组以及描述单个三角形的数组索引序列被传给GDI。GDI在三角形顶点之间进行线性插值，并填充内部区域。在24和32位/像素模式下，绘图是直接进行。在16、8、4和1位/像素模式中进行抖动处理。
        /// </summary>
        public const uint GRADIENT_FILL_TRIANGLE = 0x00000002;
        /// <summary>
        /// 该值无效
        /// </summary>
        public const uint GRADIENT_FILL_OP_FLAG = 0x000000ff;
    }
}
