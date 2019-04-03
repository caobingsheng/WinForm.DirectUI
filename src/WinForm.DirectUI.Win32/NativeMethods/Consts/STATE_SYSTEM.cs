namespace WinForm.DirectUI.Win32
{
    //STATE_SYSTEM定义
    public static partial class NativeMethods
    {
        /// <summary>
        /// 0
        /// </summary>
        public const int STATE_SYSTEM_NONE = 0x00000000;
        /// <summary>
        /// Disabled
        /// </summary>
        public const int STATE_SYSTEM_UNAVAILABLE = 0x00000001;
        /// <summary>
        /// 
        /// </summary>
        public const int STATE_SYSTEM_SELECTED = 0x00000002;
        /// <summary>
        /// 
        /// </summary>
        public const int STATE_SYSTEM_FOCUSED = 0x00000004;
        /// <summary>
        /// 
        /// </summary>
        public const int STATE_SYSTEM_PRESSED = 0x00000008;
        /// <summary>
        /// 
        /// </summary>
        public const int STATE_SYSTEM_CHECKED = 0x00000010;
        /// <summary>
        /// 3-state checkbox or toolbar button
        /// </summary>
        public const int STATE_SYSTEM_MIXED = 0x00000020;
        /// <summary>
        /// 
        /// </summary>
        public const int STATE_SYSTEM_INDETERMINATE = STATE_SYSTEM_MIXED;
        /// <summary>
        /// 
        /// </summary>
        public const int STATE_SYSTEM_READONLY = 0x00000040;
        /// <summary>
        /// 
        /// </summary>
        public const int STATE_SYSTEM_HOTTRACKED = 0x00000080;
        /// <summary>
        /// 
        /// </summary>
        public const int STATE_SYSTEM_DEFAULT = 0x00000100;
        /// <summary>
        /// 
        /// </summary>
        public const int STATE_SYSTEM_EXPANDED = 0x00000200;
        /// <summary>
        /// 
        /// </summary>
        public const int STATE_SYSTEM_COLLAPSED = 0x00000400;
        /// <summary>
        /// 
        /// </summary>
        public const int STATE_SYSTEM_BUSY = 0x00000800;
        /// <summary>
        /// Children "owned" not "contained" by parent
        /// </summary>
        public const int STATE_SYSTEM_FLOATING = 0x00001000;
        /// <summary>
        /// 
        /// </summary>
        public const int STATE_SYSTEM_MARQUEED = 0x00002000;
        /// <summary>
        /// 
        /// </summary>
        public const int STATE_SYSTEM_ANIMATED = 0x00004000;
        /// <summary>
        /// 
        /// </summary>
        public const int STATE_SYSTEM_INVISIBLE = 0x00008000;
        /// <summary>
        /// 
        /// </summary>
        public const int STATE_SYSTEM_OFFSCREEN = 0x00010000;
        /// <summary>
        /// 
        /// </summary>
        public const int STATE_SYSTEM_SIZEABLE = 0x00020000;
        /// <summary>
        /// 
        /// </summary>
        public const int STATE_SYSTEM_MOVEABLE = 0x00040000;
        /// <summary>
        /// 
        /// </summary>
        public const int STATE_SYSTEM_SELFVOICING = 0x00080000;
        /// <summary>
        /// 
        /// </summary>
        public const int STATE_SYSTEM_FOCUSABLE = 0x00100000;
        /// <summary>
        /// 
        /// </summary>
        public const int STATE_SYSTEM_SELECTABLE = 0x00200000;
        /// <summary>
        /// 
        /// </summary>
        public const int STATE_SYSTEM_LINKED = 0x00400000;
        /// <summary>
        /// 
        /// </summary>
        public const int STATE_SYSTEM_TRAVERSED = 0x00800000;
        /// <summary>
        /// Supports multiple selection
        /// </summary>
        public const int STATE_SYSTEM_MULTISELECTABLE = 0x01000000;
        /// <summary>
        /// Supports extended selection
        /// </summary>
        public const int STATE_SYSTEM_EXTSELECTABLE = 0x02000000;
        /// <summary>
        /// This information is of low priority
        /// </summary>
        public const int STATE_SYSTEM_ALERT_LOW = 0x04000000;
        /// <summary>
        /// This information is of medium priority
        /// </summary>
        public const int STATE_SYSTEM_ALERT_MEDIUM = 0x08000000;
        /// <summary>
        /// This information is of high priority
        /// </summary>
        public const int STATE_SYSTEM_ALERT_HIGH = 0x10000000;
        /// <summary>
        /// access to this is restricted
        /// </summary>
        public const int STATE_SYSTEM_PROTECTED = 0x20000000;
        /// <summary>
        /// 
        /// </summary>
        public const int STATE_SYSTEM_VALID = 0x3FFFFFFF;
    }
}
