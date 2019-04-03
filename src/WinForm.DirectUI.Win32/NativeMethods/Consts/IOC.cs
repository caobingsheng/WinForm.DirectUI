namespace WinForm.DirectUI.Win32
{
    //IOC定义
    public static partial class NativeMethods
    {
        /// <summary>
        /// parameters must be &lt; 128 bytes
        /// </summary>
        public const int IOCPARM_MASK = 0x7F;
        /// <summary>
        /// no parameters
        /// </summary>
        public const int IOC_VOID = 0x20000000;
        /// <summary>
        /// copy out parameters
        /// </summary>
        public const int IOC_OUT = 0x40000000;
        /// <summary>
        /// copy in parameters
        /// </summary>
        public const int IOC_IN = unchecked((int)0x80000000);
        /// <summary>
        /// IOC_IN | IOC_OUT
        /// </summary>
        public const int IOC_INOUT = (IOC_IN | IOC_OUT);

        /// <summary>
        /// IOC_UNIX
        /// </summary>
        public const int IOC_UNIX = 0x00000000;
        /// <summary>
        /// IOC_WS2
        /// </summary>
        public const int IOC_WS2 = 0x08000000;
        /// <summary>
        /// IOC_PROTOCOL
        /// </summary>
        public const int IOC_PROTOCOL = 0x10000000;
        /// <summary>
        /// IOC_VENDOR
        /// </summary>
        public const int IOC_VENDOR = 0x18000000;

        /// <summary>
        /// IOC_WSK
        /// </summary>
        public const int IOC_WSK = (IOC_WS2 | 0x07000000);
    }
}
