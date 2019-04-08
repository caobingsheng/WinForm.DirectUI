using System;
using System.ComponentModel;

namespace WinForm.DirectUI
{
    /// <summary>
    /// Dispose 模式
    /// </summary>
    public abstract class Disposable : IDisposable, IDisposed, IDisposeState
    {
        #region 静态字段

        /// <summary>
        /// 释放资源事件索引标记
        /// </summary>
        protected static readonly object EVENT_DISPOSED = new object();

        #endregion


        #region 字段属性

        private bool m_Disposing;
        /// <summary>
        /// 是否正在释放资源
        /// </summary>
        [Browsable(false)]
        public bool Disposing
        {
            get
            {
                return m_Disposing;
            }
        }

        private bool m_IsDisposed;
        /// <summary>
        /// 是否已经释放资源
        /// </summary>
        [Browsable(false)]
        public bool IsDisposed
        {
            get
            {
                return m_IsDisposed;
            }
        }

        private EventHandlerList m_Events;
        /// <summary>
        /// 事件列表
        /// </summary>
        [Browsable(false)]
        protected EventHandlerList Events
        {
            get
            {
                if (m_Events == null)
                    m_Events = new EventHandlerList();
                return m_Events;
            }
        }

        #endregion


        #region 事件入口

        /// <summary>
        /// 释放资源事件
        /// </summary>
        public event EventHandler Disposed
        {
            add { Events.AddHandler(EVENT_DISPOSED, value); }
            remove { Events.RemoveHandler(EVENT_DISPOSED, value); }
        }

        #endregion


        #region 构造函数

        /// <summary>
        /// 构造函数
        /// </summary>
        public Disposable()
        {
        }

        /// <summary>
        /// 析构函数
        /// </summary>
        ~Disposable()
        {
            DisposeCore(false);
        }

        #endregion


        #region 私有方法

        /// <summary>
        /// 释放资源
        /// </summary>
        /// <param name="disposing">释放托管资源为true,否则为false</param>
        private void DisposeCore(bool disposing)
        {
            //调用限制
            if (m_Disposing)
                return;
            m_Disposing = true;

            //供子类重写
            Dispose(disposing);

            //释放事件列表
            if (m_Events != null)
            {
                EventHandler handler = (EventHandler)m_Events[EVENT_DISPOSED];
                if (handler != null)
                    handler(this, EventArgs.Empty);
                m_Events.Dispose();
                m_Events = null;
            }

            //调用结束
            m_Disposing = false;
            m_IsDisposed = true;
        }

        #endregion


        #region 保护方法

        /// <summary>
        /// 释放资源
        /// </summary>
        /// <param name="disposing">释放托管资源为true,否则为false</param>
        protected abstract void Dispose(bool disposing);

        #endregion


        #region 公共方法

        /// <summary>
        /// 检查是否已释放资源,如果已释放资源则抛出异常
        /// </summary>
        public void CheckDisposed()
        {
            if (IsDisposed)
                throw new ObjectDisposedException(base.GetType().FullName);
        }

        /// <summary>
        /// 释放资源
        /// </summary>
        public void Dispose()
        {
            DisposeCore(true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}
