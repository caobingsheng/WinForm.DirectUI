﻿using System;

namespace WinForm.DirectUI.Forms
{
    partial class UIControl
    {
        private string m_Name;
        /// <summary>
        /// 获取或设置控件名称
        /// </summary>
        public string Name
        {
            get
            {
                return this.m_Name;
            }
            set
            {
                this.m_Name = value;
            }
        }

        private bool m_Visible = true;
        /// <summary>
        /// 获取或设置控件是否可见
        /// </summary>
        public bool Visible
        {
            get
            {
                return this.m_Visible;
            }
            set
            {
                if (value != this.m_Visible)
                {
                    this.m_Visible = value;
                    this.SetBounds();
                    this.Invalidate();
                }
            }
        }

        private bool m_Enabled = true;
        /// <summary>
        /// 获取或设置控件是否启用
        /// </summary>
        public bool Enabled
        {
            get
            {
                return this.m_Enabled;
            }
            set
            {
                if (value != this.m_Enabled)
                {
                    this.m_Enabled = value;
                    this.Invalidate();
                }
            }
        }

        private bool m_Capture;
        /// <summary>
        /// 获取或设置控件是否捕获鼠标
        /// </summary> 
        public bool Capture
        {
            get
            {
                return this.m_Capture;
            }
            set
            {
                if (value != this.Capture)
                {
                    this.m_Capture = value;
                    this.State = this.GetState();
                    if (value)
                        this.OnEnter(EventArgs.Empty);
                    else
                        this.OnLeave(EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// 显示控件
        /// </summary>
        public void Show()
        {
            this.Visible = true;
        }

        /// <summary>
        /// 隐藏控件
        /// </summary>
        public void Hide()
        {
            this.Visible = false;
        }
    }
}
