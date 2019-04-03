using System.Runtime.InteropServices;

namespace WinForm.DirectUI.Win32
{
    /// <summary>
    /// POINT定义
    /// </summary>
    public static partial class NativeMethods
    {
        /// <summary>
        /// POINT
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct MINMAXINFO
        {
            /// <summary>
            /// 
            /// </summary>
            public POINT ptReserved;
            /// <summary>
            /// 
            /// </summary>
            public POINT ptMaxSize;
            /// <summary>
            /// 
            /// </summary>
            public POINT ptMaxPosition;
            /// <summary>
            /// 
            /// </summary>
            public POINT ptMinTrackSize;
            /// <summary>
            /// 
            /// </summary>
            public POINT ptMaxTrackSize;
        }
    }
}
