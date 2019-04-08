using System.Drawing;

namespace WinForm.DirectUI.Drawing
{
    /// <summary>
    /// 平移变换
    /// </summary>
    public sealed class TranslateGraphics : DisposableMini
    {
        private int m_X;                    //水平平移
        private int m_Y;                    //垂直平移
        private Graphics m_Graphics;        //要修改剪切区的绘图对象

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="graphics">绘图对象</param>
        /// <param name="x">水平偏移像素</param>
        /// <param name="y">垂直偏移像素</param>
        public TranslateGraphics(Graphics graphics, int x, int y)
        {
            m_Graphics = graphics;
            m_X = x;
            m_Y = y;
            m_Graphics.TranslateTransform(m_X, m_Y);
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="graphics">绘图对象</param>
        /// <param name="p">偏移量</param>
        public TranslateGraphics(Graphics graphics, Point p)
        {
            m_Graphics = graphics;
            m_X = p.X;
            m_Y = p.Y;
            m_Graphics.TranslateTransform(m_X, m_Y);
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="graphics">绘图对象</param>
        /// <param name="s">偏移量</param>
        public TranslateGraphics(Graphics graphics, Size s)
        {
            m_Graphics = graphics;
            m_X = s.Width;
            m_Y = s.Height;
            m_Graphics.TranslateTransform(m_X, m_Y);
        }

        /// <summary>
        /// 释放资源
        /// </summary>
        /// <param name="disposing">释放托管资源为true,否则为false</param>
        protected override void Dispose(bool disposing)
        {
            if (m_Graphics != null)
            {
                m_Graphics.TranslateTransform(-m_X, -m_Y);
                m_Graphics = null;
            }
            m_X = 0;
            m_Y = 0;
        }
    }
}
