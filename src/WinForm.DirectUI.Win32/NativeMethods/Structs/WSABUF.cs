﻿using System;
using System.Runtime.InteropServices;

namespace WinForm.DirectUI.Win32
{
    /// <summary>
    /// WSABUF定义
    /// </summary>
    public static partial class NativeMethods
    {
        /// <summary>
        /// The WSABUF structure enables the creation or manipulation of a data buffer used by some Winsock functions.
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct WSABUF
        {
            /// <summary>
            /// The length of the buffer, in bytes.
            /// </summary>
            public int len;
            /// <summary>
            /// A pointer to the buffer.
            /// </summary>
            public IntPtr buf;
        }
    }
}
