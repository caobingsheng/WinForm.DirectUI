using System.Drawing;
using System.Drawing.Drawing2D;

namespace WinForm.DirectUI.Drawing
{
    /// <summary>
    /// 暂时修改绘图剪切区,释放时改为原来剪切区
    /// </summary>
    public sealed class ClipGraphics : DisposableMini
    {
        private Region m_OldClip;           //原始的剪切区
        private Graphics m_Graphics;        //要修改剪切区的绘图对象

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="graphics">绘图对象</param>
        /// <param name="g">提供剪切区的绘图对象</param>
        /// <param name="combineMode">组合模式</param>
        public ClipGraphics(Graphics graphics, Graphics g, CombineMode combineMode)
        {
            m_Graphics = graphics;
            m_OldClip = graphics.Clip;
            graphics.SetClip(g, combineMode);
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="graphics">绘图对象</param>
        /// <param name="path">提供剪切区的路径</param>
        /// <param name="combineMode">组合模式</param>
        public ClipGraphics(Graphics graphics, GraphicsPath path, CombineMode combineMode)
        {
            m_Graphics = graphics;
            m_OldClip = graphics.Clip;
            graphics.SetClip(path, combineMode);
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="graphics">绘图对象</param>
        /// <param name="rect">提供剪切区的矩形</param>
        /// <param name="combineMode">组合模式</param>
        public ClipGraphics(Graphics graphics, Rectangle rect, CombineMode combineMode)
        {
            m_Graphics = graphics;
            m_OldClip = graphics.Clip;
            graphics.SetClip(rect, combineMode);
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="graphics">绘图对象</param>
        /// <param name="rect">提供剪切区的矩形</param>
        /// <param name="combineMode">组合模式</param>
        public ClipGraphics(Graphics graphics, RectangleF rect, CombineMode combineMode)
        {
            m_Graphics = graphics;
            m_OldClip = graphics.Clip;
            graphics.SetClip(rect, combineMode);
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="graphics">绘图对象</param>
        /// <param name="region">提供剪切区的图形</param>
        /// <param name="combineMode">组合模式</param>
        public ClipGraphics(Graphics graphics, Region region, CombineMode combineMode)
        {
            m_Graphics = graphics;
            m_OldClip = graphics.Clip;
            graphics.SetClip(region, combineMode);
        }

        /// <summary>
        /// 释放资源
        /// </summary>
        /// <param name="disposing">释放托管资源为true,否则为false</param>
        protected override void Dispose(bool disposing)
        {
            if (m_Graphics != null)
            {
                m_Graphics.SetClip(m_OldClip, CombineMode.Replace);
                m_Graphics = null;
            }
            if (m_OldClip != null)
            {
                m_OldClip.Dispose();
                m_OldClip = null;
            }
        }
    }
}
