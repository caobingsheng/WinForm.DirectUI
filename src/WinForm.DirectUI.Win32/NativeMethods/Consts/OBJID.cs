namespace WinForm.DirectUI.Win32
{
    //OBJID定义
    public static partial class NativeMethods
    {
        /// <summary>
        /// 窗口
        /// </summary>
        public const int OBJID_WINDOW = 0x00000000;
        /// <summary>
        /// 系统菜单
        /// </summary>
        public const int OBJID_SYSMENU = unchecked((int)0xFFFFFFFF);
        /// <summary>
        /// 标题栏
        /// </summary>
        public const int OBJID_TITLEBAR = unchecked((int)0xFFFFFFFE);
        /// <summary>
        /// 菜单
        /// </summary>
        public const int OBJID_MENU = unchecked((int)0xFFFFFFFD);
        /// <summary>
        /// 客户区
        /// </summary>
        public const int OBJID_CLIENT = unchecked((int)0xFFFFFFFC);
        /// <summary>
        /// 垂直滚动条
        /// </summary>
        public const int OBJID_VSCROLL = unchecked((int)0xFFFFFFFB);
        /// <summary>
        /// 水平滚动条
        /// </summary>
        public const int OBJID_HSCROLL = unchecked((int)0xFFFFFFFA);
        /// <summary>
        /// 调整大小手柄
        /// </summary>
        public const int OBJID_SIZEGRIP = unchecked((int)0xFFFFFFF9);
        /// <summary>
        /// 
        /// </summary>
        public const int OBJID_CARET = unchecked((int)0xFFFFFFF8);
        /// <summary>
        /// 光标
        /// </summary>
        public const int OBJID_CURSOR = unchecked((int)0xFFFFFFF7);
        /// <summary>
        /// 警告
        /// </summary>
        public const int OBJID_ALERT = unchecked((int)0xFFFFFFF6);
        /// <summary>
        /// 声音
        /// </summary>
        public const int OBJID_SOUND = unchecked((int)0xFFFFFFF5);
        /// <summary>
        /// 查询类名
        /// </summary>
        public const int OBJID_QUERYCLASSNAMEIDX = unchecked((int)0xFFFFFFF4);
        /// <summary>
        /// 
        /// </summary>
        public const int OBJID_NATIVEOM = unchecked((int)0xFFFFFFF0);
    }
}
