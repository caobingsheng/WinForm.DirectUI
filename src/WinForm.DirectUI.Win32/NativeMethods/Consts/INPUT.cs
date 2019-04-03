namespace WinForm.DirectUI.Win32
{
    //INPUT定义
    public static partial class NativeMethods
    {
        /// <summary>
        /// The event is a mouse event. Use the mi structure of the union.
        /// </summary>
        public const int INPUT_MOUSE = 0;
        /// <summary>
        /// The event is a keyboard event. Use the ki structure of the union.
        /// </summary>
        public const int INPUT_KEYBOARD = 1;
        /// <summary>
        /// The event is a hardware event. Use the hi structure of the union.
        /// </summary>
        public const int INPUT_HARDWARE = 2;
    }
}
