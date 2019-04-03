namespace WinForm.DirectUI.Win32
{
    //VK定义
    public static partial class NativeMethods
    {
        /// <summary>
        /// 鼠标左按钮。
        /// </summary>
        public const short VK_LBUTTON = 0x01;
        /// <summary>
        /// 鼠标右按钮。
        /// </summary>
        public const short VK_RBUTTON = 0x02;
        /// <summary>
        /// Cancel 键。
        /// </summary>
        public const short VK_CANCEL = 0x03;
        /// <summary>
        /// 鼠标中按钮（三个按钮的鼠标）。
        /// </summary>
        public const short VK_MBUTTON = 0x04;
        /// <summary>
        /// 第一个 X 鼠标按钮（五个按钮的鼠标）。
        /// </summary>
        public const short VK_XBUTTON1 = 0x05;
        /// <summary>
        /// 第二个 X 鼠标按钮（五个按钮的鼠标）。
        /// </summary>
        public const short VK_XBUTTON2 = 0x06;
        /// <summary>
        /// Backspace 键。
        /// </summary>
        public const short VK_BACK = 0x08;
        /// <summary>
        /// Tab 键。
        /// </summary>
        public const short VK_TAB = 0x09;
        /// <summary>
        /// LINEFEED 键。
        /// </summary>
        public const short VK_LINEFEED = 0x0A;
        /// <summary>
        /// Clear 键。
        /// </summary>
        public const short VK_CLEAR = 0x0C;
        /// <summary>
        /// Enter 键。
        /// </summary>
        public const short VK_ENTER = 0x0D;
        /// <summary>
        /// Return 键。
        /// </summary>
        public const short VK_RETURN = 0x0D;
        /// <summary>
        /// Shift 键。
        /// </summary>
        public const short VK_SHIFT = 0x10;
        /// <summary>
        /// Ctrl 键。
        /// </summary>
        public const short VK_CONTROL = 0x11;
        /// <summary>
        /// Alt 键。
        /// </summary>
        public const short VK_MENU = 0x12;
        /// <summary>
        /// Pause 键。
        /// </summary>
        public const short VK_PAUSE = 0x13;
        /// <summary>
        /// Caps Lock 键。
        /// </summary>
        public const short VK_CAPSLOCK = 0x14;
        /// <summary>
        /// Caps Lock 键。
        /// </summary>
        public const short VK_CAPITAL = 0x14;
        /// <summary>
        /// IME Kana 模式键。
        /// </summary>
        public const short VK_KANA = 0x15;
        /// <summary>
        /// IME Hanguel 模式键。（为了保持兼容性而设置；使用 HangulMode）
        /// </summary>
        public const short VK_HANGUEL = 0x15;
        /// <summary>
        /// IME Hangul 模式键。
        /// </summary>
        public const short VK_HANGUL = 0x15;
        /// <summary>
        /// IME Junja 模式键。
        /// </summary>
        public const short VK_JUNJA = 0x17;
        /// <summary>
        /// IME 最终模式键。
        /// </summary>
        public const short VK_FINAL = 0x18;
        /// <summary>
        /// IME Kanji 模式键。
        /// </summary>
        public const short VK_KANJI = 0x19;
        /// <summary>
        /// IME Hanja 模式键。
        /// </summary>
        public const short VK_HANJA = 0x19;
        /// <summary>
        /// Esc 键。
        /// </summary>
        public const short VK_ESCAPE = 0x1B;
        /// <summary>
        /// IME 转换键。
        /// </summary>
        public const short VK_CONVERT = 0x1C;
        /// <summary>
        /// IME 非转换键。
        /// </summary>
        public const short VK_NONCONVERT = 0x1D;
        /// <summary>
        /// IME 接受键，替换 System.Windows.Forms.Keys.IMEAceept。
        /// </summary>
        public const short VK_ACCEPT = 0x1E;
        /// <summary>
        /// IME 模式更改键。
        /// </summary>
        public const short VK_MODECHANGE = 0x1F;
        /// <summary>
        /// 空格键。
        /// </summary>
        public const short VK_SPACE = 0x20;
        /// <summary>
        /// Page Up 键。
        /// </summary>
        public const short VK_PRIOR = 0x21;
        /// <summary>
        /// Page Up 键。
        /// </summary>
        public const short VK_PAFEUP = 0x21;
        /// <summary>
        /// Page Down 键。
        /// </summary>
        public const short VK_NEXT = 0x22;
        /// <summary>
        /// Page Down 键。
        /// </summary>
        public const short VK_PAGEDOWN = 0x22;
        /// <summary>
        /// End 键。
        /// </summary>
        public const short VK_END = 0x23;
        /// <summary>
        /// Home 键。
        /// </summary>
        public const short VK_HOME = 0x24;
        /// <summary>
        /// 向左键。
        /// </summary>
        public const short VK_LEFT = 0x25;
        /// <summary>
        /// 向上键。
        /// </summary>
        public const short VK_UP = 0x26;
        /// <summary>
        /// 向右键。
        /// </summary>
        public const short VK_RIGHT = 0x27;
        /// <summary>
        /// 向下键。
        /// </summary>
        public const short VK_DOWN = 0x28;
        /// <summary>
        /// Select 键。
        /// </summary>
        public const short VK_SELECT = 0x29;
        /// <summary>
        /// Print 键。
        /// </summary>
        public const short VK_PRINT = 0x2A;
        /// <summary>
        /// EXECUTE 键。
        /// </summary>
        public const short VK_EXECUTE = 0x2B;
        /// <summary>
        /// Print Screen 键。
        /// </summary>
        public const short VK_PRINTSCREEN = 0x2C;
        /// <summary>
        /// Print Screen 键。
        /// </summary>
        public const short VK_SNAPSHOT = 0x2C;
        /// <summary>
        /// Ins 键。
        /// </summary>
        public const short VK_INSERT = 0x2D;
        /// <summary>
        /// DeL 键。
        /// </summary>
        public const short VK_DELETE = 0x2E;
        /// <summary>
        /// Help 键。
        /// </summary>
        public const short VK_HELP = 0x2F;
        /// <summary>
        /// 0 键。
        /// </summary>
        public const short VK_0 = 0x30;
        /// <summary>
        /// 1 键。
        /// </summary>
        public const short VK_1 = 0x31;
        /// <summary>
        /// 2 键。
        /// </summary>
        public const short VK_2 = 0x32;
        /// <summary>
        /// 3 键。
        /// </summary>
        public const short VK_3 = 0x33;
        /// <summary>
        /// 4 键。
        /// </summary>
        public const short VK_4 = 0x34;
        /// <summary>
        /// 5 键。
        /// </summary>
        public const short VK_5 = 0x35;
        /// <summary>
        /// 6 键。
        /// </summary>
        public const short VK_6 = 0x36;
        /// <summary>
        /// 7 键。
        /// </summary>
        public const short VK_7 = 0x37;
        /// <summary>
        /// 8 键。
        /// </summary>
        public const short VK_8 = 0x38;
        /// <summary>
        /// 9 键。
        /// </summary>
        public const short VK_9 = 0x39;
        /// <summary>
        /// A 键。
        /// </summary>
        public const short VK_A = 0x41;
        /// <summary>
        /// B 键。
        /// </summary>
        public const short VK_B = 0x42;
        /// <summary>
        /// C 键。
        /// </summary>
        public const short VK_C = 0x43;
        /// <summary>
        /// D 键。
        /// </summary>
        public const short VK_D = 0x44;
        /// <summary>
        /// E 键。
        /// </summary>
        public const short VK_E = 0x45;
        /// <summary>
        /// F 键。
        /// </summary>
        public const short VK_F = 0x46;
        /// <summary>
        /// G 键。
        /// </summary>
        public const short VK_G = 0x47;
        /// <summary>
        /// H 键。
        /// </summary>
        public const short VK_H = 0x48;
        /// <summary>
        /// I 键。
        /// </summary>
        public const short VK_I = 0x49;
        /// <summary>
        /// J 键。
        /// </summary>
        public const short VK_J = 0x4A;
        /// <summary>
        /// K 键。
        /// </summary>
        public const short VK_K = 0x4B;
        /// <summary>
        /// L 键。
        /// </summary>
        public const short VK_L = 0x4C;
        /// <summary>
        /// M 键。
        /// </summary>
        public const short VK_M = 0x4D;
        /// <summary>
        /// N 键。
        /// </summary>
        public const short VK_N = 0x4E;
        /// <summary>
        /// O 键。
        /// </summary>
        public const short VK_O = 0x4F;
        /// <summary>
        /// P 键。
        /// </summary>
        public const short VK_P = 0x50;
        /// <summary>
        /// Q 键。
        /// </summary>
        public const short VK_Q = 0x51;
        /// <summary>
        /// R 键。
        /// </summary>
        public const short VK_R = 0x52;
        /// <summary>
        /// S 键。
        /// </summary>
        public const short VK_S = 0x53;
        /// <summary>
        /// T 键。
        /// </summary>
        public const short VK_T = 0x54;
        /// <summary>
        /// U 键。
        /// </summary>
        public const short VK_U = 0x55;
        /// <summary>
        /// V 键。
        /// </summary>
        public const short VK_V = 0x56;
        /// <summary>
        /// W 键。
        /// </summary>
        public const short VK_W = 0x57;
        /// <summary>
        /// X 键。
        /// </summary>
        public const short VK_X = 0x58;
        /// <summary>
        /// Y 键。
        /// </summary>
        public const short VK_Y = 0x59;
        /// <summary>
        /// Z 键。
        /// </summary>
        public const short VK_Z = 0x5A;
        /// <summary>
        /// 左 Windows 徽标键（Microsoft Natural Keyboard，人体工程学键盘）。
        /// </summary>
        public const short VK_LWIN = 0x5B;
        /// <summary>
        /// 右 Windows 徽标键（Microsoft Natural Keyboard，人体工程学键盘）。
        /// </summary>
        public const short VK_RWIN = 0x5C;
        /// <summary>
        /// 应用程序键（Microsoft Natural Keyboard，人体工程学键盘）。
        /// </summary>
        public const short VK_APPS = 0x5D;
        /// <summary>
        /// 计算机睡眠键。
        /// </summary>
        public const short VK_SLEEP = 0x5F;
        /// <summary>
        /// 数字键盘上的 0 键。
        /// </summary>
        public const short VK_NUMPAD0 = 0x60;
        /// <summary>
        /// 数字键盘上的 1 键。
        /// </summary>
        public const short VK_NUMPAD1 = 0x61;
        /// <summary>
        /// 数字键盘上的 2 键。
        /// </summary>
        public const short VK_NUMPAD2 = 0x62;
        /// <summary>
        /// 数字键盘上的 3 键。
        /// </summary>
        public const short VK_NUMPAD3 = 0x63;
        /// <summary>
        /// 数字键盘上的 4 键。
        /// </summary>
        public const short VK_NUMPAD4 = 0x64;
        /// <summary>
        /// 数字键盘上的 5 键。
        /// </summary>
        public const short VK_NUMPAD5 = 0x65;
        /// <summary>
        /// 数字键盘上的 6 键。
        /// </summary>
        public const short VK_NUMPAD6 = 0x66;
        /// <summary>
        /// 数字键盘上的 7 键。
        /// </summary>
        public const short VK_NUMPAD7 = 0x67;
        /// <summary>
        /// 数字键盘上的 8 键。
        /// </summary>
        public const short VK_NUMPAD8 = 0x68;
        /// <summary>
        /// 数字键盘上的 9 键。
        /// </summary>
        public const short VK_NUMPAD9 = 0x69;
        /// <summary>
        /// 数字键盘上的 乘号键。
        /// </summary>
        public const short VK_MULTIPLY = 0x6A;
        /// <summary>
        /// 数字键盘上的 加号键。
        /// </summary>
        public const short VK_ADD = 0x6B;
        /// <summary>
        /// 数字键盘上的 回车键。
        /// </summary>
        public const short VK_SEPARATOR = 0x6C;
        /// <summary>
        /// 数字键盘上的 减号键。
        /// </summary>
        public const short VK_SUBTRACT = 0x6D;
        /// <summary>
        /// 数字键盘上的 句点键。
        /// </summary>
        public const short VK_DECIMAL = 0x6E;
        /// <summary>
        /// 数字键盘上的 除号键。
        /// </summary>
        public const short VK_DIVIDE = 0x6F;
        /// <summary>
        /// F1 键。
        /// </summary>
        public const short VK_F1 = 0x70;
        /// <summary>
        /// F2 键。
        /// </summary>
        public const short VK_F2 = 0x71;
        /// <summary>
        /// F3 键。
        /// </summary>
        public const short VK_F3 = 0x72;
        /// <summary>
        /// F4 键。
        /// </summary>
        public const short VK_F4 = 0x73;
        /// <summary>
        /// F5 键。
        /// </summary>
        public const short VK_F5 = 0x74;
        /// <summary>
        /// F6 键。
        /// </summary>
        public const short VK_F6 = 0x75;
        /// <summary>
        /// F7 键。
        /// </summary>
        public const short VK_F7 = 0x76;
        /// <summary>
        /// F8 键。
        /// </summary>
        public const short VK_F8 = 0x77;
        /// <summary>
        /// F9 键。
        /// </summary>
        public const short VK_F9 = 0x78;
        /// <summary>
        /// F10 键。
        /// </summary>
        public const short VK_F10 = 0x79;
        /// <summary>
        /// F11 键。
        /// </summary>
        public const short VK_F11 = 0x7A;
        /// <summary>
        /// F12 键。
        /// </summary>
        public const short VK_F12 = 0x7B;
        /// <summary>
        /// F13 键。
        /// </summary>
        public const short VK_F13 = 0x7C;
        /// <summary>
        /// F14 键。
        /// </summary>
        public const short VK_F14 = 0x7D;
        /// <summary>
        /// F15 键。
        /// </summary>
        public const short VK_F15 = 0x7E;
        /// <summary>
        /// F16 键。
        /// </summary>
        public const short VK_F16 = 0x7F;
        /// <summary>
        /// F17 键。
        /// </summary>
        public const short VK_F17 = 0x80;
        /// <summary>
        /// F18 键。
        /// </summary>
        public const short VK_F18 = 0x81;
        /// <summary>
        /// F19 键。
        /// </summary>
        public const short VK_F19 = 0x82;
        /// <summary>
        /// F20 键。
        /// </summary>
        public const short VK_F20 = 0x83;
        /// <summary>
        /// F21 键。
        /// </summary>
        public const short VK_F21 = 0x84;
        /// <summary>
        /// F22 键。
        /// </summary>
        public const short VK_F22 = 0x85;
        /// <summary>
        /// F23 键。
        /// </summary>
        public const short VK_F23 = 0x86;
        /// <summary>
        /// F24 键。
        /// </summary>
        public const short VK_F24 = 0x87;
        /// <summary>
        /// Num Lock 键。
        /// </summary>
        public const short VK_NUMLOCK = 0x90;
        /// <summary>
        /// Scroll Lock 键。
        /// </summary>
        public const short VK_SCROLL = 0x91;
        /// <summary>
        /// 
        /// </summary>
        public const short VK_OEM_NEC_EQUAL = 0x92;
        /// <summary>
        /// 
        /// </summary>
        public const short VK_OEM_FJ_JISHO = 0x92;
        /// <summary>
        /// 
        /// </summary>
        public const short VK_OEM_FJ_MASSHOU = 0x93;
        /// <summary>
        /// 
        /// </summary>
        public const short VK_OEM_FJ_TOUROKU = 0x94;
        /// <summary>
        /// 
        /// </summary>
        public const short VK_OEM_FJ_LOYA = 0x95;
        /// <summary>
        /// 
        /// </summary>
        public const short VK_OEM_FJ_ROYA = 0x96;
        /// <summary>
        /// 左 Shift 键。
        /// </summary>
        public const short VK_LSHIFT = 0xA0;
        /// <summary>
        /// 右 Shift 键。
        /// </summary>
        public const short VK_RSHIFT = 0xA1;
        /// <summary>
        /// 左 Ctrl 键。
        /// </summary>
        public const short VK_LCONTROL = 0xA2;
        /// <summary>
        /// 右 Ctrl 键。
        /// </summary>
        public const short VK_RCONTROL = 0xA3;
        /// <summary>
        /// 左 Alt 键。
        /// </summary>
        public const short VK_LMENU = 0xA4;
        /// <summary>
        /// 右 Alt 键。
        /// </summary>
        public const short VK_RMENU = 0xA5;
        /// <summary>
        /// 浏览器后退键（Windows 2000 或更高版本）。
        /// </summary>
        public const short VK_BROWSER_BACK = 0xA6;
        /// <summary>
        /// 浏览器前进键（Windows 2000 或更高版本）。
        /// </summary>
        public const short VK_BROWSER_FORWARD = 0xA7;
        /// <summary>
        /// 浏览器刷新键（Windows 2000 或更高版本）。
        /// </summary>
        public const short VK_BROWSER_REFRESH = 0xA8;
        /// <summary>
        /// 浏览器停止键（Windows 2000 或更高版本）。
        /// </summary>
        public const short VK_BROWSER_STOP = 0xA9;
        /// <summary>
        /// 浏览器搜索键（Windows 2000 或更高版本）。
        /// </summary>
        public const short VK_BROWSER_SEARCH = 0xAA;
        /// <summary>
        /// 浏览器收藏夹键（Windows 2000 或更高版本）。
        /// </summary>
        public const short VK_BROWSER_FAVORITES = 0xAB;
        /// <summary>
        /// 浏览器主页键（Windows 2000 或更高版本）。
        /// </summary>
        public const short VK_BROWSER_HOME = 0xAC;
        /// <summary>
        /// 静音键（Windows 2000 或更高版本）。
        /// </summary>
        public const short VK_VOLUME_MUTE = 0xAD;
        /// <summary>
        /// 减小音量键（Windows 2000 或更高版本）。
        /// </summary>
        public const short VK_VOLUME_DOWN = 0xAE;
        /// <summary>
        /// 增大音量键（Windows 2000 或更高版本）。
        /// </summary>
        public const short VK_VOLUME_UP = 0xAF;
        /// <summary>
        /// 媒体下一曲目键（Windows 2000 或更高版本）。
        /// </summary>
        public const short VK_MEDIA_NEXT_TRACK = 0xB0;
        /// <summary>
        /// 媒体上一曲目键（Windows 2000 或更高版本）。
        /// </summary>
        public const short VK_MEDIA_PREV_TRACK = 0xB1;
        /// <summary>
        /// 媒体停止键（Windows 2000 或更高版本）。
        /// </summary>
        public const short VK_MEDIA_STOP = 0xB2;
        /// <summary>
        /// 媒体播放暂停键（Windows 2000 或更高版本）。
        /// </summary>
        public const short VK_MEDIA_PLAY_PAUSE = 0xB3;
        /// <summary>
        /// 启动邮件键（Windows 2000 或更高版本）。
        /// </summary>
        public const short VK_LAUNCH_MAIL = 0xB4;
        /// <summary>
        /// 选择媒体键（Windows 2000 或更高版本）。
        /// </summary>
        public const short VK_LAUNCH_MEDIA_SELECT = 0xB5;
        /// <summary>
        /// 启动应用程序一键（Windows 2000 或更高版本）。
        /// </summary>
        public const short VK_LAUNCH_APP1 = 0xB6;
        /// <summary>
        /// 启动应用程序二键（Windows 2000 或更高版本）。
        /// </summary>
        public const short VK_LAUNCH_APP2 = 0xB7;
        /// <summary>
        /// OEM 1 键。
        /// </summary>
        public const short VK_OEM_1 = 0xBA;   // ';:' for US
        /// <summary>
        /// 美式标准键盘上的 OEM 分号键（Windows 2000 或更高版本）。
        /// </summary>
        public const short VK_OEM_SEMICOLON = 0xBA;
        /// <summary>
        /// 任何国家/地区键盘上的 OEM 加号键（Windows 2000 或更高版本）。
        /// </summary>
        public const short VK_OEM_PLUS = 0xBB;
        /// <summary>
        /// 任何国家/地区键盘上的 OEM 逗号键（Windows 2000 或更高版本）。
        /// </summary>
        public const short VK_OEM_COMMA = 0xBC;
        /// <summary>
        ///  任何国家/地区键盘上的 OEM 减号键（Windows 2000 或更高版本）。
        /// </summary>
        public const short VK_OEM_MINUS = 0xBD;
        /// <summary>
        /// 任何国家/地区键盘上的 OEM 句点键（Windows 2000 或更高版本）。
        /// </summary>
        public const short VK_OEM_PERIOD = 0xBE;
        /// <summary>
        /// 美式标准键盘上的 OEM 问号键（Windows 2000 或更高版本）。
        /// </summary>
        public const short VK_OEM_QUESTION = 0xBF;
        /// <summary>
        /// OEM 2 键。
        /// </summary>
        public const short VK_OEM_2 = 0xBF;
        /// <summary>
        /// 美式标准键盘上的 OEM 波形符键（Windows 2000 或更高版本）。
        /// </summary>
        public const short VK_OEM_OEMTILDE = 0xC0;
        /// <summary>
        /// OEM 3 键。
        /// </summary>
        public const short VK_OEM_3 = 0xC0;
        /// <summary>
        /// OEM 4 键。
        /// </summary>
        public const short VK_OEM_4 = 0xDB;
        /// <summary>
        /// 美式标准键盘上的 OEM 左括号键（Windows 2000 或更高版本）。
        /// </summary>
        public const short VK_OEM_OPENBRACKETS = 0xDB;
        /// <summary>
        /// 美式标准键盘上的 OEM 管道键（Windows 2000 或更高版本）。
        /// </summary>
        public const short VK_OEM_PIPLE = 0xDC;
        /// <summary>
        /// OEM 5 键。
        /// </summary>
        public const short VK_OEM_5 = 0xDC;
        /// <summary>
        /// OEM 6 键。
        /// </summary>
        public const short VK_OEM_6 = 0xDD;
        /// <summary>
        /// 美式标准键盘上的 OEM 右括号键（Windows 2000 或更高版本）。
        /// </summary>
        public const short VK_OEM_CLOSEBRACKETS = 0xDD;
        /// <summary>
        /// OEM 7 键。
        /// </summary>
        public const short VK_OEM_7 = 0xDE;
        /// <summary>
        /// 美式标准键盘上的 OEM 单/双引号键（Windows 2000 或更高版本）。
        /// </summary>
        public const short VK_OEM_QUOTES = 0xDE;
        /// <summary>
        /// OEM 8 键。
        /// </summary>
        public const short VK_OEM_8 = 0xDF;
        /// <summary>
        /// 日本AX键盘的 AX 键。
        /// </summary>
        public const short VK_OEM_AX = 0xE1;
        /// <summary>
        /// OEM 102 键。
        /// </summary>
        public const short VK_OEM_102 = 0xE2;
        /// <summary>
        /// RT 102 键的键盘上的 OEM 尖括号或反斜杠键（Windows 2000 或更高版本）。
        /// </summary>
        public const short VK_OEM_BACKSLASH = 0xE2;
        /// <summary>
        /// 
        /// </summary>
        public const short VK_ICO_HELP = 0xE3;
        /// <summary>
        /// 
        /// </summary>
        public const short VK_ICO_00 = 0xE4;
        /// <summary>
        /// Process Key 键。输入法处理键。
        /// </summary>
        public const short VK_PROCESSKEY = 0xE5;
        /// <summary>
        /// 
        /// </summary>
        public const short VK_ICO_CLEAR = 0xE6;
        /// <summary>
        /// 用于将 Unicode 字符当作键击传递。Packet 键值是用于非键盘输入法的 32 位虚拟键值的低位字。
        /// </summary>
        public const short VK_PACKET = 0xE7;
        /// <summary>
        /// 
        /// </summary>
        public const short VK_OEM_RESET = 0xE9;
        /// <summary>
        /// 
        /// </summary>
        public const short VK_OEM_JUMP = 0xEA;
        /// <summary>
        /// 
        /// </summary>
        public const short VK_OEM_PA1 = 0xEB;
        /// <summary>
        /// 
        /// </summary>
        public const short VK_OEM_PA2 = 0xEC;
        /// <summary>
        /// 
        /// </summary>
        public const short VK_OEM_PA3 = 0xED;
        /// <summary>
        /// 
        /// </summary>
        public const short VK_OEM_WSCTRL = 0xEE;
        /// <summary>
        /// 
        /// </summary>
        public const short VK_OEM_CUSEL = 0xEF;
        /// <summary>
        /// 
        /// </summary>
        public const short VK_OEM_ATTN = 0xF0;
        /// <summary>
        /// 
        /// </summary>
        public const short VK_OEM_FINISH = 0xF1;
        /// <summary>
        /// 
        /// </summary>
        public const short VK_OEM_COPY = 0xF2;
        /// <summary>
        /// 
        /// </summary>
        public const short VK_OEM_AUTO = 0xF3;
        /// <summary>
        /// 
        /// </summary>
        public const short VK_OEM_ENLW = 0xF4;
        /// <summary>
        /// 
        /// </summary>
        public const short VK_OEM_BACKTAB = 0xF5;
        /// <summary>
        /// Attn 键。
        /// </summary>
        public const short VK_ATTN = 0xF6;
        /// <summary>
        /// Crsel 键。
        /// </summary>
        public const short VK_CRSEL = 0xF7;
        /// <summary>
        /// Exsel 键。
        /// </summary>
        public const short VK_EXSEL = 0xF8;
        /// <summary>
        /// ERASE EOF 键。
        /// </summary>
        public const short VK_EREOF = 0xF9;
        /// <summary>
        /// Play 键。
        /// </summary>
        public const short VK_PLAY = 0xFA;
        /// <summary>
        /// Zoom 键。
        /// </summary>
        public const short VK_ZOOM = 0xFB;
        /// <summary>
        /// 保留以备将来使用的常数。
        /// </summary>
        public const short VK_NONAME = 0xFC;
        /// <summary>
        /// PA1 键。
        /// </summary>
        public const short VK_PA1 = 0xFD;
        /// <summary>
        /// Clear 键。
        /// </summary>
        public const short VK_OEM_CLEAR = 0xFE;
    }
}
