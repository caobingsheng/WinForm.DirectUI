namespace WinForm.DirectUI.Win32
{
    //GA定义
    public static partial class NativeMethods
    {
        /// <summary>
        /// Retrieves the parent window. This does not include the owner, as it does with the GetParent function.
        /// </summary>
        public const uint GA_PARENT = 1;
        /// <summary>
        /// Retrieves the root window by walking the chain of parent windows.
        /// </summary>
        public const uint GA_ROOT = 2;
        /// <summary>
        /// Retrieves the owned root window by walking the chain of parent and owner windows returned by GetParent.
        /// </summary>
        public const uint GA_ROOTOWNER = 3;
    }
}
