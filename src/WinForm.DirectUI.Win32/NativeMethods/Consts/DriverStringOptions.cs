namespace WinForm.DirectUI.Win32
{
    //DriverStringOptions定义
    public static partial class NativeMethods
    {
        /// <summary>
        /// Specifies that the string array contains Unicode character values. If this flag is not set, each value in array is interpreted as an index to a font glyph that defines a character to be displayed.
        /// </summary>
        public const int DriverStringOptionsCmapLookup = 0x00000001;
        /// <summary>
        /// Specifies that the string is displayed vertically.
        /// </summary>
        public const int DriverStringOptionsVertical = 0x00000002;
        /// <summary>
        /// Specifies that the glyph positions are calculated from the position of the first glyph. If this flag is not set, the glyph positions are obtained from an array of coordinates.
        /// </summary>
        public const int DriverStringOptionsAdvance = 0x00000004;
        /// <summary>
        /// Specifies that less memory should be used for cache of antialiased glyphs. This also produces lower quality. If this flag is set, more memory is used, but the quality is higher.
        /// </summary>
        public const int DriverStringOptionsLimitSubpixel = 0x00000008;
    }
}
