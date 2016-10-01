﻿using System.Drawing;
using System.Windows.Forms;

namespace Microsoft.Windows.Forms
{
    partial interface IUIControl
    {
        /// <summary>
        /// 渲染控件和子控件
        /// </summary>
        /// <param name="e">数据</param>
        void RenderCore(PaintEventArgs e);

        /// <summary>
        /// 挂起刷新 UI
        /// </summary>
        void BeginUpdate();

        /// <summary>
        /// 恢复刷新 UI
        /// </summary>
        void EndUpdate();

        /// <summary>
        /// 恢复刷新 UI,可以选择强制刷新
        /// </summary>
        /// <param name="forceUpdate">若要执行刷新为 true,否则为 false</param>
        void EndUpdate(bool forceUpdate);

        /// <summary>
        /// 使控件工作区无效
        /// </summary>
        void Invalidate();

        /// <summary>
        /// 使控件矩形无效
        /// </summary>
        /// <param name="rc">无效矩形</param>
        void Invalidate(Rectangle rc);

        /// <summary>
        /// 重绘所在 Win32 窗口的无效区域
        /// </summary>
        void Update();

        /// <summary>
        /// 立即刷新所在 Win32 窗口
        /// </summary>
        void Refresh();
    }
}
