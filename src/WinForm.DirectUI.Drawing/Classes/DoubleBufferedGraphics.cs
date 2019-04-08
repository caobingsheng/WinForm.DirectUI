using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace WinForm.DirectUI.Drawing
{
    /// <summary>
    /// 双缓冲区
    /// </summary>
    public class DoubleBufferedGraphics : Disposable
    {
        private const int PRE_ALLOC = 10;               //预分配大小
        private bool m_IsCreating;                      //是否正在创建缓冲区
        private IWindow m_Owner;                        //拥有该缓冲区的窗口
        private Graphics m_OwnerGraphics;               //拥有该缓冲区的窗口的绘图画面
        private BufferedGraphics m_BufferedGraphics;    //缓冲区


        #region 构造函数

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="owner">拥有者</param>
        public DoubleBufferedGraphics(IWindow owner)
        {
            m_Owner = owner;
        }

        #endregion


        #region 字段属性

        private CompositingMode m_CompositingMode = CompositingMode.SourceOver;
        /// <summary>
        /// 获取一个值，该值指定如何将合成图像绘制到此 System.Drawing.Graphics。
        /// </summary>
        public CompositingMode CompositingMode
        {
            get
            {
                return m_CompositingMode;
            }
            set
            {
                if (value != m_CompositingMode)
                {
                    m_CompositingMode = value;
                    if (m_BufferedGraphics != null)
                        m_BufferedGraphics.Graphics.CompositingMode = value;
                }
            }
        }

        private CompositingQuality m_CompositingQuality = CompositingQuality.Default;
        /// <summary>
        /// 获取或设置绘制到此 System.Drawing.Graphics 的合成图像的呈现质量。
        /// </summary>
        public CompositingQuality CompositingQuality
        {
            get
            {
                return m_CompositingQuality;
            }
            set
            {
                if (value != m_CompositingQuality)
                {
                    m_CompositingQuality = value;
                    if (m_BufferedGraphics != null)
                        m_BufferedGraphics.Graphics.CompositingQuality = value;
                }
            }
        }

        private InterpolationMode m_InterpolationMode = InterpolationMode.Bilinear;
        /// <summary>
        /// 获取或设置与此 System.Drawing.Graphics 关联的插补模式。
        /// </summary>
        public InterpolationMode InterpolationMode
        {
            get
            {
                return m_InterpolationMode;
            }
            set
            {
                if (value != m_InterpolationMode)
                {
                    m_InterpolationMode = value;
                    if (m_BufferedGraphics != null)
                        m_BufferedGraphics.Graphics.InterpolationMode = value;
                }
            }
        }

        private PixelOffsetMode m_PixelOffsetMode = PixelOffsetMode.Default;
        /// <summary>
        /// 获取或设置一个值，该值指定在呈现此 System.Drawing.Graphics 的过程中像素如何偏移。
        /// </summary>
        public PixelOffsetMode PixelOffsetMode
        {
            get
            {
                return m_PixelOffsetMode;
            }
            set
            {
                if (value != m_PixelOffsetMode)
                {
                    m_PixelOffsetMode = value;
                    if (m_BufferedGraphics != null)
                        m_BufferedGraphics.Graphics.PixelOffsetMode = value;
                }
            }
        }

        private SmoothingMode m_SmoothingMode = SmoothingMode.None;
        /// <summary>
        /// 获取或设置此 System.Drawing.Graphics 的呈现质量。
        /// </summary>
        public SmoothingMode SmoothingMode
        {
            get
            {
                return m_SmoothingMode;
            }
            set
            {
                if (value != m_SmoothingMode)
                {
                    m_SmoothingMode = value;
                    if (m_BufferedGraphics != null)
                        m_BufferedGraphics.Graphics.SmoothingMode = value;
                }
            }
        }

        private int m_TextContrast = 4;
        /// <summary>
        /// 获取或设置呈现文本的灰度校正值。
        /// </summary>
        public int TextContrast
        {
            get
            {
                return m_TextContrast;
            }
            set
            {
                if (value != m_TextContrast)
                {
                    m_TextContrast = value;
                    if (m_BufferedGraphics != null)
                        m_BufferedGraphics.Graphics.TextContrast = value;
                }
            }
        }

        private TextRenderingHint m_TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
        /// <summary>
        /// 获取或设置与此 System.Drawing.Graphics 关联的文本的呈现模式。
        /// </summary>
        public TextRenderingHint TextRenderingHint
        {
            get
            {
                return m_TextRenderingHint;
            }
            set
            {
                if (value != m_TextRenderingHint)
                {
                    m_TextRenderingHint = value;
                    if (m_BufferedGraphics != null)
                        m_BufferedGraphics.Graphics.TextRenderingHint = value;
                }
            }
        }

        /// <summary>
        /// 缓冲区绘图对象
        /// </summary>
        public Graphics Graphics
        {
            get
            {
                return m_BufferedGraphics.Graphics;
            }
        }

        private Size m_Size = Size.Empty;
        /// <summary>
        /// 获取缓冲区的虚拟画布大小。
        /// </summary>
        public Size Size
        {
            get
            {
                return m_Size;
            }
        }

        #endregion


        #region 私有方法

        /// <summary>
        /// 初始化绘图画面
        /// </summary>
        /// <param name="g">绘图画面</param>
        private void InitGraphics(Graphics g)
        {
            g.CompositingMode = m_CompositingMode;
            g.CompositingQuality = m_CompositingQuality;
            g.InterpolationMode = m_InterpolationMode;
            g.PixelOffsetMode = m_PixelOffsetMode;
            g.SmoothingMode = m_SmoothingMode;
            g.TextContrast = m_TextContrast;
            g.TextRenderingHint = m_TextRenderingHint;
        }

        #endregion


        #region 公共方法

        /// <summary>
        /// 开始渲染
        /// </summary>
        /// <returns>成功返回true,否则返回false</returns>
        public bool Prepare()
        {
            //检查资源
            CheckDisposed();

            //检查资源
            m_Owner.CheckDisposed();

            //判断句柄
            if (!m_Owner.IsHandleCreated)
                return false;

            //判断可见
            if (!m_Owner.Visible)
                return false;

            //判断大小
            Size wndSize = m_Owner.Size;
            if (wndSize.Width <= 0 || (wndSize.Height <= 0))
                return false;

            //已创建
            Size bufferSize = m_Size;
            if (m_BufferedGraphics != null
                && bufferSize.Width >= wndSize.Width && bufferSize.Width <= wndSize.Width + PRE_ALLOC
                && bufferSize.Height >= wndSize.Height && bufferSize.Height <= wndSize.Height + PRE_ALLOC)
                return true;

            //预分配
            if (bufferSize.Width < wndSize.Width)
                wndSize.Width += PRE_ALLOC;
            if (bufferSize.Height < wndSize.Height)
                wndSize.Height += PRE_ALLOC;

            //设置状态
            if (m_IsCreating)
                return false;
            m_IsCreating = true;

            //缓冲上下文
            BufferedGraphicsContext bufferedGraphicsContext = BufferedGraphicsManager.Current;
            bufferedGraphicsContext.MaximumBuffer = wndSize;

            //执行创建
            if (m_OwnerGraphics == null)
                m_OwnerGraphics = m_Owner.CreateGraphics();
            if (m_BufferedGraphics != null)
                m_BufferedGraphics.Dispose();
            m_BufferedGraphics = bufferedGraphicsContext.Allocate(m_OwnerGraphics, new Rectangle(0, 0, wndSize.Width, wndSize.Height));

            //初始化绘图对象
            InitGraphics(m_BufferedGraphics.Graphics);
            m_Size = wndSize;

            //不创建
            m_IsCreating = false;
            return true;
        }

        /// <summary>
        /// 在目标设备上混合渲染
        /// </summary>
        /// <param name="g">目标设备渲染数据</param>
        public void BlendRender(Graphics g)
        {
            BufferedGraphicsEx.BlendRender(m_BufferedGraphics, g);
        }

        /// <summary>
        /// 在目标设备上混合渲染
        /// </summary>
        /// <param name="e">目标设备渲染数据</param>
        public void BlendRender(PaintEventArgs e)
        {
            BufferedGraphicsEx.BlendRender(m_BufferedGraphics, e.Graphics, e.ClipRectangle);
        }

        /// <summary>
        /// 在目标设备上复制渲染
        /// </summary>
        /// <param name="g">目标设备渲染数据</param>
        public void Render(Graphics g)
        {
            m_BufferedGraphics.Render(g);
        }

        /// <summary>
        /// 在目标设备上复制渲染
        /// </summary>
        /// <param name="e">目标设备渲染数据</param>
        public void Render(PaintEventArgs e)
        {
            BufferedGraphicsEx.Render(m_BufferedGraphics, e.Graphics, e.ClipRectangle);
        }

        #endregion


        #region 释放资源

        /// <summary>
        /// 释放资源
        /// </summary>
        /// <param name="disposing">释放托管资源为true,否则为false</param>
        protected override void Dispose(bool disposing)
        {
            if (m_BufferedGraphics != null)
            {
                m_BufferedGraphics.Dispose();
                m_BufferedGraphics = null;
            }
            if (m_OwnerGraphics != null)
            {
                m_OwnerGraphics.Dispose();
                m_OwnerGraphics = null;
            }
            m_Owner = null;//取消引用
        }

        #endregion
    }
}
