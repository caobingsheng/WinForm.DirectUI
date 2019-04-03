﻿using System.Runtime.InteropServices;

namespace WinForm.DirectUI.Win32
{
    /// <summary>
    /// WAVEFORMATEX定义
    /// </summary>
    public static partial class NativeMethods
    {
        /// <summary>
        /// WAVEFORMATEX
        /// </summary>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct WAVEFORMATEX
        {
            /// <summary>
            /// 
            /// </summary>
            public short wFormatTag;
            /// <summary>
            /// 
            /// </summary>
            public short nChannels;
            /// <summary>
            /// 
            /// </summary>
            public int nSamplesPerSec;
            /// <summary>
            /// 
            /// </summary>
            public int nAvgBytesPerSec;
            /// <summary>
            /// 
            /// </summary>
            public short nBlockAlign;
            /// <summary>
            /// 
            /// </summary>
            public short wBitsPerSample;
            /// <summary>
            /// 
            /// </summary>
            public short cbSize;
        }
    }
}
