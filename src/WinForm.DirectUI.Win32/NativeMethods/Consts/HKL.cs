using System;

namespace WinForm.DirectUI.Win32
{
    //HKL定义
    public static partial class NativeMethods
    {
        /// <summary>
        /// Selects the previous locale identifier in the circular list of loaded locale identifiers maintained by the system.
        /// </summary>
        public static readonly IntPtr HKL_PREV = IntPtr.Zero;
        /// <summary>
        /// Selects the next locale identifier in the circular list of loaded locale identifiers maintained by the system.
        /// </summary>
        public static readonly IntPtr HKL_NEXT = new IntPtr(1);
    }
}
