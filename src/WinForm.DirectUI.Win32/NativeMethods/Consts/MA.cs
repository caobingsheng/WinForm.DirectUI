using System;

namespace WinForm.DirectUI.Win32
{
    //MA定义
    public static partial class NativeMethods
    {
        /// <summary>
        /// 
        /// </summary>
        public static readonly IntPtr MA_ACTIVATE = new IntPtr(1);
        /// <summary>
        /// 
        /// </summary>
        public static readonly IntPtr MA_ACTIVATEANDEAT = new IntPtr(2);
        /// <summary>
        /// 
        /// </summary>
        public static readonly IntPtr MA_NOACTIVATE = new IntPtr(3);
        /// <summary>
        /// 
        /// </summary>
        public static readonly IntPtr MA_NOACTIVATEANDEAT = new IntPtr(4);
    }
}
