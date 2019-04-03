using System;

namespace WinForm.DirectUI.Win32
{
    //BOOLEAN定义
    public static partial class NativeMethods
    {
        /// <summary>
        /// 真
        /// </summary>
        public static readonly IntPtr TRUE = new IntPtr(1);
        /// <summary>
        /// 假
        /// </summary>
        public static readonly IntPtr FALSE = IntPtr.Zero;
    }
}
