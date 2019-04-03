namespace WinForm.DirectUI.Win32
{
    //TTS定义
    public static partial class NativeMethods
    {
        /// <summary>
        /// Indicates that the tooltip control appears when the cursor is on a tool, even if the tooltip control's owner window is inactive. Without this style, the tooltip appears only when the tool's owner window is active.
        /// </summary>
        public const int TTS_ALWAYSTIP = 0x01;
        /// <summary>
        /// Prevents the system from stripping ampersand characters from a string or terminating a string at a tab character. Without this style, the system automatically strips ampersand characters and terminates a string at the first tab character. This allows an application to use the same string as both a menu item and as text in a tooltip control.
        /// </summary>
        public const int TTS_NOPREFIX = 0x02;
        /// <summary>
        /// Version 5.80. Disables sliding tooltip animation on Windows 98 and Windows 2000 systems. This style is ignored on earlier systems.
        /// </summary>
        public const int TTS_NOANIMATE = 0x10;
        /// <summary>
        /// Version 5.80. Disables fading tooltip animation on Windows 2000 systems. This style is ignored on earlier Windows NT systems, and on Windows 95 and Windows 98.
        /// </summary>
        public const int TTS_NOFADE = 0x20;
        /// <summary>
        /// Version 5.80. Indicates that the tooltip control has the appearance of a cartoon "balloon," with rounded corners and a stem pointing to the item.
        /// </summary>
        public const int TTS_BALLOON = 0x40;
        /// <summary>
        /// Displays a Close button on the tooltip. Valid only when the tooltip has the TTS_BALLOON style and a title; see TTM_SETTITLE.
        /// </summary>
        public const int TTS_CLOSE = 0x80;
        /// <summary>
        /// Uses themed hyperlinks. The theme will define the styles for any links in the tooltip. This style always requires TTF_PARSELINKS to be set.
        /// </summary>
        public const int TTS_USEVISUALSTYLE = 0x100;
    }
}
