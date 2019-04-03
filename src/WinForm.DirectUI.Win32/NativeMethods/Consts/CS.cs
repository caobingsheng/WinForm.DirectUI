namespace WinForm.DirectUI.Win32
{
    //CS定义
    public static partial class NativeMethods
    {
        /// <summary>
        /// 如果移动或大小调整改变客户区的高度，将重新绘制整个窗口。
        /// </summary>
        public const int CS_VREDRAW = 0x0001;
        /// <summary>
        /// 如果移动或大小调整更改客户端区域的宽度将重新绘制整个窗口。
        /// </summary>
        public const int CS_HREDRAW = 0x0002;
        /// <summary>
        /// 双击消息发送到窗口过程，当用户双击鼠标，当光标位于窗口属于类内。
        /// </summary>
        public const int CS_DBLCLKS = 0x0008;
        /// <summary>
        /// 为每个窗口类中分配一个唯一的设备上下文。
        /// </summary>
        public const int CS_OWNDC = 0x0020;
        /// <summary>
        /// 分配一个设备上下文的所有 windows 共享的类中。因为窗口类是特定的进程，有可能为多个线程的应用程序创建一个窗口在同一类。它也是可能的线程尝试同时使用的设备上下文。当发生这种情况时，系统只允许一个线程以成功地完成它的绘制操作。
        /// </summary>
        public const int CS_CLASSDC = 0x0040;
        /// <summary>
        /// 设置剪辑矩形的子窗口的父窗口以便儿童可以绘制在父。一个带有 CS_PARENTDC 样式位窗口接收常规设备上下文的从设备上下文中的系统的缓存。它不给孩子父母的设备上下文或设备上下文设置。指定 CS_PARENTDC 增强了应用程序的性能。
        /// </summary>
        public const int CS_PARENTDC = 0x0080;
        /// <summary>
        /// 在窗口菜单中禁用关闭。
        /// </summary>
        public const int CS_NOCLOSE = 0x0200;
        /// <summary>
        /// 作为一个位图保存此类的窗口被遮盖的屏幕图像的部分。窗口中删除时，系统将使用已保存的位图要还原的屏幕图像，包括其他被遮盖的窗口。因此，系统并不发送 WM_PAINT 消息到被遮盖如果位图所使用的内存不被丢弃，如果其他屏幕操作有不失效的存储的图像的 windows。这种样式很有用的小窗口 （例如，菜单或对话框），简要地显示，然后删除其他屏幕活动发生之前。这种风格会增加因为系统必须首先分配的内存来存储该位图显示窗口所需的时间。
        /// </summary>
        public const int CS_SAVEBITS = 0x0800;
        /// <summary>
        /// 将窗口的客户端区域 （在 x 方向） 的字节边界上对齐。这种风格影响窗口，显示其水平放置的宽度。
        /// </summary>
        public const int CS_BYTEALIGNCLIENT = 0x1000;
        /// <summary>
        /// 将窗口 （在 x 方向） 的字节边界上对齐。这种风格影响窗口，显示其水平放置的宽度。
        /// </summary>
        public const int CS_BYTEALIGNWINDOW = 0x2000;
        /// <summary>
        /// 指示窗口类是一个应用程序的全局类。更多的信息，请参阅关于窗口类的"应用程序全局类"一节。
        /// </summary>
        public const int CS_GLOBALCLASS = 0x4000;
        /// <summary>
        /// 指示窗口类是输入法的UI类
        /// </summary>
        public const int CS_IME = 0x00010000;
        /// <summary>
        /// 使窗口上的投影效果。通过 SPI_SETDROPSHADOW，效果被打开和关闭。通常情况下，这是为启用小，寿命较短的窗口，例如菜单强调他们与其他窗口的 Z-顺序关系。从使用此样式类创建的窗口必须是顶级窗口 ；他们可能不是子窗口。
        /// </summary>
        public const int CS_DROPSHADOW = 0x00020000;
    }
}
