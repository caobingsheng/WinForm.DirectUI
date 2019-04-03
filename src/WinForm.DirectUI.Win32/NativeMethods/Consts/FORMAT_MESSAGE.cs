namespace WinForm.DirectUI.Win32
{
    //FORMAT_MESSAGE定义
    public static partial class NativeMethods
    {
        /// <summary>
        /// 函数会分配一个足够大的缓冲区保存格式化消息，并且通过lpBuffer指向该地址。
        /// </summary>
        public const int FORMAT_MESSAGE_ALLOCATE_BUFFER = 0x00000100;
        /// <summary>
        /// 消息定义中的插入序列会被一直忽略和跳过直到输出缓冲区不改变，并且Arguments会被忽略。
        /// </summary>
        public const int FORMAT_MESSAGE_IGNORE_INSERTS = 0x00000200;
        /// <summary>
        /// lpSource参数是一个指向以NULL结尾的字符串，字符串包含一个消息定义，这个消息定义可以包含插入序列。此标志最好不要和FORMAT_MESSAGE_FROM_HMODULE或者FORMAT_MESSAGE_FROM_SYSTEM使用
        /// </summary>
        public const int FORMAT_MESSAGE_FROM_STRING = 0x00000400;
        /// <summary>
        /// lpSource参数是需要去搜索的一个包含消息表的模块线程。如果lpSource是NULL，当前进程的应用图像会被搜索，这个标志不能同FORMAT_MESSAGE_FROM_STRING使用。
        /// </summary>
        public const int FORMAT_MESSAGE_FROM_HMODULE = 0x00000800;
        /// <summary>
        /// 函数会为了请求的信息而搜索系统的消息表资源。如果标志同时也指定了FORMAT_MESSAGE_FROM_HMODULE，那么函数会先在lpSource指定的模块中搜索请求的消息，如果搜索不到，就去搜索系统消息表资源。此标志不能与FORMAT_MESSAGE_FROM_STRING使用。
        /// </summary>
        public const int FORMAT_MESSAGE_FROM_SYSTEM = 0x00001000;
        /// <summary>
        /// Arguments参数不是指向va_list结构体，但是是一个指向保存参数的数据。
        /// </summary>
        public const int FORMAT_MESSAGE_ARGUMENT_ARRAY = 0x00002000;
        /// <summary>
        /// 掩码
        /// </summary>
        public const int FORMAT_MESSAGE_MAX_WIDTH_MASK = 0x000000FF;
    }
}
