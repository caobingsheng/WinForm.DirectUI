﻿using System.Runtime.InteropServices;

namespace WinForm.DirectUI.Win32
{
    /// <summary>
    /// MMCKINFO定义
    /// </summary>
    public static partial class NativeMethods
    {
        /// <summary>
        /// MMCKINFO
        /// </summary>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct MMCKINFO
        {
            /// <summary>
            /// 
            /// </summary>
            public int ckID;
            /// <summary>
            /// 
            /// </summary>
            public int cksize;
            /// <summary>
            /// 
            /// </summary>
            public int fccType;
            /// <summary>
            /// 
            /// </summary>
            public int dwDataOffset;
            /// <summary>
            /// 
            /// </summary>
            public int dwFlags;
        }
    }
}
