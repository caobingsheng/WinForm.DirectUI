﻿using System.Windows.Forms;

namespace WinForm.DirectUI.Forms
{
    /// <summary>
    /// 支持虚拟控件的控件
    /// </summary>
    public partial class UIWinControl : Control, IUIWindow
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public UIWinControl()
        {
            this.SetStyle(
               ControlStyles.UserPaint |
               ControlStyles.AllPaintingInWmPaint |
               ControlStyles.OptimizedDoubleBuffer |
               ControlStyles.ResizeRedraw |
               ControlStyles.SupportsTransparentBackColor, true);
            this.Font = DefaultTheme.Font;
            this.BackColor = DefaultTheme.BackColor;
            this.ForeColor = DefaultTheme.ForeColor;
        }
    }
}
