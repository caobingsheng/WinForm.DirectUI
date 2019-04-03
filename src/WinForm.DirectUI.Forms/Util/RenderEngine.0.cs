using System;
using System.Drawing.Imaging;

namespace WinForm.DirectUI.Forms
{
    /// <summary>
    /// 渲染引擎
    /// </summary>
    public static partial class RenderEngine
    {
        /// <summary>
        /// 灰色图像参数
        /// </summary>
        [ThreadStatic]
        private static ImageAttributes m_DisabledImageAttr;
    }
}
