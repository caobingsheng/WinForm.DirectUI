namespace WinForm.DirectUI.Win32
{
    //RDW定义
    public static partial class NativeMethods
    {
        /// <summary>
        /// 禁用（屏蔽）重画区域
        /// </summary>
        public const int RDW_INVALIDATE = 0x0001;
        /// <summary>
        /// 即使窗口并非无效，也向其投递一条WM_PAINT消息
        /// </summary>
        public const int RDW_INTERNALPAINT = 0x0002;
        /// <summary>
        /// 重画前，先清除重画区域的背景。也必须指定RDW_INVALIDATE
        /// </summary>
        public const int RDW_ERASE = 0x0004;

        /// <summary>
        /// 检验重画区域
        /// </summary>
        public const int RDW_VALIDATE = 0x0008;
        /// <summary>
        /// 禁止内部生成或由这个函数生成的任何待决WM_PAINT消息。针对无效区域，仍会生成WM_PAINT消息
        /// </summary>
        public const int RDW_NOINTERNALPAINT = 0x0010;
        /// <summary>
        /// 禁止删除重画区域的背景
        /// </summary>
        public const int RDW_NOERASE = 0x0020;

        /// <summary>
        /// 重画操作排除子窗口（前提是它们存在于重画区域）
        /// </summary>
        public const int RDW_NOCHILDREN = 0x0040;
        /// <summary>
        /// 重画操作包括子窗口（前提是它们存在于重画区域）
        /// </summary>
        public const int RDW_ALLCHILDREN = 0x0080;

        /// <summary>
        /// 立即更新指定的重画区域
        /// </summary>
        public const int RDW_UPDATENOW = 0x0100;
        /// <summary>
        /// 立即删除指定的重画区域
        /// </summary>
        public const int RDW_ERASENOW = 0x0200;

        /// <summary>
        /// 如非客户区包含在重画区域中，则对非客户区进行更新。也必须指定RDW_INVALIDATE
        /// </summary>
        public const int RDW_FRAME = 0x0400;
        /// <summary>
        /// 禁止非客户区域重画（如果它是重画区域的一部分）。也必须指定RDW_VALIDATE
        /// </summary>
        public const int RDW_NOFRAME = 0x0800;
    }
}
