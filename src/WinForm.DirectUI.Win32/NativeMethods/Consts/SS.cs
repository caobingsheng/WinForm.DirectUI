namespace WinForm.DirectUI.Win32
{
    //SS定义
    public static partial class NativeMethods
    {
        /// <summary>
        /// 使文字在静态控件中左对齐。
        /// </summary>
        public const int SS_LEFT = 0x00000000;
        /// <summary>
        /// 使文字在静态控件中水平居中。
        /// </summary>
        public const int SS_CENTER = 0x00000001;
        /// <summary>
        /// 使文字在静态控件中右对齐。
        /// </summary>
        public const int SS_RIGHT = 0x00000002;
        /// <summary>
        /// 指定在静态控件中显示一个被定义在资源文件中的图标。该风格将忽略静态控件的高度和宽度，静态控件将根据位图的大小自动调节自身的尺寸。
        /// </summary>
        public const int SS_ICON = 0x00000003;
        /// <summary>
        /// 该控制域以填充的矩形显示，颜色与当前的窗口框架相同。
        /// </summary>
        public const int SS_BLACKRECT = 0x00000004;
        /// <summary>
        /// 该控制域以填充的矩形显示，颜色与当前的桌面相同。
        /// </summary>
        public const int SS_GRAYRECT = 0x00000005;
        /// <summary>
        /// 建立一个白色的矩形。
        /// </summary>
        public const int SS_WHITERECT = 0x00000006;
        /// <summary>
        /// 该控制域以矩形边界显示，颜色与当前窗口框架相同。
        /// </summary>
        public const int SS_BLACKFRAME = 0x00000007;
        /// <summary>
        /// 该控制域以矩形边界显示，颜色与当前桌面相同。
        /// </summary>
        public const int SS_GRAYFRAME = 0x00000008;
        /// <summary>
        /// 建立一个白色的边框。
        /// </summary>
        public const int SS_WHITEFRAME = 0x00000009;
        /// <summary>
        /// 建立一个用户自定义项目。
        /// </summary>
        public const int SS_USERITEM = 0x0000000A;
        /// <summary>
        /// 只显示一行文本，文本不能被剪切或替换(父窗口不能处理CTLCOLOR消息)。
        /// </summary>
        public const int SS_SIMPLE = 0x0000000B;
        /// <summary>
        /// 在缺省情况下，静态控件把’\n’和’\t’都作为换行标记。只有在设置本风格后，静态控件才把’\t’看作是制表键(缺省时制表键的宽度为8个字符的宽度)。
        /// </summary>
        public const int SS_LEFTNOWORDWRAP = 0x0000000C;
        /// <summary>
        /// 在指定该风格后，当静态控件在视觉外观发生变化时，该静态控件的属主窗口将响应WM_DRAWITEM消息。
        /// </summary>
        public const int SS_OWNERDRAW = 0x0000000D;
        /// <summary>
        /// 指定在静态控件中显示一个被定义在资源文件中的位图。该风格将忽略静态控件的高度和宽度，静态控件将根据位图的大小自动调节自身的尺寸。
        /// </summary>
        public const int SS_BITMAP = 0x0000000E;
        /// <summary>
        /// 指定在静态控件中显示一个增强型图元文件。该风格将不会忽略静态控件的高度和宽度，而图元文件将调节自身的大小来适应静态控件的尺寸。
        /// </summary>
        public const int SS_ENHMETAFILE = 0x0000000F;
        /// <summary>
        /// 建立一个边框，并将顶端边框设置为浮雕风格。
        /// </summary>
        public const int SS_ETCHEDHORZ = 0x00000010;
        /// <summary>
        /// 建立一个边框，并将左侧边框设置为浮雕风格。
        /// </summary>
        public const int SS_ETCHEDVERT = 0x00000011;
        /// <summary>
        /// 建立一个浮雕边框。
        /// </summary>
        public const int SS_ETCHEDFRAME = 0x00000012;
        /// <summary>
        /// 一种复合式的位，结果从使用OR运算符的SS_ *样式位。可以用来屏蔽掉从一个给定的位掩码有效的SS_ *位。请注意，这是过时和不正确地包含所有有效的样式。因此，你不应该使用这种风格。
        /// </summary>
        public const int SS_TYPEMASK = 0x0000001F;
        /// <summary>
        /// 调整位图以适应静态控件的大小。例如，更改区域设置可以更改系统字体，从而控制可能会被调整。如果一个静态控件有一个位图，位图将不再适应控件。这种风格位决定了位图的自动redimensioning，以满足他们的控制。如果SS_CENTERIMAGE指定，位图或图标居中（如果需要裁剪）。如果SS_CENTERIMAGE没有指定，位图或图标被拉伸或收缩。需要注意的是在两个轴redimensioning是独立的，并且结果可以具有改变的宽高比。与比较SS_REALSIZEIMAGE。
        /// </summary>
        public const int SS_REALSIZECONTROL = 0x00000040;
        /// <summary>
        /// 防止在控件的文本作为加速器前缀字符任何解释的符号（＆）字符。这些都显示带有连字符去掉，字符串中的下一个字符加下划线。这个静态控件样式可能包含与任何定义的静态控件。您可以结合SS_NOPREFIX与其他样式。当文件名 ​​或其他字符串可能包含一个符号（＆）必须显示在一个静态控件在对话框中，这很有用。
        /// </summary>
        public const int SS_NOPREFIX = 0x00000080;
        /// <summary>
        /// 发送父窗口STN_CLICKED，STN_DBLCLK，STN_DISABLE和STN_ENABLE通知码，当用户单击或双击控制。
        /// </summary>
        public const int SS_NOTIFY = 0x00000100;
        /// <summary>
        /// 位图是集中在静态控件中包含它。该控件不能调整大小，这样的位图太大，控制将被裁剪。如果静态控件包含文本的单行线，文本在控件的客户区垂直居中。由于Windows XP中，这种风格有点不再导致被填充的位图或图标的左上角像素的颜色控制的未使用部分。对照的未使用的部分将保持的背景颜色。
        /// </summary>
        public const int SS_CENTERIMAGE = 0x00000200;
        /// <summary>
        /// 静态控制与SS_BITMAP或SS_ICON风格的右下角是留在调整控件大小固定的。只有顶部和左右两侧进行调整，以适应新的位图或图标。
        /// </summary>
        public const int SS_RIGHTJUST = 0x00000400;
        /// <summary>
        /// 指定实际资源的宽度使用和图标使用加载的LoadImage。SS_REALSIZEIMAGE总是配合使用SS_ICON。SS_REALSIZEIMAGE使用的LoadImage，通常覆盖在后面的过程中SS_ICON。它不会加载游标，如果的LoadImage失败，没有进一步尝试加载制成。它使用的实际资源的宽度。静态控制相应调整，但图标仍然对齐到原先指定的左侧和控件的顶部边缘。请注意，如果SS_CENTERIMAGE也指定，图标控件的空间，这是使用指定的范围内集中CreateWindow的参数nWidth和nHeight参数。与比较SS_REALSIZECONTROL。
        /// </summary>
        public const int SS_REALSIZEIMAGE = 0x00000800;
        /// <summary>
        /// 周围绘制一个静态控件一个半下沉式边框。
        /// </summary>
        public const int SS_SUNKEN = 0x00001000;
        /// <summary>
        /// 静态控件复制多行编辑控件的文本显示特性。具体地，平均字符宽度的计算方法相同的方式，与编辑控件，并且该函数不显示部分可见的最后一行。
        /// </summary>
        public const int SS_EDITCONTROL = 0x00002000;
        /// <summary>
        /// 如果一个字符串的结尾不适合在该矩形，将被截断和椭圆形被添加。如果一个字，它不是在字符串的末尾超出了矩形的极限，它被截断未经椭圆。使用这种风格将迫使该控件的文本要在没有自动换行一行。与比较SS_PATHELLIPSIS和SS_WORDELLIPSIS。
        /// </summary>
        public const int SS_ENDELLIPSIS = 0x00004000;
        /// <summary>
        /// 替换字符的字符串与椭圆的中间，这样的结果在指定的矩形适合。如果字符串中包含反斜杠（\）字符，SS_PATHELLIPSIS保留尽可能多的文本的最后一个反斜杠之后。使用这种风格将迫使该控件的文本要在没有自动换行一行。与比较SS_ENDELLIPSIS和SS_WORDELLIPSIS。
        /// </summary>
        public const int SS_PATHELLIPSIS = 0x00008000;
        /// <summary>
        /// 截断不适合在矩形和椭圆增添任何字。使用这种风格将迫使该控件的文本要在没有自动换行一行。与比较SS_ENDELLIPSIS和SS_PATHELLIPSIS。
        /// </summary>
        public const int SS_WORDELLIPSIS = 0x0000C000;
        /// <summary>
        /// 无说明。
        /// </summary>
        public const int SS_ELLIPSISMASK = 0x0000C000;
    }
}
