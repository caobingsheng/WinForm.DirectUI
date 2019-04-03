namespace WinForm.DirectUI.Win32
{
    //TTDT定义
    public static partial class NativeMethods
    {
        /// <summary>
        /// Set all three delay times to default proportions. The autopop time will be ten times the initial time and the reshow time will be one fifth the initial time. If this flag is set, use a positive value of lParam to specify the initial time, in milliseconds. Set lParam to a negative value to return all three delay times to their default values.
        /// </summary>
        public const int TTDT_AUTOMATIC = 0;
        /// <summary>
        /// Set the amount of time it takes for subsequent tooltip windows to appear as the pointer moves from one tool to another. To return the reshow delay time to its default value, set lParam to -1.
        /// </summary>
        public const int TTDT_RESHOW = 1;
        /// <summary>
        /// Set the amount of time a tooltip window remains visible if the pointer is stationary within a tool's bounding rectangle. To return the autopop delay time to its default value, set lParam to -1.
        /// </summary>
        public const int TTDT_AUTOPOP = 2;
        /// <summary>
        /// Set the amount of time a pointer must remain stationary within a tool's bounding rectangle before the tooltip window appears. To return the initial delay time to its default value, set lParam to -1.
        /// </summary>
        public const int TTDT_INITIAL = 3;
    }
}
