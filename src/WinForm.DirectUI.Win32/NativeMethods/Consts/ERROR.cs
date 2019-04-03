namespace WinForm.DirectUI.Win32
{
    //ERROR定义
    public static partial class NativeMethods
    {
        /************************************************************************
        *                                                                       *
        *   winerror.h --  error code definitions for the Win32 API functions   *
        *                                                                       *
        *   Copyright (c) Microsoft Corp.  All rights reserved.                 *
        *                                                                       *
        ************************************************************************/


        //
        //  Values are 32 bit values layed out as follows:
        //
        //   3 3 2 2 2 2 2 2 2 2 2 2 1 1 1 1 1 1 1 1 1 1
        //   1 0 9 8 7 6 5 4 3 2 1 0 9 8 7 6 5 4 3 2 1 0 9 8 7 6 5 4 3 2 1 0
        //  +---+-+-+-----------------------+-------------------------------+
        //  |Sev|C|R|     Facility          |               Code            |
        //  +---+-+-+-----------------------+-------------------------------+
        //
        //  where
        //
        //      Sev - is the severity code
        //
        //          00 - Success
        //          01 - Informational
        //          10 - Warning
        //          11 - Error
        //
        //      C - is the Customer code flag
        //
        //      R - is a reserved bit
        //
        //      Facility - is the facility code
        //
        //      Code - is the facility's status code
        //
        //
        // Define the facility codes
        //


        /// <summary>
        /// 
        /// </summary>
        public const int FACILITY_WINDOWSUPDATE = 36;
        /// <summary>
        /// 
        /// </summary>
        public const int FACILITY_WINDOWS_CE = 24;
        /// <summary>
        /// 
        /// </summary>
        public const int FACILITY_WINDOWS = 8;
        /// <summary>
        /// 
        /// </summary>
        public const int FACILITY_URT = 19;
        /// <summary>
        /// 
        /// </summary>
        public const int FACILITY_UMI = 22;
        /// <summary>
        /// 
        /// </summary>
        public const int FACILITY_SXS = 23;
        /// <summary>
        /// 
        /// </summary>
        public const int FACILITY_STORAGE = 3;
        /// <summary>
        /// 
        /// </summary>
        public const int FACILITY_STATE_MANAGEMENT = 34;
        /// <summary>
        /// 
        /// </summary>
        public const int FACILITY_SSPI = 9;
        /// <summary>
        /// 
        /// </summary>
        public const int FACILITY_SCARD = 16;
        /// <summary>
        /// 
        /// </summary>
        public const int FACILITY_SETUPAPI = 15;
        /// <summary>
        /// 
        /// </summary>
        public const int FACILITY_SECURITY = 9;
        /// <summary>
        /// 
        /// </summary>
        public const int FACILITY_RPC = 1;
        /// <summary>
        /// 
        /// </summary>
        public const int FACILITY_WIN32 = 7;
        /// <summary>
        /// 
        /// </summary>
        public const int FACILITY_CONTROL = 10;
        /// <summary>
        /// 
        /// </summary>
        public const int FACILITY_NULL = 0;
        /// <summary>
        /// 
        /// </summary>
        public const int FACILITY_METADIRECTORY = 35;
        /// <summary>
        /// 
        /// </summary>
        public const int FACILITY_MSMQ = 14;
        /// <summary>
        /// 
        /// </summary>
        public const int FACILITY_MEDIASERVER = 13;
        /// <summary>
        /// 
        /// </summary>
        public const int FACILITY_INTERNET = 12;
        /// <summary>
        /// 
        /// </summary>
        public const int FACILITY_ITF = 4;
        /// <summary>
        /// 
        /// </summary>
        public const int FACILITY_HTTP = 25;
        /// <summary>
        /// 
        /// </summary>
        public const int FACILITY_DPLAY = 21;
        /// <summary>
        /// 
        /// </summary>
        public const int FACILITY_DISPATCH = 2;
        /// <summary>
        /// 
        /// </summary>
        public const int FACILITY_DIRECTORYSERVICE = 37;
        /// <summary>
        /// 
        /// </summary>
        public const int FACILITY_CONFIGURATION = 33;
        /// <summary>
        /// 
        /// </summary>
        public const int FACILITY_COMPLUS = 17;
        /// <summary>
        /// 
        /// </summary>
        public const int FACILITY_CERT = 11;
        /// <summary>
        /// 
        /// </summary>
        public const int FACILITY_BACKGROUNDCOPY = 32;
        /// <summary>
        /// 
        /// </summary>
        public const int FACILITY_ACS = 20;
        /// <summary>
        /// 
        /// </summary>
        public const int FACILITY_AAF = 18;


        // Define the severity codes


        /// <summary>
        /// <para>// MessageId: ERROR_SUCCESS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The operation completed successfully.</para>
        /// </summary>
        public const int ERROR_SUCCESS = 0;

        /// <summary>
        /// 
        /// </summary>
        public const int NO_ERROR = 0; // dderror
        /// <summary>
        /// 
        /// </summary>
        public const int SEC_E_OK = 0x00000000;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_FUNCTION</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Incorrect function.</para>
        /// </summary>
        public const int ERROR_INVALID_FUNCTION = 1; // dderror

        /// <summary>
        /// <para>// MessageId: ERROR_FILE_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The system cannot find the file specified.</para>
        /// </summary>
        public const int ERROR_FILE_NOT_FOUND = 2;

        /// <summary>
        /// <para>// MessageId: ERROR_PATH_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The system cannot find the path specified.</para>
        /// </summary>
        public const int ERROR_PATH_NOT_FOUND = 3;

        /// <summary>
        /// <para>// MessageId: ERROR_TOO_MANY_OPEN_FILES</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The system cannot open the file.</para>
        /// </summary>
        public const int ERROR_TOO_MANY_OPEN_FILES = 4;

        /// <summary>
        /// <para>// MessageId: ERROR_ACCESS_DENIED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Access is denied.</para>
        /// </summary>
        public const int ERROR_ACCESS_DENIED = 5;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_HANDLE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The handle is invalid.</para>
        /// </summary>
        public const int ERROR_INVALID_HANDLE = 6;

        /// <summary>
        /// <para>// MessageId: ERROR_ARENA_TRASHED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The storage control blocks were destroyed.</para>
        /// </summary>
        public const int ERROR_ARENA_TRASHED = 7;

        /// <summary>
        /// <para>// MessageId: ERROR_NOT_ENOUGH_MEMORY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Not enough storage is available to process this command.</para>
        /// </summary>
        public const int ERROR_NOT_ENOUGH_MEMORY = 8; // dderror

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_BLOCK</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The storage control block address is invalid.</para>
        /// </summary>
        public const int ERROR_INVALID_BLOCK = 9;

        /// <summary>
        /// <para>// MessageId: ERROR_BAD_ENVIRONMENT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The environment is incorrect.</para>
        /// </summary>
        public const int ERROR_BAD_ENVIRONMENT = 10;

        /// <summary>
        /// <para>// MessageId: ERROR_BAD_FORMAT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An attempt was made to load a program with an incorrect format.</para>
        /// </summary>
        public const int ERROR_BAD_FORMAT = 11;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_ACCESS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The access code is invalid.</para>
        /// </summary>
        public const int ERROR_INVALID_ACCESS = 12;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_DATA</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The data is invalid.</para>
        /// </summary>
        public const int ERROR_INVALID_DATA = 13;

        /// <summary>
        /// <para>// MessageId: ERROR_OUTOFMEMORY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Not enough storage is available to complete this operation.</para>
        /// </summary>
        public const int ERROR_OUTOFMEMORY = 14;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_DRIVE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The system cannot find the drive specified.</para>
        /// </summary>
        public const int ERROR_INVALID_DRIVE = 15;

        /// <summary>
        /// <para>// MessageId: ERROR_CURRENT_DIRECTORY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The directory cannot be removed.</para>
        /// </summary>
        public const int ERROR_CURRENT_DIRECTORY = 16;

        /// <summary>
        /// <para>// MessageId: ERROR_NOT_SAME_DEVICE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The system cannot move the file to a different disk drive.</para>
        /// </summary>
        public const int ERROR_NOT_SAME_DEVICE = 17;

        /// <summary>
        /// <para>// MessageId: ERROR_NO_MORE_FILES</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  There are no more files.</para>
        /// </summary>
        public const int ERROR_NO_MORE_FILES = 18;

        /// <summary>
        /// <para>// MessageId: ERROR_WRITE_PROTECT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The media is write protected.</para>
        /// </summary>
        public const int ERROR_WRITE_PROTECT = 19;

        /// <summary>
        /// <para>// MessageId: ERROR_BAD_UNIT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The system cannot find the device specified.</para>
        /// </summary>
        public const int ERROR_BAD_UNIT = 20;

        /// <summary>
        /// <para>// MessageId: ERROR_NOT_READY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The device is not ready.</para>
        /// </summary>
        public const int ERROR_NOT_READY = 21;

        /// <summary>
        /// <para>// MessageId: ERROR_BAD_COMMAND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The device does not recognize the command.</para>
        /// </summary>
        public const int ERROR_BAD_COMMAND = 22;

        /// <summary>
        /// <para>// MessageId: ERROR_CRC</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Data error (cyclic redundancy check).</para>
        /// </summary>
        public const int ERROR_CRC = 23;

        /// <summary>
        /// <para>// MessageId: ERROR_BAD_LENGTH</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The program issued a command but the command length is incorrect.</para>
        /// </summary>
        public const int ERROR_BAD_LENGTH = 24;

        /// <summary>
        /// <para>// MessageId: ERROR_SEEK</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The drive cannot locate a specific area or track on the disk.</para>
        /// </summary>
        public const int ERROR_SEEK = 25;

        /// <summary>
        /// <para>// MessageId: ERROR_NOT_DOS_DISK</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified disk or diskette cannot be accessed.</para>
        /// </summary>
        public const int ERROR_NOT_DOS_DISK = 26;

        /// <summary>
        /// <para>// MessageId: ERROR_SECTOR_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The drive cannot find the sector requested.</para>
        /// </summary>
        public const int ERROR_SECTOR_NOT_FOUND = 27;

        /// <summary>
        /// <para>// MessageId: ERROR_OUT_OF_PAPER</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The printer is out of paper.</para>
        /// </summary>
        public const int ERROR_OUT_OF_PAPER = 28;

        /// <summary>
        /// <para>// MessageId: ERROR_WRITE_FAULT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The system cannot write to the specified device.</para>
        /// </summary>
        public const int ERROR_WRITE_FAULT = 29;

        /// <summary>
        /// <para>// MessageId: ERROR_READ_FAULT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The system cannot read from the specified device.</para>
        /// </summary>
        public const int ERROR_READ_FAULT = 30;

        /// <summary>
        /// <para>// MessageId: ERROR_GEN_FAILURE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A device attached to the system is not functioning.</para>
        /// </summary>
        public const int ERROR_GEN_FAILURE = 31;

        /// <summary>
        /// <para>// MessageId: ERROR_SHARING_VIOLATION</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The process cannot access the file because it is being used by another process.</para>
        /// </summary>
        public const int ERROR_SHARING_VIOLATION = 32;

        /// <summary>
        /// <para>// MessageId: ERROR_LOCK_VIOLATION</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The process cannot access the file because another process has locked a portion of the file.</para>
        /// </summary>
        public const int ERROR_LOCK_VIOLATION = 33;

        /// <summary>
        /// <para>// MessageId: ERROR_WRONG_DISK</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The wrong diskette is in the drive.</para>
        /// <para>//  Insert %2 (Volume Serial Number: %3) into drive %1.</para>
        /// </summary>
        public const int ERROR_WRONG_DISK = 34;

        /// <summary>
        /// <para>// MessageId: ERROR_SHARING_BUFFER_EXCEEDED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Too many files opened for sharing.</para>
        /// </summary>
        public const int ERROR_SHARING_BUFFER_EXCEEDED = 36;

        /// <summary>
        /// <para>// MessageId: ERROR_HANDLE_EOF</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Reached the end of the file.</para>
        /// </summary>
        public const int ERROR_HANDLE_EOF = 38;

        /// <summary>
        /// <para>// MessageId: ERROR_HANDLE_DISK_FULL</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The disk is full.</para>
        /// </summary>
        public const int ERROR_HANDLE_DISK_FULL = 39;

        /// <summary>
        /// <para>// MessageId: ERROR_NOT_SUPPORTED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The request is not supported.</para>
        /// </summary>
        public const int ERROR_NOT_SUPPORTED = 50;

        /// <summary>
        /// <para>// MessageId: ERROR_REM_NOT_LIST</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Windows cannot find the network path. Verify that the network path is correct and the destination  computer is not busy or turned off. If Windows still cannot find the network path, contact your  network administrator.</para>
        /// </summary>
        public const int ERROR_REM_NOT_LIST = 51;

        /// <summary>
        /// <para>// MessageId: ERROR_DUP_NAME</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  You were not connected because a duplicate name exists on the network. Go to System in Control  Panel to change the computer name and try again.</para>
        /// </summary>
        public const int ERROR_DUP_NAME = 52;

        /// <summary>
        /// <para>// MessageId: ERROR_BAD_NETPATH</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The network path was not found.</para>
        /// </summary>
        public const int ERROR_BAD_NETPATH = 53;

        /// <summary>
        /// <para>// MessageId: ERROR_NETWORK_BUSY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The network is busy.</para>
        /// </summary>
        public const int ERROR_NETWORK_BUSY = 54;

        /// <summary>
        /// <para>// MessageId: ERROR_DEV_NOT_EXIST</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified network resource or device is no longer available.</para>
        /// </summary>
        public const int ERROR_DEV_NOT_EXIST = 55; // dderror

        /// <summary>
        /// <para>// MessageId: ERROR_TOO_MANY_CMDS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The network BIOS command limit has been reached.</para>
        /// </summary>
        public const int ERROR_TOO_MANY_CMDS = 56;

        /// <summary>
        /// <para>// MessageId: ERROR_ADAP_HDW_ERR</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A network adapter hardware error occurred.</para>
        /// </summary>
        public const int ERROR_ADAP_HDW_ERR = 57;

        /// <summary>
        /// <para>// MessageId: ERROR_BAD_NET_RESP</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified server cannot perform the requested operation.</para>
        /// </summary>
        public const int ERROR_BAD_NET_RESP = 58;

        /// <summary>
        /// <para>// MessageId: ERROR_UNEXP_NET_ERR</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An unexpected network error occurred.</para>
        /// </summary>
        public const int ERROR_UNEXP_NET_ERR = 59;

        /// <summary>
        /// <para>// MessageId: ERROR_BAD_REM_ADAP</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The remote adapter is not compatible.</para>
        /// </summary>
        public const int ERROR_BAD_REM_ADAP = 60;

        /// <summary>
        /// <para>// MessageId: ERROR_PRINTQ_FULL</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The printer queue is full.</para>
        /// </summary>
        public const int ERROR_PRINTQ_FULL = 61;

        /// <summary>
        /// <para>// MessageId: ERROR_NO_SPOOL_SPACE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Space to store the file waiting to be printed is not available on the server.</para>
        /// </summary>
        public const int ERROR_NO_SPOOL_SPACE = 62;

        /// <summary>
        /// <para>// MessageId: ERROR_PRINT_CANCELLED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Your file waiting to be printed was deleted.</para>
        /// </summary>
        public const int ERROR_PRINT_CANCELLED = 63;

        /// <summary>
        /// <para>// MessageId: ERROR_NETNAME_DELETED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified network name is no longer available.</para>
        /// </summary>
        public const int ERROR_NETNAME_DELETED = 64;

        /// <summary>
        /// <para>// MessageId: ERROR_NETWORK_ACCESS_DENIED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Network access is denied.</para>
        /// </summary>
        public const int ERROR_NETWORK_ACCESS_DENIED = 65;

        /// <summary>
        /// <para>// MessageId: ERROR_BAD_DEV_TYPE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The network resource type is not correct.</para>
        /// </summary>
        public const int ERROR_BAD_DEV_TYPE = 66;

        /// <summary>
        /// <para>// MessageId: ERROR_BAD_NET_NAME</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The network name cannot be found.</para>
        /// </summary>
        public const int ERROR_BAD_NET_NAME = 67;

        /// <summary>
        /// <para>// MessageId: ERROR_TOO_MANY_NAMES</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The name limit for the local computer network adapter card was exceeded.</para>
        /// </summary>
        public const int ERROR_TOO_MANY_NAMES = 68;

        /// <summary>
        /// <para>// MessageId: ERROR_TOO_MANY_SESS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The network BIOS session limit was exceeded.</para>
        /// </summary>
        public const int ERROR_TOO_MANY_SESS = 69;

        /// <summary>
        /// <para>// MessageId: ERROR_SHARING_PAUSED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The remote server has been paused or is in the process of being started.</para>
        /// </summary>
        public const int ERROR_SHARING_PAUSED = 70;

        /// <summary>
        /// <para>// MessageId: ERROR_REQ_NOT_ACCEP</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  No more connections can be made to this remote computer at this time because there are already as  many connections as the computer can accept.</para>
        /// </summary>
        public const int ERROR_REQ_NOT_ACCEP = 71;

        /// <summary>
        /// <para>// MessageId: ERROR_REDIR_PAUSED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified printer or disk device has been paused.</para>
        /// </summary>
        public const int ERROR_REDIR_PAUSED = 72;

        /// <summary>
        /// <para>// MessageId: ERROR_FILE_EXISTS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The file exists.</para>
        /// </summary>
        public const int ERROR_FILE_EXISTS = 80;

        /// <summary>
        /// <para>// MessageId: ERROR_CANNOT_MAKE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The directory or file cannot be created.</para>
        /// </summary>
        public const int ERROR_CANNOT_MAKE = 82;

        /// <summary>
        /// <para>// MessageId: ERROR_FAIL_I24</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Fail on INT 24.</para>
        /// </summary>
        public const int ERROR_FAIL_I24 = 83;

        /// <summary>
        /// <para>// MessageId: ERROR_OUT_OF_STRUCTURES</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Storage to process this request is not available.</para>
        /// </summary>
        public const int ERROR_OUT_OF_STRUCTURES = 84;

        /// <summary>
        /// <para>// MessageId: ERROR_ALREADY_ASSIGNED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The local device name is already in use.</para>
        /// </summary>
        public const int ERROR_ALREADY_ASSIGNED = 85;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_PASSWORD</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified network password is not correct.</para>
        /// </summary>
        public const int ERROR_INVALID_PASSWORD = 86;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_PARAMETER</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The parameter is incorrect.</para>
        /// </summary>
        public const int ERROR_INVALID_PARAMETER = 87; // dderror

        /// <summary>
        /// <para>// MessageId: ERROR_NET_WRITE_FAULT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A write fault occurred on the network.</para>
        /// </summary>
        public const int ERROR_NET_WRITE_FAULT = 88;

        /// <summary>
        /// <para>// MessageId: ERROR_NO_PROC_SLOTS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The system cannot start another process at this time.</para>
        /// </summary>
        public const int ERROR_NO_PROC_SLOTS = 89;

        /// <summary>
        /// <para>// MessageId: ERROR_TOO_MANY_SEMAPHORES</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Cannot create another system semaphore.</para>
        /// </summary>
        public const int ERROR_TOO_MANY_SEMAPHORES = 100;

        /// <summary>
        /// <para>// MessageId: ERROR_EXCL_SEM_ALREADY_OWNED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The exclusive semaphore is owned by another process.</para>
        /// </summary>
        public const int ERROR_EXCL_SEM_ALREADY_OWNED = 101;

        /// <summary>
        /// <para>// MessageId: ERROR_SEM_IS_SET</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The semaphore is set and cannot be closed.</para>
        /// </summary>
        public const int ERROR_SEM_IS_SET = 102;

        /// <summary>
        /// <para>// MessageId: ERROR_TOO_MANY_SEM_REQUESTS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The semaphore cannot be set again.</para>
        /// </summary>
        public const int ERROR_TOO_MANY_SEM_REQUESTS = 103;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_AT_INTERRUPT_TIME</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Cannot request exclusive semaphores at interrupt time.</para>
        /// </summary>
        public const int ERROR_INVALID_AT_INTERRUPT_TIME = 104;

        /// <summary>
        /// <para>// MessageId: ERROR_SEM_OWNER_DIED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The previous ownership of this semaphore has ended.</para>
        /// </summary>
        public const int ERROR_SEM_OWNER_DIED = 105;

        /// <summary>
        /// <para>// MessageId: ERROR_SEM_USER_LIMIT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Insert the diskette for drive %1.</para>
        /// </summary>
        public const int ERROR_SEM_USER_LIMIT = 106;

        /// <summary>
        /// <para>// MessageId: ERROR_DISK_CHANGE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The program stopped because an alternate diskette was not inserted.</para>
        /// </summary>
        public const int ERROR_DISK_CHANGE = 107;

        /// <summary>
        /// <para>// MessageId: ERROR_DRIVE_LOCKED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The disk is in use or locked by another process.</para>
        /// </summary>
        public const int ERROR_DRIVE_LOCKED = 108;

        /// <summary>
        /// <para>// MessageId: ERROR_BROKEN_PIPE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The pipe has been ended.</para>
        /// </summary>
        public const int ERROR_BROKEN_PIPE = 109;

        /// <summary>
        /// <para>// MessageId: ERROR_OPEN_FAILED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The system cannot open the device or file specified.</para>
        /// </summary>
        public const int ERROR_OPEN_FAILED = 110;

        /// <summary>
        /// <para>// MessageId: ERROR_BUFFER_OVERFLOW</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The file name is too long.</para>
        /// </summary>
        public const int ERROR_BUFFER_OVERFLOW = 111;

        /// <summary>
        /// <para>// MessageId: ERROR_DISK_FULL</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  There is not enough space on the disk.</para>
        /// </summary>
        public const int ERROR_DISK_FULL = 112;

        /// <summary>
        /// <para>// MessageId: ERROR_NO_MORE_SEARCH_HANDLES</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  No more internal file identifiers available.</para>
        /// </summary>
        public const int ERROR_NO_MORE_SEARCH_HANDLES = 113;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_TARGET_HANDLE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The target internal file identifier is incorrect.</para>
        /// </summary>
        public const int ERROR_INVALID_TARGET_HANDLE = 114;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_CATEGORY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The IOCTL call made by the application program is not correct.</para>
        /// </summary>
        public const int ERROR_INVALID_CATEGORY = 117;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_VERIFY_SWITCH</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The verify-on-write switch parameter value is not correct.</para>
        /// </summary>
        public const int ERROR_INVALID_VERIFY_SWITCH = 118;

        /// <summary>
        /// <para>// MessageId: ERROR_BAD_DRIVER_LEVEL</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The system does not support the command requested.</para>
        /// </summary>
        public const int ERROR_BAD_DRIVER_LEVEL = 119;

        /// <summary>
        /// <para>// MessageId: ERROR_CALL_NOT_IMPLEMENTED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  This function is not supported on this system.</para>
        /// </summary>
        public const int ERROR_CALL_NOT_IMPLEMENTED = 120;

        /// <summary>
        /// <para>// MessageId: ERROR_SEM_TIMEOUT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The semaphore timeout period has expired.</para>
        /// </summary>
        public const int ERROR_SEM_TIMEOUT = 121;

        /// <summary>
        /// <para>// MessageId: ERROR_INSUFFICIENT_BUFFER</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The data area passed to a system call is too small.</para>
        /// </summary>
        public const int ERROR_INSUFFICIENT_BUFFER = 122; // dderror

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_NAME</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The filename, directory name, or volume label syntax is incorrect.</para>
        /// </summary>
        public const int ERROR_INVALID_NAME = 123; // dderror

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_LEVEL</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The system call level is not correct.</para>
        /// </summary>
        public const int ERROR_INVALID_LEVEL = 124;

        /// <summary>
        /// <para>// MessageId: ERROR_NO_VOLUME_LABEL</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The disk has no volume label.</para>
        /// </summary>
        public const int ERROR_NO_VOLUME_LABEL = 125;

        /// <summary>
        /// <para>// MessageId: ERROR_MOD_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified module could not be found.</para>
        /// </summary>
        public const int ERROR_MOD_NOT_FOUND = 126;

        /// <summary>
        /// <para>// MessageId: ERROR_PROC_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified procedure could not be found.</para>
        /// </summary>
        public const int ERROR_PROC_NOT_FOUND = 127;

        /// <summary>
        /// <para>// MessageId: ERROR_WAIT_NO_CHILDREN</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  There are no child processes to wait for.</para>
        /// </summary>
        public const int ERROR_WAIT_NO_CHILDREN = 128;

        /// <summary>
        /// <para>// MessageId: ERROR_CHILD_NOT_COMPLETE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The %1 application cannot be run in Win32 mode.</para>
        /// </summary>
        public const int ERROR_CHILD_NOT_COMPLETE = 129;

        /// <summary>
        /// <para>// MessageId: ERROR_DIRECT_ACCESS_HANDLE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Attempt to use a file handle to an open disk partition for an operation other than raw disk I/O.</para>
        /// </summary>
        public const int ERROR_DIRECT_ACCESS_HANDLE = 130;

        /// <summary>
        /// <para>// MessageId: ERROR_NEGATIVE_SEEK</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An attempt was made to move the file pointer before the beginning of the file.</para>
        /// </summary>
        public const int ERROR_NEGATIVE_SEEK = 131;

        /// <summary>
        /// <para>// MessageId: ERROR_SEEK_ON_DEVICE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The file pointer cannot be set on the specified device or file.</para>
        /// </summary>
        public const int ERROR_SEEK_ON_DEVICE = 132;

        /// <summary>
        /// <para>// MessageId: ERROR_IS_JOIN_TARGET</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A JOIN or SUBST command cannot be used for a drive that contains previously joined drives.</para>
        /// </summary>
        public const int ERROR_IS_JOIN_TARGET = 133;

        /// <summary>
        /// <para>// MessageId: ERROR_IS_JOINED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An attempt was made to use a JOIN or SUBST command on a drive that has already been joined.</para>
        /// </summary>
        public const int ERROR_IS_JOINED = 134;

        /// <summary>
        /// <para>// MessageId: ERROR_IS_SUBSTED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An attempt was made to use a JOIN or SUBST command on a drive that has already been substituted.</para>
        /// </summary>
        public const int ERROR_IS_SUBSTED = 135;

        /// <summary>
        /// <para>// MessageId: ERROR_NOT_JOINED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The system tried to delete the JOIN of a drive that is not joined.</para>
        /// </summary>
        public const int ERROR_NOT_JOINED = 136;

        /// <summary>
        /// <para>// MessageId: ERROR_NOT_SUBSTED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The system tried to delete the substitution of a drive that is not substituted.</para>
        /// </summary>
        public const int ERROR_NOT_SUBSTED = 137;

        /// <summary>
        /// <para>// MessageId: ERROR_JOIN_TO_JOIN</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The system tried to join a drive to a directory on a joined drive.</para>
        /// </summary>
        public const int ERROR_JOIN_TO_JOIN = 138;

        /// <summary>
        /// <para>// MessageId: ERROR_SUBST_TO_SUBST</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The system tried to substitute a drive to a directory on a substituted drive.</para>
        /// </summary>
        public const int ERROR_SUBST_TO_SUBST = 139;

        /// <summary>
        /// <para>// MessageId: ERROR_JOIN_TO_SUBST</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The system tried to join a drive to a directory on a substituted drive.</para>
        /// </summary>
        public const int ERROR_JOIN_TO_SUBST = 140;

        /// <summary>
        /// <para>// MessageId: ERROR_SUBST_TO_JOIN</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The system tried to SUBST a drive to a directory on a joined drive.</para>
        /// </summary>
        public const int ERROR_SUBST_TO_JOIN = 141;

        /// <summary>
        /// <para>// MessageId: ERROR_BUSY_DRIVE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The system cannot perform a JOIN or SUBST at this time.</para>
        /// </summary>
        public const int ERROR_BUSY_DRIVE = 142;

        /// <summary>
        /// <para>// MessageId: ERROR_SAME_DRIVE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The system cannot join or substitute a drive to or for a directory on the same drive.</para>
        /// </summary>
        public const int ERROR_SAME_DRIVE = 143;

        /// <summary>
        /// <para>// MessageId: ERROR_DIR_NOT_ROOT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The directory is not a subdirectory of the root directory.</para>
        /// </summary>
        public const int ERROR_DIR_NOT_ROOT = 144;

        /// <summary>
        /// <para>// MessageId: ERROR_DIR_NOT_EMPTY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The directory is not empty.</para>
        /// </summary>
        public const int ERROR_DIR_NOT_EMPTY = 145;

        /// <summary>
        /// <para>// MessageId: ERROR_IS_SUBST_PATH</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The path specified is being used in a substitute.</para>
        /// </summary>
        public const int ERROR_IS_SUBST_PATH = 146;

        /// <summary>
        /// <para>// MessageId: ERROR_IS_JOIN_PATH</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Not enough resources are available to process this command.</para>
        /// </summary>
        public const int ERROR_IS_JOIN_PATH = 147;

        /// <summary>
        /// <para>// MessageId: ERROR_PATH_BUSY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The path specified cannot be used at this time.</para>
        /// </summary>
        public const int ERROR_PATH_BUSY = 148;

        /// <summary>
        /// <para>// MessageId: ERROR_IS_SUBST_TARGET</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An attempt was made to join or substitute a drive for which a directory on the drive is the target  of a previous substitute.</para>
        /// </summary>
        public const int ERROR_IS_SUBST_TARGET = 149;

        /// <summary>
        /// <para>// MessageId: ERROR_SYSTEM_TRACE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  System trace information was not specified in your CONFIG.SYS file, or tracing is disallowed.</para>
        /// </summary>
        public const int ERROR_SYSTEM_TRACE = 150;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_EVENT_COUNT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The number of specified semaphore events for DosMuxSemWait is not correct.</para>
        /// </summary>
        public const int ERROR_INVALID_EVENT_COUNT = 151;

        /// <summary>
        /// <para>// MessageId: ERROR_TOO_MANY_MUXWAITERS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  DosMuxSemWait did not execute; too many semaphores are already set.</para>
        /// </summary>
        public const int ERROR_TOO_MANY_MUXWAITERS = 152;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_LIST_FORMAT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The DosMuxSemWait list is not correct.</para>
        /// </summary>
        public const int ERROR_INVALID_LIST_FORMAT = 153;

        /// <summary>
        /// <para>// MessageId: ERROR_LABEL_TOO_LONG</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The volume label you entered exceeds the label character limit of the target file system.</para>
        /// </summary>
        public const int ERROR_LABEL_TOO_LONG = 154;

        /// <summary>
        /// <para>// MessageId: ERROR_TOO_MANY_TCBS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Cannot create another thread.</para>
        /// </summary>
        public const int ERROR_TOO_MANY_TCBS = 155;

        /// <summary>
        /// <para>// MessageId: ERROR_SIGNAL_REFUSED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The recipient process has refused the signal.</para>
        /// </summary>
        public const int ERROR_SIGNAL_REFUSED = 156;

        /// <summary>
        /// <para>// MessageId: ERROR_DISCARDED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The segment is already discarded and cannot be locked.</para>
        /// </summary>
        public const int ERROR_DISCARDED = 157;

        /// <summary>
        /// <para>// MessageId: ERROR_NOT_LOCKED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The segment is already unlocked.</para>
        /// </summary>
        public const int ERROR_NOT_LOCKED = 158;

        /// <summary>
        /// <para>// MessageId: ERROR_BAD_THREADID_ADDR</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The address for the thread ID is not correct.</para>
        /// </summary>
        public const int ERROR_BAD_THREADID_ADDR = 159;

        /// <summary>
        /// <para>// MessageId: ERROR_BAD_ARGUMENTS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  One or more arguments are not correct.</para>
        /// </summary>
        public const int ERROR_BAD_ARGUMENTS = 160;

        /// <summary>
        /// <para>// MessageId: ERROR_BAD_PATHNAME</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified path is invalid.</para>
        /// </summary>
        public const int ERROR_BAD_PATHNAME = 161;

        /// <summary>
        /// <para>// MessageId: ERROR_SIGNAL_PENDING</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A signal is already pending.</para>
        /// </summary>
        public const int ERROR_SIGNAL_PENDING = 162;

        /// <summary>
        /// <para>// MessageId: ERROR_MAX_THRDS_REACHED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  No more threads can be created in the system.</para>
        /// </summary>
        public const int ERROR_MAX_THRDS_REACHED = 164;

        /// <summary>
        /// <para>// MessageId: ERROR_LOCK_FAILED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Unable to lock a region of a file.</para>
        /// </summary>
        public const int ERROR_LOCK_FAILED = 167;

        /// <summary>
        /// <para>// MessageId: ERROR_BUSY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The requested resource is in use.</para>
        /// </summary>
        public const int ERROR_BUSY = 170; // dderror

        /// <summary>
        /// <para>// MessageId: ERROR_CANCEL_VIOLATION</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A lock request was not outstanding for the supplied cancel region.</para>
        /// </summary>
        public const int ERROR_CANCEL_VIOLATION = 173;

        /// <summary>
        /// <para>// MessageId: ERROR_ATOMIC_LOCKS_NOT_SUPPORTED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The file system does not support atomic changes to the lock type.</para>
        /// </summary>
        public const int ERROR_ATOMIC_LOCKS_NOT_SUPPORTED = 174;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_SEGMENT_NUMBER</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The system detected a segment number that was not correct.</para>
        /// </summary>
        public const int ERROR_INVALID_SEGMENT_NUMBER = 180;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_ORDINAL</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The operating system cannot run %1.</para>
        /// </summary>
        public const int ERROR_INVALID_ORDINAL = 182;

        /// <summary>
        /// <para>// MessageId: ERROR_ALREADY_EXISTS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Cannot create a file when that file already exists.</para>
        /// </summary>
        public const int ERROR_ALREADY_EXISTS = 183;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_FLAG_NUMBER</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The flag passed is not correct.</para>
        /// </summary>
        public const int ERROR_INVALID_FLAG_NUMBER = 186;

        /// <summary>
        /// <para>// MessageId: ERROR_SEM_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified system semaphore name was not found.</para>
        /// </summary>
        public const int ERROR_SEM_NOT_FOUND = 187;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_STARTING_CODESEG</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The operating system cannot run %1.</para>
        /// </summary>
        public const int ERROR_INVALID_STARTING_CODESEG = 188;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_STACKSEG</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The operating system cannot run %1.</para>
        /// </summary>
        public const int ERROR_INVALID_STACKSEG = 189;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_MODULETYPE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The operating system cannot run %1.</para>
        /// </summary>
        public const int ERROR_INVALID_MODULETYPE = 190;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_EXE_SIGNATURE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Cannot run %1 in Win32 mode.</para>
        /// </summary>
        public const int ERROR_INVALID_EXE_SIGNATURE = 191;

        /// <summary>
        /// <para>// MessageId: ERROR_EXE_MARKED_INVALID</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The operating system cannot run %1.</para>
        /// </summary>
        public const int ERROR_EXE_MARKED_INVALID = 192;

        /// <summary>
        /// <para>// MessageId: ERROR_BAD_EXE_FORMAT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  %1 is not a valid Win32 application.</para>
        /// </summary>
        public const int ERROR_BAD_EXE_FORMAT = 193;

        /// <summary>
        /// <para>// MessageId: ERROR_ITERATED_DATA_EXCEEDS_64k</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The operating system cannot run %1.</para>
        /// </summary>
        public const int ERROR_ITERATED_DATA_EXCEEDS_64k = 194;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_MINALLOCSIZE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The operating system cannot run %1.</para>
        /// </summary>
        public const int ERROR_INVALID_MINALLOCSIZE = 195;

        /// <summary>
        /// <para>// MessageId: ERROR_DYNLINK_FROM_INVALID_RING</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The operating system cannot run this application program.</para>
        /// </summary>
        public const int ERROR_DYNLINK_FROM_INVALID_RING = 196;

        /// <summary>
        /// <para>// MessageId: ERROR_IOPL_NOT_ENABLED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The operating system is not presently configured to run this application.</para>
        /// </summary>
        public const int ERROR_IOPL_NOT_ENABLED = 197;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_SEGDPL</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The operating system cannot run %1.</para>
        /// </summary>
        public const int ERROR_INVALID_SEGDPL = 198;

        /// <summary>
        /// <para>// MessageId: ERROR_AUTODATASEG_EXCEEDS_64k</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The operating system cannot run this application program.</para>
        /// </summary>
        public const int ERROR_AUTODATASEG_EXCEEDS_64k = 199;

        /// <summary>
        /// <para>// MessageId: ERROR_RING2SEG_MUST_BE_MOVABLE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The code segment cannot be greater than or equal to 64K.</para>
        /// </summary>
        public const int ERROR_RING2SEG_MUST_BE_MOVABLE = 200;

        /// <summary>
        /// <para>// MessageId: ERROR_RELOC_CHAIN_XEEDS_SEGLIM</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The operating system cannot run %1.</para>
        /// </summary>
        public const int ERROR_RELOC_CHAIN_XEEDS_SEGLIM = 201;

        /// <summary>
        /// <para>// MessageId: ERROR_INFLOOP_IN_RELOC_CHAIN</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The operating system cannot run %1.</para>
        /// </summary>
        public const int ERROR_INFLOOP_IN_RELOC_CHAIN = 202;

        /// <summary>
        /// <para>// MessageId: ERROR_ENVVAR_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The system could not find the environment option that was entered.</para>
        /// </summary>
        public const int ERROR_ENVVAR_NOT_FOUND = 203;

        /// <summary>
        /// <para>// MessageId: ERROR_NO_SIGNAL_SENT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  No process in the command subtree has a signal handler.</para>
        /// </summary>
        public const int ERROR_NO_SIGNAL_SENT = 205;

        /// <summary>
        /// <para>// MessageId: ERROR_FILENAME_EXCED_RANGE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The filename or extension is too long.</para>
        /// </summary>
        public const int ERROR_FILENAME_EXCED_RANGE = 206;

        /// <summary>
        /// <para>// MessageId: ERROR_RING2_STACK_IN_USE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The ring 2 stack is in use.</para>
        /// </summary>
        public const int ERROR_RING2_STACK_IN_USE = 207;

        /// <summary>
        /// <para>// MessageId: ERROR_META_EXPANSION_TOO_LONG</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The global filename characters, * or ?, are entered incorrectly or too many global filename  characters are specified.</para>
        /// </summary>
        public const int ERROR_META_EXPANSION_TOO_LONG = 208;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_SIGNAL_NUMBER</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The signal being posted is not correct.</para>
        /// </summary>
        public const int ERROR_INVALID_SIGNAL_NUMBER = 209;

        /// <summary>
        /// <para>// MessageId: ERROR_THREAD_1_INACTIVE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The signal handler cannot be set.</para>
        /// </summary>
        public const int ERROR_THREAD_1_INACTIVE = 210;

        /// <summary>
        /// <para>// MessageId: ERROR_LOCKED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The segment is locked and cannot be reallocated.</para>
        /// </summary>
        public const int ERROR_LOCKED = 212;

        /// <summary>
        /// <para>// MessageId: ERROR_TOO_MANY_MODULES</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Too many dynamic-link modules are attached to this program or dynamic-link module.</para>
        /// </summary>
        public const int ERROR_TOO_MANY_MODULES = 214;

        /// <summary>
        /// <para>// MessageId: ERROR_NESTING_NOT_ALLOWED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Cannot nest calls to LoadModule.</para>
        /// </summary>
        public const int ERROR_NESTING_NOT_ALLOWED = 215;

        /// <summary>
        /// <para>// MessageId: ERROR_EXE_MACHINE_TYPE_MISMATCH</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The image file %1 is valid, but is for a machine type other than the current machine.</para>
        /// </summary>
        public const int ERROR_EXE_MACHINE_TYPE_MISMATCH = 216;

        /// <summary>
        /// <para>// MessageId: ERROR_EXE_CANNOT_MODIFY_SIGNED_BINARY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The image file %1 is signed, unable to modify.</para>
        /// </summary>
        public const int ERROR_EXE_CANNOT_MODIFY_SIGNED_BINARY = 217;

        /// <summary>
        /// <para>// MessageId: ERROR_EXE_CANNOT_MODIFY_STRONG_SIGNED_BINARY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The image file %1 is strong signed, unable to modify.</para>
        /// </summary>
        public const int ERROR_EXE_CANNOT_MODIFY_STRONG_SIGNED_BINARY = 218;

        /// <summary>
        /// <para>// MessageId: ERROR_BAD_PIPE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The pipe state is invalid.</para>
        /// </summary>
        public const int ERROR_BAD_PIPE = 230;

        /// <summary>
        /// <para>// MessageId: ERROR_PIPE_BUSY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  All pipe instances are busy.</para>
        /// </summary>
        public const int ERROR_PIPE_BUSY = 231;

        /// <summary>
        /// <para>// MessageId: ERROR_NO_DATA</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The pipe is being closed.</para>
        /// </summary>
        public const int ERROR_NO_DATA = 232;

        /// <summary>
        /// <para>// MessageId: ERROR_PIPE_NOT_CONNECTED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  No process is on the other end of the pipe.</para>
        /// </summary>
        public const int ERROR_PIPE_NOT_CONNECTED = 233;

        /// <summary>
        /// <para>// MessageId: ERROR_MORE_DATA</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  More data is available.</para>
        /// </summary>
        public const int ERROR_MORE_DATA = 234; // dderror

        /// <summary>
        /// <para>// MessageId: ERROR_VC_DISCONNECTED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The session was canceled.</para>
        /// </summary>
        public const int ERROR_VC_DISCONNECTED = 240;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_EA_NAME</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified extended attribute name was invalid.</para>
        /// </summary>
        public const int ERROR_INVALID_EA_NAME = 254;

        /// <summary>
        /// <para>// MessageId: ERROR_EA_LIST_INCONSISTENT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The extended attributes are inconsistent.</para>
        /// </summary>
        public const int ERROR_EA_LIST_INCONSISTENT = 255;

        /// <summary>
        /// <para>// MessageId: WAIT_TIMEOUT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The wait operation timed out.</para>
        /// </summary>
        public const int WAIT_TIMEOUT = 258; // dderror

        /// <summary>
        /// <para>// MessageId: ERROR_NO_MORE_ITEMS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  No more data is available.</para>
        /// </summary>
        public const int ERROR_NO_MORE_ITEMS = 259;

        /// <summary>
        /// <para>// MessageId: ERROR_CANNOT_COPY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The copy functions cannot be used.</para>
        /// </summary>
        public const int ERROR_CANNOT_COPY = 266;

        /// <summary>
        /// <para>// MessageId: ERROR_DIRECTORY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The directory name is invalid.</para>
        /// </summary>
        public const int ERROR_DIRECTORY = 267;

        /// <summary>
        /// <para>// MessageId: ERROR_EAS_DIDNT_FIT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The extended attributes did not fit in the buffer.</para>
        /// </summary>
        public const int ERROR_EAS_DIDNT_FIT = 275;

        /// <summary>
        /// <para>// MessageId: ERROR_EA_FILE_CORRUPT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The extended attribute file on the mounted file system is corrupt.</para>
        /// </summary>
        public const int ERROR_EA_FILE_CORRUPT = 276;

        /// <summary>
        /// <para>// MessageId: ERROR_EA_TABLE_FULL</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The extended attribute table file is full.</para>
        /// </summary>
        public const int ERROR_EA_TABLE_FULL = 277;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_EA_HANDLE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified extended attribute handle is invalid.</para>
        /// </summary>
        public const int ERROR_INVALID_EA_HANDLE = 278;

        /// <summary>
        /// <para>// MessageId: ERROR_EAS_NOT_SUPPORTED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The mounted file system does not support extended attributes.</para>
        /// </summary>
        public const int ERROR_EAS_NOT_SUPPORTED = 282;

        /// <summary>
        /// <para>// MessageId: ERROR_NOT_OWNER</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Attempt to release mutex not owned by caller.</para>
        /// </summary>
        public const int ERROR_NOT_OWNER = 288;

        /// <summary>
        /// <para>// MessageId: ERROR_TOO_MANY_POSTS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Too many posts were made to a semaphore.</para>
        /// </summary>
        public const int ERROR_TOO_MANY_POSTS = 298;

        /// <summary>
        /// <para>// MessageId: ERROR_PARTIAL_COPY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Only part of a ReadProcessMemory or WriteProcessMemory request was completed.</para>
        /// </summary>
        public const int ERROR_PARTIAL_COPY = 299;

        /// <summary>
        /// <para>// MessageId: ERROR_OPLOCK_NOT_GRANTED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The oplock request is denied.</para>
        /// </summary>
        public const int ERROR_OPLOCK_NOT_GRANTED = 300;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_OPLOCK_PROTOCOL</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An invalid oplock acknowledgment was received by the system.</para>
        /// </summary>
        public const int ERROR_INVALID_OPLOCK_PROTOCOL = 301;

        /// <summary>
        /// <para>// MessageId: ERROR_DISK_TOO_FRAGMENTED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The volume is too fragmented to complete this operation.</para>
        /// </summary>
        public const int ERROR_DISK_TOO_FRAGMENTED = 302;

        /// <summary>
        /// <para>// MessageId: ERROR_DELETE_PENDING</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The file cannot be opened because it is in the process of being deleted.</para>
        /// </summary>
        public const int ERROR_DELETE_PENDING = 303;

        /// <summary>
        /// <para>// MessageId: ERROR_MR_MID_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The system cannot find message text for message number 0x%1 in the message file for %2.</para>
        /// </summary>
        public const int ERROR_MR_MID_NOT_FOUND = 317;

        /// <summary>
        /// <para>// MessageId: ERROR_SCOPE_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The scope specified was not found.</para>
        /// </summary>
        public const int ERROR_SCOPE_NOT_FOUND = 318;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_ADDRESS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Attempt to access invalid address.</para>
        /// </summary>
        public const int ERROR_INVALID_ADDRESS = 487;

        /// <summary>
        /// <para>// MessageId: ERROR_ARITHMETIC_OVERFLOW</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Arithmetic result exceeded 32 bits.</para>
        /// </summary>
        public const int ERROR_ARITHMETIC_OVERFLOW = 534;

        /// <summary>
        /// <para>// MessageId: ERROR_PIPE_CONNECTED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  There is a process on other end of the pipe.</para>
        /// </summary>
        public const int ERROR_PIPE_CONNECTED = 535;

        /// <summary>
        /// <para>// MessageId: ERROR_PIPE_LISTENING</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Waiting for a process to open the other end of the pipe.</para>
        /// </summary>
        public const int ERROR_PIPE_LISTENING = 536;

        /// <summary>
        /// <para>// MessageId: ERROR_EA_ACCESS_DENIED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Access to the extended attribute was denied.</para>
        /// </summary>
        public const int ERROR_EA_ACCESS_DENIED = 994;

        /// <summary>
        /// <para>// MessageId: ERROR_OPERATION_ABORTED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The I/O operation has been aborted because of either a thread exit or an application request.</para>
        /// </summary>
        public const int ERROR_OPERATION_ABORTED = 995;

        /// <summary>
        /// <para>// MessageId: ERROR_IO_INCOMPLETE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Overlapped I/O event is not in a signaled state.</para>
        /// </summary>
        public const int ERROR_IO_INCOMPLETE = 996;

        /// <summary>
        /// <para>// MessageId: ERROR_IO_PENDING</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Overlapped I/O operation is in progress.</para>
        /// </summary>
        public const int ERROR_IO_PENDING = 997; // dderror

        /// <summary>
        /// <para>// MessageId: ERROR_NOACCESS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Invalid access to memory location.</para>
        /// </summary>
        public const int ERROR_NOACCESS = 998;

        /// <summary>
        /// <para>// MessageId: ERROR_SWAPERROR</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Error performing inpage operation.</para>
        /// </summary>
        public const int ERROR_SWAPERROR = 999;

        /// <summary>
        /// <para>// MessageId: ERROR_STACK_OVERFLOW</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Recursion too deep; the stack overflowed.</para>
        /// </summary>
        public const int ERROR_STACK_OVERFLOW = 1001;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_MESSAGE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The window cannot act on the sent message.</para>
        /// </summary>
        public const int ERROR_INVALID_MESSAGE = 1002;

        /// <summary>
        /// <para>// MessageId: ERROR_CAN_NOT_COMPLETE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Cannot complete this function.</para>
        /// </summary>
        public const int ERROR_CAN_NOT_COMPLETE = 1003;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_FLAGS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Invalid flags.</para>
        /// </summary>
        public const int ERROR_INVALID_FLAGS = 1004;

        /// <summary>
        /// <para>// MessageId: ERROR_UNRECOGNIZED_VOLUME</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The volume does not contain a recognized file system.</para>
        /// <para>//  Please make sure that all required file system drivers are loaded and that the volume is not  corrupted.</para>
        /// </summary>
        public const int ERROR_UNRECOGNIZED_VOLUME = 1005;

        /// <summary>
        /// <para>// MessageId: ERROR_FILE_INVALID</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The volume for a file has been externally altered so that the opened file is no longer valid.</para>
        /// </summary>
        public const int ERROR_FILE_INVALID = 1006;

        /// <summary>
        /// <para>// MessageId: ERROR_FULLSCREEN_MODE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The requested operation cannot be performed in full-screen mode.</para>
        /// </summary>
        public const int ERROR_FULLSCREEN_MODE = 1007;

        /// <summary>
        /// <para>// MessageId: ERROR_NO_TOKEN</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An attempt was made to reference a token that does not exist.</para>
        /// </summary>
        public const int ERROR_NO_TOKEN = 1008;

        /// <summary>
        /// <para>// MessageId: ERROR_BADDB</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The configuration registry database is corrupt.</para>
        /// </summary>
        public const int ERROR_BADDB = 1009;

        /// <summary>
        /// <para>// MessageId: ERROR_BADKEY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The configuration registry key is invalid.</para>
        /// </summary>
        public const int ERROR_BADKEY = 1010;

        /// <summary>
        /// <para>// MessageId: ERROR_CANTOPEN</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The configuration registry key could not be opened.</para>
        /// </summary>
        public const int ERROR_CANTOPEN = 1011;

        /// <summary>
        /// <para>// MessageId: ERROR_CANTREAD</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The configuration registry key could not be read.</para>
        /// </summary>
        public const int ERROR_CANTREAD = 1012;

        /// <summary>
        /// <para>// MessageId: ERROR_CANTWRITE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The configuration registry key could not be written.</para>
        /// </summary>
        public const int ERROR_CANTWRITE = 1013;

        /// <summary>
        /// <para>// MessageId: ERROR_REGISTRY_RECOVERED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  One of the files in the registry database had to be recovered by use of a log or alternate copy.  The recovery was successful.</para>
        /// </summary>
        public const int ERROR_REGISTRY_RECOVERED = 1014;

        /// <summary>
        /// <para>// MessageId: ERROR_REGISTRY_CORRUPT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The registry is corrupted. The structure of one of the files containing registry data is  corrupted, or the system's memory image of the file is corrupted, or the file could not be recovered  because the alternate copy or log was absent or corrupted.</para>
        /// </summary>
        public const int ERROR_REGISTRY_CORRUPT = 1015;

        /// <summary>
        /// <para>// MessageId: ERROR_REGISTRY_IO_FAILED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An I/O operation initiated by the registry failed unrecoverably. The registry could not read in,  or write out, or flush, one of the files that contain the system's image of the registry.</para>
        /// </summary>
        public const int ERROR_REGISTRY_IO_FAILED = 1016;

        /// <summary>
        /// <para>// MessageId: ERROR_NOT_REGISTRY_FILE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The system has attempted to load or restore a file into the registry, but the specified file is  not in a registry file format.</para>
        /// </summary>
        public const int ERROR_NOT_REGISTRY_FILE = 1017;

        /// <summary>
        /// <para>// MessageId: ERROR_KEY_DELETED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Illegal operation attempted on a registry key that has been marked for deletion.</para>
        /// </summary>
        public const int ERROR_KEY_DELETED = 1018;

        /// <summary>
        /// <para>// MessageId: ERROR_NO_LOG_SPACE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  System could not allocate the required space in a registry log.</para>
        /// </summary>
        public const int ERROR_NO_LOG_SPACE = 1019;

        /// <summary>
        /// <para>// MessageId: ERROR_KEY_HAS_CHILDREN</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Cannot create a symbolic link in a registry key that already has subkeys or values.</para>
        /// </summary>
        public const int ERROR_KEY_HAS_CHILDREN = 1020;

        /// <summary>
        /// <para>// MessageId: ERROR_CHILD_MUST_BE_VOLATILE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Cannot create a stable subkey under a volatile parent key.</para>
        /// </summary>
        public const int ERROR_CHILD_MUST_BE_VOLATILE = 1021;

        /// <summary>
        /// <para>// MessageId: ERROR_NOTIFY_ENUM_DIR</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A notify change request is being completed and the information is not being returned in the  caller's buffer. The caller now needs to enumerate the files to find the changes.</para>
        /// </summary>
        public const int ERROR_NOTIFY_ENUM_DIR = 1022;

        /// <summary>
        /// <para>// MessageId: ERROR_DEPENDENT_SERVICES_RUNNING</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A stop control has been sent to a service that other running services are dependent on.</para>
        /// </summary>
        public const int ERROR_DEPENDENT_SERVICES_RUNNING = 1051;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_SERVICE_CONTROL</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The requested control is not valid for this service.</para>
        /// </summary>
        public const int ERROR_INVALID_SERVICE_CONTROL = 1052;

        /// <summary>
        /// <para>// MessageId: ERROR_SERVICE_REQUEST_TIMEOUT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The service did not respond to the start or control request in a timely fashion.</para>
        /// </summary>
        public const int ERROR_SERVICE_REQUEST_TIMEOUT = 1053;

        /// <summary>
        /// <para>// MessageId: ERROR_SERVICE_NO_THREAD</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A thread could not be created for the service.</para>
        /// </summary>
        public const int ERROR_SERVICE_NO_THREAD = 1054;

        /// <summary>
        /// <para>// MessageId: ERROR_SERVICE_DATABASE_LOCKED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The service database is locked.</para>
        /// </summary>
        public const int ERROR_SERVICE_DATABASE_LOCKED = 1055;

        /// <summary>
        /// <para>// MessageId: ERROR_SERVICE_ALREADY_RUNNING</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An instance of the service is already running.</para>
        /// </summary>
        public const int ERROR_SERVICE_ALREADY_RUNNING = 1056;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_SERVICE_ACCOUNT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The account name is invalid or does not exist, or the password is invalid for the account name  specified.</para>
        /// </summary>
        public const int ERROR_INVALID_SERVICE_ACCOUNT = 1057;

        /// <summary>
        /// <para>// MessageId: ERROR_SERVICE_DISABLED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The service cannot be started, either because it is disabled or because it has no enabled devices  associated with it.</para>
        /// </summary>
        public const int ERROR_SERVICE_DISABLED = 1058;

        /// <summary>
        /// <para>// MessageId: ERROR_CIRCULAR_DEPENDENCY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Circular service dependency was specified.</para>
        /// </summary>
        public const int ERROR_CIRCULAR_DEPENDENCY = 1059;

        /// <summary>
        /// <para>// MessageId: ERROR_SERVICE_DOES_NOT_EXIST</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified service does not exist as an installed service.</para>
        /// </summary>
        public const int ERROR_SERVICE_DOES_NOT_EXIST = 1060;

        /// <summary>
        /// <para>// MessageId: ERROR_SERVICE_CANNOT_ACCEPT_CTRL</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The service cannot accept control messages at this time.</para>
        /// </summary>
        public const int ERROR_SERVICE_CANNOT_ACCEPT_CTRL = 1061;

        /// <summary>
        /// <para>// MessageId: ERROR_SERVICE_NOT_ACTIVE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The service has not been started.</para>
        /// </summary>
        public const int ERROR_SERVICE_NOT_ACTIVE = 1062;

        /// <summary>
        /// <para>// MessageId: ERROR_FAILED_SERVICE_CONTROLLER_CONNECT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The service process could not connect to the service controller.</para>
        /// </summary>
        public const int ERROR_FAILED_SERVICE_CONTROLLER_CONNECT = 1063;

        /// <summary>
        /// <para>// MessageId: ERROR_EXCEPTION_IN_SERVICE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An exception occurred in the service when handling the control request.</para>
        /// </summary>
        public const int ERROR_EXCEPTION_IN_SERVICE = 1064;

        /// <summary>
        /// <para>// MessageId: ERROR_DATABASE_DOES_NOT_EXIST</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The database specified does not exist.</para>
        /// </summary>
        public const int ERROR_DATABASE_DOES_NOT_EXIST = 1065;

        /// <summary>
        /// <para>// MessageId: ERROR_SERVICE_SPECIFIC_ERROR</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The service has returned a service-specific error code.</para>
        /// </summary>
        public const int ERROR_SERVICE_SPECIFIC_ERROR = 1066;

        /// <summary>
        /// <para>// MessageId: ERROR_PROCESS_ABORTED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The process terminated unexpectedly.</para>
        /// </summary>
        public const int ERROR_PROCESS_ABORTED = 1067;

        /// <summary>
        /// <para>// MessageId: ERROR_SERVICE_DEPENDENCY_FAIL</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The dependency service or group failed to start.</para>
        /// </summary>
        public const int ERROR_SERVICE_DEPENDENCY_FAIL = 1068;

        /// <summary>
        /// <para>// MessageId: ERROR_SERVICE_LOGON_FAILED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The service did not start due to a logon failure.</para>
        /// </summary>
        public const int ERROR_SERVICE_LOGON_FAILED = 1069;

        /// <summary>
        /// <para>// MessageId: ERROR_SERVICE_START_HANG</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  After starting, the service hung in a start-pending state.</para>
        /// </summary>
        public const int ERROR_SERVICE_START_HANG = 1070;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_SERVICE_LOCK</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified service database lock is invalid.</para>
        /// </summary>
        public const int ERROR_INVALID_SERVICE_LOCK = 1071;

        /// <summary>
        /// <para>// MessageId: ERROR_SERVICE_MARKED_FOR_DELETE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified service has been marked for deletion.</para>
        /// </summary>
        public const int ERROR_SERVICE_MARKED_FOR_DELETE = 1072;

        /// <summary>
        /// <para>// MessageId: ERROR_SERVICE_EXISTS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified service already exists.</para>
        /// </summary>
        public const int ERROR_SERVICE_EXISTS = 1073;

        /// <summary>
        /// <para>// MessageId: ERROR_ALREADY_RUNNING_LKG</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The system is currently running with the last-known-good configuration.</para>
        /// </summary>
        public const int ERROR_ALREADY_RUNNING_LKG = 1074;

        /// <summary>
        /// <para>// MessageId: ERROR_SERVICE_DEPENDENCY_DELETED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The dependency service does not exist or has been marked for deletion.</para>
        /// </summary>
        public const int ERROR_SERVICE_DEPENDENCY_DELETED = 1075;

        /// <summary>
        /// <para>// MessageId: ERROR_BOOT_ALREADY_ACCEPTED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The current boot has already been accepted for use as the last-known-good control set.</para>
        /// </summary>
        public const int ERROR_BOOT_ALREADY_ACCEPTED = 1076;

        /// <summary>
        /// <para>// MessageId: ERROR_SERVICE_NEVER_STARTED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  No attempts to start the service have been made since the last boot.</para>
        /// </summary>
        public const int ERROR_SERVICE_NEVER_STARTED = 1077;

        /// <summary>
        /// <para>// MessageId: ERROR_DUPLICATE_SERVICE_NAME</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The name is already in use as either a service name or a service display name.</para>
        /// </summary>
        public const int ERROR_DUPLICATE_SERVICE_NAME = 1078;

        /// <summary>
        /// <para>// MessageId: ERROR_DIFFERENT_SERVICE_ACCOUNT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The account specified for this service is different from the account specified for other services  running in the same process.</para>
        /// </summary>
        public const int ERROR_DIFFERENT_SERVICE_ACCOUNT = 1079;

        /// <summary>
        /// <para>// MessageId: ERROR_CANNOT_DETECT_DRIVER_FAILURE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Failure actions can only be set for Win32 services, not for drivers.</para>
        /// </summary>
        public const int ERROR_CANNOT_DETECT_DRIVER_FAILURE = 1080;

        /// <summary>
        /// <para>// MessageId: ERROR_CANNOT_DETECT_PROCESS_ABORT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  This service runs in the same process as the service control manager.</para>
        /// <para>//  Therefore, the service control manager cannot take action if this service's process terminates  unexpectedly.</para>
        /// </summary>
        public const int ERROR_CANNOT_DETECT_PROCESS_ABORT = 1081;

        /// <summary>
        /// <para>// MessageId: ERROR_NO_RECOVERY_PROGRAM</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  No recovery program has been configured for this service.</para>
        /// </summary>
        public const int ERROR_NO_RECOVERY_PROGRAM = 1082;

        /// <summary>
        /// <para>// MessageId: ERROR_SERVICE_NOT_IN_EXE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The executable program that this service is configured to run in does not implement the service.</para>
        /// </summary>
        public const int ERROR_SERVICE_NOT_IN_EXE = 1083;

        /// <summary>
        /// <para>// MessageId: ERROR_NOT_SAFEBOOT_SERVICE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  This service cannot be started in Safe Mode</para>
        /// </summary>
        public const int ERROR_NOT_SAFEBOOT_SERVICE = 1084;

        /// <summary>
        /// <para>// MessageId: ERROR_END_OF_MEDIA</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The physical end of the tape has been reached.</para>
        /// </summary>
        public const int ERROR_END_OF_MEDIA = 1100;

        /// <summary>
        /// <para>// MessageId: ERROR_FILEMARK_DETECTED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A tape access reached a filemark.</para>
        /// </summary>
        public const int ERROR_FILEMARK_DETECTED = 1101;

        /// <summary>
        /// <para>// MessageId: ERROR_BEGINNING_OF_MEDIA</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The beginning of the tape or a partition was encountered.</para>
        /// </summary>
        public const int ERROR_BEGINNING_OF_MEDIA = 1102;

        /// <summary>
        /// <para>// MessageId: ERROR_SETMARK_DETECTED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A tape access reached the end of a set of files.</para>
        /// </summary>
        public const int ERROR_SETMARK_DETECTED = 1103;

        /// <summary>
        /// <para>// MessageId: ERROR_NO_DATA_DETECTED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  No more data is on the tape.</para>
        /// </summary>
        public const int ERROR_NO_DATA_DETECTED = 1104;

        /// <summary>
        /// <para>// MessageId: ERROR_PARTITION_FAILURE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Tape could not be partitioned.</para>
        /// </summary>
        public const int ERROR_PARTITION_FAILURE = 1105;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_BLOCK_LENGTH</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  When accessing a new tape of a multivolume partition, the current block size is incorrect.</para>
        /// </summary>
        public const int ERROR_INVALID_BLOCK_LENGTH = 1106;

        /// <summary>
        /// <para>// MessageId: ERROR_DEVICE_NOT_PARTITIONED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Tape partition information could not be found when loading a tape.</para>
        /// </summary>
        public const int ERROR_DEVICE_NOT_PARTITIONED = 1107;

        /// <summary>
        /// <para>// MessageId: ERROR_UNABLE_TO_LOCK_MEDIA</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Unable to lock the media eject mechanism.</para>
        /// </summary>
        public const int ERROR_UNABLE_TO_LOCK_MEDIA = 1108;

        /// <summary>
        /// <para>// MessageId: ERROR_UNABLE_TO_UNLOAD_MEDIA</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Unable to unload the media.</para>
        /// </summary>
        public const int ERROR_UNABLE_TO_UNLOAD_MEDIA = 1109;

        /// <summary>
        /// <para>// MessageId: ERROR_MEDIA_CHANGED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The media in the drive may have changed.</para>
        /// </summary>
        public const int ERROR_MEDIA_CHANGED = 1110;

        /// <summary>
        /// <para>// MessageId: ERROR_BUS_RESET</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The I/O bus was reset.</para>
        /// </summary>
        public const int ERROR_BUS_RESET = 1111;

        /// <summary>
        /// <para>// MessageId: ERROR_NO_MEDIA_IN_DRIVE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  No media in drive.</para>
        /// </summary>
        public const int ERROR_NO_MEDIA_IN_DRIVE = 1112;

        /// <summary>
        /// <para>// MessageId: ERROR_NO_UNICODE_TRANSLATION</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  No mapping for the Unicode character exists in the target multi-byte code page.</para>
        /// </summary>
        public const int ERROR_NO_UNICODE_TRANSLATION = 1113;

        /// <summary>
        /// <para>// MessageId: ERROR_DLL_INIT_FAILED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A dynamic link library (DLL) initialization routine failed.</para>
        /// </summary>
        public const int ERROR_DLL_INIT_FAILED = 1114;

        /// <summary>
        /// <para>// MessageId: ERROR_SHUTDOWN_IN_PROGRESS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A system shutdown is in progress.</para>
        /// </summary>
        public const int ERROR_SHUTDOWN_IN_PROGRESS = 1115;

        /// <summary>
        /// <para>// MessageId: ERROR_NO_SHUTDOWN_IN_PROGRESS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Unable to abort the system shutdown because no shutdown was in progress.</para>
        /// </summary>
        public const int ERROR_NO_SHUTDOWN_IN_PROGRESS = 1116;

        /// <summary>
        /// <para>// MessageId: ERROR_IO_DEVICE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The request could not be performed because of an I/O device error.</para>
        /// </summary>
        public const int ERROR_IO_DEVICE = 1117;

        /// <summary>
        /// <para>// MessageId: ERROR_SERIAL_NO_DEVICE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  No serial device was successfully initialized. The serial driver will unload.</para>
        /// </summary>
        public const int ERROR_SERIAL_NO_DEVICE = 1118;

        /// <summary>
        /// <para>// MessageId: ERROR_IRQ_BUSY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Unable to open a device that was sharing an interrupt request (IRQ) with other devices. At least  one other device that uses that IRQ was already opened.</para>
        /// </summary>
        public const int ERROR_IRQ_BUSY = 1119;

        /// <summary>
        /// <para>// MessageId: ERROR_MORE_WRITES</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A serial I/O operation was completed by another write to the serial port.</para>
        /// <para>//  (The IOCTL_SERIAL_XOFF_COUNTER reached zero.)</para>
        /// </summary>
        public const int ERROR_MORE_WRITES = 1120;

        /// <summary>
        /// <para>// MessageId: ERROR_COUNTER_TIMEOUT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A serial I/O operation completed because the timeout period expired.</para>
        /// <para>//  (The IOCTL_SERIAL_XOFF_COUNTER did not reach zero.)</para>
        /// </summary>
        public const int ERROR_COUNTER_TIMEOUT = 1121;

        /// <summary>
        /// <para>// MessageId: ERROR_FLOPPY_ID_MARK_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  No ID address mark was found on the floppy disk.</para>
        /// </summary>
        public const int ERROR_FLOPPY_ID_MARK_NOT_FOUND = 1122;

        /// <summary>
        /// <para>// MessageId: ERROR_FLOPPY_WRONG_CYLINDER</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Mismatch between the floppy disk sector ID field and the floppy disk controller track address.</para>
        /// </summary>
        public const int ERROR_FLOPPY_WRONG_CYLINDER = 1123;

        /// <summary>
        /// <para>// MessageId: ERROR_FLOPPY_UNKNOWN_ERROR</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The floppy disk controller reported an error that is not recognized by the floppy disk driver.</para>
        /// </summary>
        public const int ERROR_FLOPPY_UNKNOWN_ERROR = 1124;

        /// <summary>
        /// <para>// MessageId: ERROR_FLOPPY_BAD_REGISTERS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The floppy disk controller returned inconsistent results in its registers.</para>
        /// </summary>
        public const int ERROR_FLOPPY_BAD_REGISTERS = 1125;

        /// <summary>
        /// <para>// MessageId: ERROR_DISK_RECALIBRATE_FAILED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  While accessing the hard disk, a recalibrate operation failed, even after retries.</para>
        /// </summary>
        public const int ERROR_DISK_RECALIBRATE_FAILED = 1126;

        /// <summary>
        /// <para>// MessageId: ERROR_DISK_OPERATION_FAILED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  While accessing the hard disk, a disk operation failed even after retries.</para>
        /// </summary>
        public const int ERROR_DISK_OPERATION_FAILED = 1127;

        /// <summary>
        /// <para>// MessageId: ERROR_DISK_RESET_FAILED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  While accessing the hard disk, a disk controller reset was needed, but even that failed.</para>
        /// </summary>
        public const int ERROR_DISK_RESET_FAILED = 1128;

        /// <summary>
        /// <para>// MessageId: ERROR_EOM_OVERFLOW</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Physical end of tape encountered.</para>
        /// </summary>
        public const int ERROR_EOM_OVERFLOW = 1129;

        /// <summary>
        /// <para>// MessageId: ERROR_NOT_ENOUGH_SERVER_MEMORY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Not enough server storage is available to process this command.</para>
        /// </summary>
        public const int ERROR_NOT_ENOUGH_SERVER_MEMORY = 1130;

        /// <summary>
        /// <para>// MessageId: ERROR_POSSIBLE_DEADLOCK</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A potential deadlock condition has been detected.</para>
        /// </summary>
        public const int ERROR_POSSIBLE_DEADLOCK = 1131;

        /// <summary>
        /// <para>// MessageId: ERROR_MAPPED_ALIGNMENT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The base address or the file offset specified does not have the proper alignment.</para>
        /// </summary>
        public const int ERROR_MAPPED_ALIGNMENT = 1132;

        /// <summary>
        /// <para>// MessageId: ERROR_SET_POWER_STATE_VETOED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An attempt to change the system power state was vetoed by another application or driver.</para>
        /// </summary>
        public const int ERROR_SET_POWER_STATE_VETOED = 1140;

        /// <summary>
        /// <para>// MessageId: ERROR_SET_POWER_STATE_FAILED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The system BIOS failed an attempt to change the system power state.</para>
        /// </summary>
        public const int ERROR_SET_POWER_STATE_FAILED = 1141;

        /// <summary>
        /// <para>// MessageId: ERROR_TOO_MANY_LINKS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An attempt was made to create more links on a file than the file system supports.</para>
        /// </summary>
        public const int ERROR_TOO_MANY_LINKS = 1142;

        /// <summary>
        /// <para>// MessageId: ERROR_OLD_WIN_VERSION</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified program requires a newer version of Windows.</para>
        /// </summary>
        public const int ERROR_OLD_WIN_VERSION = 1150;

        /// <summary>
        /// <para>// MessageId: ERROR_APP_WRONG_OS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified program is not a Windows or MS-DOS program.</para>
        /// </summary>
        public const int ERROR_APP_WRONG_OS = 1151;

        /// <summary>
        /// <para>// MessageId: ERROR_SINGLE_INSTANCE_APP</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Cannot start more than one instance of the specified program.</para>
        /// </summary>
        public const int ERROR_SINGLE_INSTANCE_APP = 1152;

        /// <summary>
        /// <para>// MessageId: ERROR_RMODE_APP</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified program was written for an earlier version of Windows.</para>
        /// </summary>
        public const int ERROR_RMODE_APP = 1153;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_DLL</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  One of the library files needed to run this application is damaged.</para>
        /// </summary>
        public const int ERROR_INVALID_DLL = 1154;

        /// <summary>
        /// <para>// MessageId: ERROR_NO_ASSOCIATION</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  No application is associated with the specified file for this operation.</para>
        /// </summary>
        public const int ERROR_NO_ASSOCIATION = 1155;

        /// <summary>
        /// <para>// MessageId: ERROR_DDE_FAIL</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An error occurred in sending the command to the application.</para>
        /// </summary>
        public const int ERROR_DDE_FAIL = 1156;

        /// <summary>
        /// <para>// MessageId: ERROR_DLL_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  One of the library files needed to run this application cannot be found.</para>
        /// </summary>
        public const int ERROR_DLL_NOT_FOUND = 1157;

        /// <summary>
        /// <para>// MessageId: ERROR_NO_MORE_USER_HANDLES</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The current process has used all of its system allowance of handles for Window Manager objects.</para>
        /// </summary>
        public const int ERROR_NO_MORE_USER_HANDLES = 1158;

        /// <summary>
        /// <para>// MessageId: ERROR_MESSAGE_SYNC_ONLY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The message can be used only with synchronous operations.</para>
        /// </summary>
        public const int ERROR_MESSAGE_SYNC_ONLY = 1159;

        /// <summary>
        /// <para>// MessageId: ERROR_SOURCE_ELEMENT_EMPTY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The indicated source element has no media.</para>
        /// </summary>
        public const int ERROR_SOURCE_ELEMENT_EMPTY = 1160;

        /// <summary>
        /// <para>// MessageId: ERROR_DESTINATION_ELEMENT_FULL</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The indicated destination element already contains media.</para>
        /// </summary>
        public const int ERROR_DESTINATION_ELEMENT_FULL = 1161;

        /// <summary>
        /// <para>// MessageId: ERROR_ILLEGAL_ELEMENT_ADDRESS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The indicated element does not exist.</para>
        /// </summary>
        public const int ERROR_ILLEGAL_ELEMENT_ADDRESS = 1162;

        /// <summary>
        /// <para>// MessageId: ERROR_MAGAZINE_NOT_PRESENT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The indicated element is part of a magazine that is not present.</para>
        /// </summary>
        public const int ERROR_MAGAZINE_NOT_PRESENT = 1163;

        /// <summary>
        /// <para>// MessageId: ERROR_DEVICE_REINITIALIZATION_NEEDED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The indicated device requires reinitialization due to hardware errors.</para>
        /// </summary>
        public const int ERROR_DEVICE_REINITIALIZATION_NEEDED = 1164; // dderror

        /// <summary>
        /// <para>// MessageId: ERROR_DEVICE_REQUIRES_CLEANING</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The device has indicated that cleaning is required before further operations are attempted.</para>
        /// </summary>
        public const int ERROR_DEVICE_REQUIRES_CLEANING = 1165;

        /// <summary>
        /// <para>// MessageId: ERROR_DEVICE_DOOR_OPEN</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The device has indicated that its door is open.</para>
        /// </summary>
        public const int ERROR_DEVICE_DOOR_OPEN = 1166;

        /// <summary>
        /// <para>// MessageId: ERROR_DEVICE_NOT_CONNECTED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The device is not connected.</para>
        /// </summary>
        public const int ERROR_DEVICE_NOT_CONNECTED = 1167;

        /// <summary>
        /// <para>// MessageId: ERROR_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Element not found.</para>
        /// </summary>
        public const int ERROR_NOT_FOUND = 1168;

        /// <summary>
        /// <para>// MessageId: ERROR_NO_MATCH</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  There was no match for the specified key in the index.</para>
        /// </summary>
        public const int ERROR_NO_MATCH = 1169;

        /// <summary>
        /// <para>// MessageId: ERROR_SET_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The property set specified does not exist on the object.</para>
        /// </summary>
        public const int ERROR_SET_NOT_FOUND = 1170;

        /// <summary>
        /// <para>// MessageId: ERROR_POINT_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The point passed to GetMouseMovePoints is not in the buffer.</para>
        /// </summary>
        public const int ERROR_POINT_NOT_FOUND = 1171;

        /// <summary>
        /// <para>// MessageId: ERROR_NO_TRACKING_SERVICE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The tracking (workstation) service is not running.</para>
        /// </summary>
        public const int ERROR_NO_TRACKING_SERVICE = 1172;

        /// <summary>
        /// <para>// MessageId: ERROR_NO_VOLUME_ID</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The Volume ID could not be found.</para>
        /// </summary>
        public const int ERROR_NO_VOLUME_ID = 1173;

        /// <summary>
        /// <para>// MessageId: ERROR_UNABLE_TO_REMOVE_REPLACED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Unable to remove the file to be replaced.</para>
        /// </summary>
        public const int ERROR_UNABLE_TO_REMOVE_REPLACED = 1175;

        /// <summary>
        /// <para>// MessageId: ERROR_UNABLE_TO_MOVE_REPLACEMENT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Unable to move the replacement file to the file to be replaced. The file to be replaced has  retained its original name.</para>
        /// </summary>
        public const int ERROR_UNABLE_TO_MOVE_REPLACEMENT = 1176;

        /// <summary>
        /// <para>// MessageId: ERROR_UNABLE_TO_MOVE_REPLACEMENT_2</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Unable to move the replacement file to the file to be replaced. The file to be replaced has been  renamed using the backup name.</para>
        /// </summary>
        public const int ERROR_UNABLE_TO_MOVE_REPLACEMENT_2 = 1177;

        /// <summary>
        /// <para>// MessageId: ERROR_JOURNAL_DELETE_IN_PROGRESS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The volume change journal is being deleted.</para>
        /// </summary>
        public const int ERROR_JOURNAL_DELETE_IN_PROGRESS = 1178;

        /// <summary>
        /// <para>// MessageId: ERROR_JOURNAL_NOT_ACTIVE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The volume change journal is not active.</para>
        /// </summary>
        public const int ERROR_JOURNAL_NOT_ACTIVE = 1179;

        /// <summary>
        /// <para>// MessageId: ERROR_POTENTIAL_FILE_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A file was found, but it may not be the correct file.</para>
        /// </summary>
        public const int ERROR_POTENTIAL_FILE_FOUND = 1180;

        /// <summary>
        /// <para>// MessageId: ERROR_JOURNAL_ENTRY_DELETED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The journal entry has been deleted from the journal.</para>
        /// </summary>
        public const int ERROR_JOURNAL_ENTRY_DELETED = 1181;

        /// <summary>
        /// <para>// MessageId: ERROR_BAD_DEVICE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified device name is invalid.</para>
        /// </summary>
        public const int ERROR_BAD_DEVICE = 1200;

        /// <summary>
        /// <para>// MessageId: ERROR_CONNECTION_UNAVAIL</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The device is not currently connected but it is a remembered connection.</para>
        /// </summary>
        public const int ERROR_CONNECTION_UNAVAIL = 1201;

        /// <summary>
        /// <para>// MessageId: ERROR_DEVICE_ALREADY_REMEMBERED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The local device name has a remembered connection to another network resource.</para>
        /// </summary>
        public const int ERROR_DEVICE_ALREADY_REMEMBERED = 1202;

        /// <summary>
        /// <para>// MessageId: ERROR_NO_NET_OR_BAD_PATH</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  No network provider accepted the given network path.</para>
        /// </summary>
        public const int ERROR_NO_NET_OR_BAD_PATH = 1203;

        /// <summary>
        /// <para>// MessageId: ERROR_BAD_PROVIDER</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified network provider name is invalid.</para>
        /// </summary>
        public const int ERROR_BAD_PROVIDER = 1204;

        /// <summary>
        /// <para>// MessageId: ERROR_CANNOT_OPEN_PROFILE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Unable to open the network connection profile.</para>
        /// </summary>
        public const int ERROR_CANNOT_OPEN_PROFILE = 1205;

        /// <summary>
        /// <para>// MessageId: ERROR_BAD_PROFILE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The network connection profile is corrupted.</para>
        /// </summary>
        public const int ERROR_BAD_PROFILE = 1206;

        /// <summary>
        /// <para>// MessageId: ERROR_NOT_CONTAINER</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Cannot enumerate a noncontainer.</para>
        /// </summary>
        public const int ERROR_NOT_CONTAINER = 1207;

        /// <summary>
        /// <para>// MessageId: ERROR_EXTENDED_ERROR</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An extended error has occurred.</para>
        /// </summary>
        public const int ERROR_EXTENDED_ERROR = 1208;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_GROUPNAME</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The format of the specified group name is invalid.</para>
        /// </summary>
        public const int ERROR_INVALID_GROUPNAME = 1209;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_COMPUTERNAME</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The format of the specified computer name is invalid.</para>
        /// </summary>
        public const int ERROR_INVALID_COMPUTERNAME = 1210;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_EVENTNAME</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The format of the specified event name is invalid.</para>
        /// </summary>
        public const int ERROR_INVALID_EVENTNAME = 1211;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_DOMAINNAME</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The format of the specified domain name is invalid.</para>
        /// </summary>
        public const int ERROR_INVALID_DOMAINNAME = 1212;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_SERVICENAME</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The format of the specified service name is invalid.</para>
        /// </summary>
        public const int ERROR_INVALID_SERVICENAME = 1213;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_NETNAME</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The format of the specified network name is invalid.</para>
        /// </summary>
        public const int ERROR_INVALID_NETNAME = 1214;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_SHARENAME</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The format of the specified share name is invalid.</para>
        /// </summary>
        public const int ERROR_INVALID_SHARENAME = 1215;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_PASSWORDNAME</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The format of the specified password is invalid.</para>
        /// </summary>
        public const int ERROR_INVALID_PASSWORDNAME = 1216;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_MESSAGENAME</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The format of the specified message name is invalid.</para>
        /// </summary>
        public const int ERROR_INVALID_MESSAGENAME = 1217;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_MESSAGEDEST</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The format of the specified message destination is invalid.</para>
        /// </summary>
        public const int ERROR_INVALID_MESSAGEDEST = 1218;

        /// <summary>
        /// <para>// MessageId: ERROR_SESSION_CREDENTIAL_CONFLICT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Multiple connections to a server or shared resource by the same user, using more than one user  name, are not allowed. Disconnect all previous connections to the server or shared resource and try  again.</para>
        /// </summary>
        public const int ERROR_SESSION_CREDENTIAL_CONFLICT = 1219;

        /// <summary>
        /// <para>// MessageId: ERROR_REMOTE_SESSION_LIMIT_EXCEEDED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An attempt was made to establish a session to a network server, but there are already too many  sessions established to that server.</para>
        /// </summary>
        public const int ERROR_REMOTE_SESSION_LIMIT_EXCEEDED = 1220;

        /// <summary>
        /// <para>// MessageId: ERROR_DUP_DOMAINNAME</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The workgroup or domain name is already in use by another computer on the network.</para>
        /// </summary>
        public const int ERROR_DUP_DOMAINNAME = 1221;

        /// <summary>
        /// <para>// MessageId: ERROR_NO_NETWORK</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The network is not present or not started.</para>
        /// </summary>
        public const int ERROR_NO_NETWORK = 1222;

        /// <summary>
        /// <para>// MessageId: ERROR_CANCELLED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The operation was canceled by the user.</para>
        /// </summary>
        public const int ERROR_CANCELLED = 1223;

        /// <summary>
        /// <para>// MessageId: ERROR_USER_MAPPED_FILE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The requested operation cannot be performed on a file with a user-mapped section open.</para>
        /// </summary>
        public const int ERROR_USER_MAPPED_FILE = 1224;

        /// <summary>
        /// <para>// MessageId: ERROR_CONNECTION_REFUSED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The remote system refused the network connection.</para>
        /// </summary>
        public const int ERROR_CONNECTION_REFUSED = 1225;

        /// <summary>
        /// <para>// MessageId: ERROR_GRACEFUL_DISCONNECT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The network connection was gracefully closed.</para>
        /// </summary>
        public const int ERROR_GRACEFUL_DISCONNECT = 1226;

        /// <summary>
        /// <para>// MessageId: ERROR_ADDRESS_ALREADY_ASSOCIATED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The network transport endpoint already has an address associated with it.</para>
        /// </summary>
        public const int ERROR_ADDRESS_ALREADY_ASSOCIATED = 1227;

        /// <summary>
        /// <para>// MessageId: ERROR_ADDRESS_NOT_ASSOCIATED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An address has not yet been associated with the network endpoint.</para>
        /// </summary>
        public const int ERROR_ADDRESS_NOT_ASSOCIATED = 1228;

        /// <summary>
        /// <para>// MessageId: ERROR_CONNECTION_INVALID</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An operation was attempted on a nonexistent network connection.</para>
        /// </summary>
        public const int ERROR_CONNECTION_INVALID = 1229;

        /// <summary>
        /// <para>// MessageId: ERROR_CONNECTION_ACTIVE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An invalid operation was attempted on an active network connection.</para>
        /// </summary>
        public const int ERROR_CONNECTION_ACTIVE = 1230;

        /// <summary>
        /// <para>// MessageId: ERROR_NETWORK_UNREACHABLE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The network location cannot be reached. For information about network troubleshooting, see Windows  Help.</para>
        /// </summary>
        public const int ERROR_NETWORK_UNREACHABLE = 1231;

        /// <summary>
        /// <para>// MessageId: ERROR_HOST_UNREACHABLE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The network location cannot be reached. For information about network troubleshooting, see Windows  Help.</para>
        /// </summary>
        public const int ERROR_HOST_UNREACHABLE = 1232;

        /// <summary>
        /// <para>// MessageId: ERROR_PROTOCOL_UNREACHABLE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The network location cannot be reached. For information about network troubleshooting, see Windows  Help.</para>
        /// </summary>
        public const int ERROR_PROTOCOL_UNREACHABLE = 1233;

        /// <summary>
        /// <para>// MessageId: ERROR_PORT_UNREACHABLE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  No service is operating at the destination network endpoint on the remote system.</para>
        /// </summary>
        public const int ERROR_PORT_UNREACHABLE = 1234;

        /// <summary>
        /// <para>// MessageId: ERROR_REQUEST_ABORTED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The request was aborted.</para>
        /// </summary>
        public const int ERROR_REQUEST_ABORTED = 1235;

        /// <summary>
        /// <para>// MessageId: ERROR_CONNECTION_ABORTED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The network connection was aborted by the local system.</para>
        /// </summary>
        public const int ERROR_CONNECTION_ABORTED = 1236;

        /// <summary>
        /// <para>// MessageId: ERROR_RETRY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The operation could not be completed. A retry should be performed.</para>
        /// </summary>
        public const int ERROR_RETRY = 1237;

        /// <summary>
        /// <para>// MessageId: ERROR_CONNECTION_COUNT_LIMIT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A connection to the server could not be made because the limit on the number of concurrent  connections for this account has been reached.</para>
        /// </summary>
        public const int ERROR_CONNECTION_COUNT_LIMIT = 1238;

        /// <summary>
        /// <para>// MessageId: ERROR_LOGIN_TIME_RESTRICTION</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Attempting to log in during an unauthorized time of day for this account.</para>
        /// </summary>
        public const int ERROR_LOGIN_TIME_RESTRICTION = 1239;

        /// <summary>
        /// <para>// MessageId: ERROR_LOGIN_WKSTA_RESTRICTION</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The account is not authorized to log in from this station.</para>
        /// </summary>
        public const int ERROR_LOGIN_WKSTA_RESTRICTION = 1240;

        /// <summary>
        /// <para>// MessageId: ERROR_INCORRECT_ADDRESS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The network address could not be used for the operation requested.</para>
        /// </summary>
        public const int ERROR_INCORRECT_ADDRESS = 1241;

        /// <summary>
        /// <para>// MessageId: ERROR_ALREADY_REGISTERED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The service is already registered.</para>
        /// </summary>
        public const int ERROR_ALREADY_REGISTERED = 1242;

        /// <summary>
        /// <para>// MessageId: ERROR_SERVICE_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified service does not exist.</para>
        /// </summary>
        public const int ERROR_SERVICE_NOT_FOUND = 1243;

        /// <summary>
        /// <para>// MessageId: ERROR_NOT_AUTHENTICATED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The operation being requested was not performed because the user has not been authenticated.</para>
        /// </summary>
        public const int ERROR_NOT_AUTHENTICATED = 1244;

        /// <summary>
        /// <para>// MessageId: ERROR_NOT_LOGGED_ON</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The operation being requested was not performed because the user has not logged on to the network.</para>
        /// <para>//  The specified service does not exist.</para>
        /// </summary>
        public const int ERROR_NOT_LOGGED_ON = 1245;

        /// <summary>
        /// <para>// MessageId: ERROR_CONTINUE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Continue with work in progress.</para>
        /// </summary>
        public const int ERROR_CONTINUE = 1246; // dderror

        /// <summary>
        /// <para>// MessageId: ERROR_ALREADY_INITIALIZED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An attempt was made to perform an initialization operation when initialization has already been  completed.</para>
        /// </summary>
        public const int ERROR_ALREADY_INITIALIZED = 1247;

        /// <summary>
        /// <para>// MessageId: ERROR_NO_MORE_DEVICES</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  No more local devices.</para>
        /// </summary>
        public const int ERROR_NO_MORE_DEVICES = 1248; // dderror

        /// <summary>
        /// <para>// MessageId: ERROR_NO_SUCH_SITE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified site does not exist.</para>
        /// </summary>
        public const int ERROR_NO_SUCH_SITE = 1249;

        /// <summary>
        /// <para>// MessageId: ERROR_DOMAIN_CONTROLLER_EXISTS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A domain controller with the specified name already exists.</para>
        /// </summary>
        public const int ERROR_DOMAIN_CONTROLLER_EXISTS = 1250;

        /// <summary>
        /// <para>// MessageId: ERROR_ONLY_IF_CONNECTED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  This operation is supported only when you are connected to the server.</para>
        /// </summary>
        public const int ERROR_ONLY_IF_CONNECTED = 1251;

        /// <summary>
        /// <para>// MessageId: ERROR_OVERRIDE_NOCHANGES</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The group policy framework should call the extension even if there are no changes.</para>
        /// </summary>
        public const int ERROR_OVERRIDE_NOCHANGES = 1252;

        /// <summary>
        /// <para>// MessageId: ERROR_BAD_USER_PROFILE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified user does not have a valid profile.</para>
        /// </summary>
        public const int ERROR_BAD_USER_PROFILE = 1253;

        /// <summary>
        /// <para>// MessageId: ERROR_NOT_SUPPORTED_ON_SBS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  This operation is not supported on a computer running Windows Server 2003 for Small Business  Server</para>
        /// </summary>
        public const int ERROR_NOT_SUPPORTED_ON_SBS = 1254;

        /// <summary>
        /// <para>// MessageId: ERROR_SERVER_SHUTDOWN_IN_PROGRESS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The server machine is shutting down.</para>
        /// </summary>
        public const int ERROR_SERVER_SHUTDOWN_IN_PROGRESS = 1255;

        /// <summary>
        /// <para>// MessageId: ERROR_HOST_DOWN</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The remote system is not available. For information about network troubleshooting, see Windows  Help.</para>
        /// </summary>
        public const int ERROR_HOST_DOWN = 1256;

        /// <summary>
        /// <para>// MessageId: ERROR_NON_ACCOUNT_SID</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The security identifier provided is not from an account domain.</para>
        /// </summary>
        public const int ERROR_NON_ACCOUNT_SID = 1257;

        /// <summary>
        /// <para>// MessageId: ERROR_NON_DOMAIN_SID</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The security identifier provided does not have a domain component.</para>
        /// </summary>
        public const int ERROR_NON_DOMAIN_SID = 1258;

        /// <summary>
        /// <para>// MessageId: ERROR_APPHELP_BLOCK</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  AppHelp dialog canceled thus preventing the application from starting.</para>
        /// </summary>
        public const int ERROR_APPHELP_BLOCK = 1259;

        /// <summary>
        /// <para>// MessageId: ERROR_ACCESS_DISABLED_BY_POLICY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Windows cannot open this program because it has been prevented by a software restriction policy.  For more information, open Event Viewer or contact your system administrator.</para>
        /// </summary>
        public const int ERROR_ACCESS_DISABLED_BY_POLICY = 1260;

        /// <summary>
        /// <para>// MessageId: ERROR_REG_NAT_CONSUMPTION</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A program attempt to use an invalid register value.  Normally caused by an uninitialized register.  This error is Itanium specific.</para>
        /// </summary>
        public const int ERROR_REG_NAT_CONSUMPTION = 1261;

        /// <summary>
        /// <para>// MessageId: ERROR_CSCSHARE_OFFLINE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The share is currently offline or does not exist.</para>
        /// </summary>
        public const int ERROR_CSCSHARE_OFFLINE = 1262;

        /// <summary>
        /// <para>// MessageId: ERROR_PKINIT_FAILURE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The kerberos protocol encountered an error while validating the</para>
        /// <para>//  KDC certificate during smartcard logon.  There is more information in the</para>
        /// <para>//  system event log.</para>
        /// </summary>
        public const int ERROR_PKINIT_FAILURE = 1263;

        /// <summary>
        /// <para>// MessageId: ERROR_SMARTCARD_SUBSYSTEM_FAILURE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The kerberos protocol encountered an error while attempting to utilize</para>
        /// <para>//  the smartcard subsystem.</para>
        /// </summary>
        public const int ERROR_SMARTCARD_SUBSYSTEM_FAILURE = 1264;

        /// <summary>
        /// <para>// MessageId: ERROR_DOWNGRADE_DETECTED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The system detected a possible attempt to compromise security. Please ensure that you can contact  the server that authenticated you.</para>
        /// </summary>
        public const int ERROR_DOWNGRADE_DETECTED = 1265;

        /// <summary>
        /// <para>// Do not use ID's 1266 - 1270 as the symbolicNames have been moved to SEC_E_*</para>
        /// <para>//</para>
        /// <para>//</para>
        /// <para>// MessageId: ERROR_MACHINE_LOCKED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The machine is locked and can not be shut down without the force option.</para>
        /// </summary>
        public const int ERROR_MACHINE_LOCKED = 1271;

        /// <summary>
        /// <para>// MessageId: ERROR_CALLBACK_SUPPLIED_INVALID_DATA</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An application-defined callback gave invalid data when called.</para>
        /// </summary>
        public const int ERROR_CALLBACK_SUPPLIED_INVALID_DATA = 1273;

        /// <summary>
        /// <para>// MessageId: ERROR_SYNC_FOREGROUND_REFRESH_REQUIRED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The group policy framework should call the extension in the synchronous foreground policy refresh.</para>
        /// </summary>
        public const int ERROR_SYNC_FOREGROUND_REFRESH_REQUIRED = 1274;

        /// <summary>
        /// <para>// MessageId: ERROR_DRIVER_BLOCKED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  This driver has been blocked from loading</para>
        /// </summary>
        public const int ERROR_DRIVER_BLOCKED = 1275;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_IMPORT_OF_NON_DLL</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A dynamic link library (DLL) referenced a module that was neither a DLL nor the process's  executable image.</para>
        /// </summary>
        public const int ERROR_INVALID_IMPORT_OF_NON_DLL = 1276;

        /// <summary>
        /// <para>// MessageId: ERROR_ACCESS_DISABLED_WEBBLADE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Windows cannot open this program since it has been disabled.</para>
        /// </summary>
        public const int ERROR_ACCESS_DISABLED_WEBBLADE = 1277;

        /// <summary>
        /// <para>// MessageId: ERROR_ACCESS_DISABLED_WEBBLADE_TAMPER</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Windows cannot open this program because the license enforcement system has been tampered with or  become corrupted.</para>
        /// </summary>
        public const int ERROR_ACCESS_DISABLED_WEBBLADE_TAMPER = 1278;

        /// <summary>
        /// <para>// MessageId: ERROR_RECOVERY_FAILURE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A transaction recover failed.</para>
        /// </summary>
        public const int ERROR_RECOVERY_FAILURE = 1279;

        /// <summary>
        /// <para>// MessageId: ERROR_ALREADY_FIBER</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The current thread has already been converted to a fiber.</para>
        /// </summary>
        public const int ERROR_ALREADY_FIBER = 1280;

        /// <summary>
        /// <para>// MessageId: ERROR_ALREADY_THREAD</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The current thread has already been converted from a fiber.</para>
        /// </summary>
        public const int ERROR_ALREADY_THREAD = 1281;

        /// <summary>
        /// <para>// MessageId: ERROR_STACK_BUFFER_OVERRUN</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The system detected an overrun of a stack-based buffer in this application.  This</para>
        /// <para>//  overrun could potentially allow a malicious user to gain control of this application.</para>
        /// </summary>
        public const int ERROR_STACK_BUFFER_OVERRUN = 1282;

        /// <summary>
        /// <para>// MessageId: ERROR_PARAMETER_QUOTA_EXCEEDED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Data present in one of the parameters is more than the function can operate on.</para>
        /// </summary>
        public const int ERROR_PARAMETER_QUOTA_EXCEEDED = 1283;

        /// <summary>
        /// <para>// MessageId: ERROR_DEBUGGER_INACTIVE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An attempt to do an operation on a debug object failed because the object is in the process of  being deleted.</para>
        /// </summary>
        public const int ERROR_DEBUGGER_INACTIVE = 1284;

        /// <summary>
        /// <para>// MessageId: ERROR_DELAY_LOAD_FAILED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An attempt to delay-load a .dll or get a function address in a delay-loaded .dll failed.</para>
        /// </summary>
        public const int ERROR_DELAY_LOAD_FAILED = 1285;

        /// <summary>
        /// <para>// MessageId: ERROR_VDM_DISALLOWED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  %1 is a 16-bit application. You do not have permissions to execute 16-bit applications. Check your  permissions with your system administrator.</para>
        /// </summary>
        public const int ERROR_VDM_DISALLOWED = 1286;

        /// <summary>
        /// <para>// MessageId: ERROR_UNIDENTIFIED_ERROR</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Insufficient information exists to identify the cause of failure.</para>
        /// </summary>
        public const int ERROR_UNIDENTIFIED_ERROR = 1287;


        ///////////////////////////
        //
        // Add new status codes before this point unless there is a component specific section below.
        //
        ///////////////////////////


        ///////////////////////////
        //                       //
        // Security Status Codes //
        //                       //
        ///////////////////////////


        /// <summary>
        /// <para>// MessageId: ERROR_NOT_ALL_ASSIGNED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Not all privileges referenced are assigned to the caller.</para>
        /// </summary>
        public const int ERROR_NOT_ALL_ASSIGNED = 1300;

        /// <summary>
        /// <para>// MessageId: ERROR_SOME_NOT_MAPPED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Some mapping between account names and security IDs was not done.</para>
        /// </summary>
        public const int ERROR_SOME_NOT_MAPPED = 1301;

        /// <summary>
        /// <para>// MessageId: ERROR_NO_QUOTAS_FOR_ACCOUNT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  No system quota limits are specifically set for this account.</para>
        /// </summary>
        public const int ERROR_NO_QUOTAS_FOR_ACCOUNT = 1302;

        /// <summary>
        /// <para>// MessageId: ERROR_LOCAL_USER_SESSION_KEY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  No encryption key is available. A well-known encryption key was returned.</para>
        /// </summary>
        public const int ERROR_LOCAL_USER_SESSION_KEY = 1303;

        /// <summary>
        /// <para>// MessageId: ERROR_NULL_LM_PASSWORD</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The password is too complex to be converted to a LAN Manager password. The LAN Manager password  returned is a NULL string.</para>
        /// </summary>
        public const int ERROR_NULL_LM_PASSWORD = 1304;

        /// <summary>
        /// <para>// MessageId: ERROR_UNKNOWN_REVISION</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The revision level is unknown.</para>
        /// </summary>
        public const int ERROR_UNKNOWN_REVISION = 1305;

        /// <summary>
        /// <para>// MessageId: ERROR_REVISION_MISMATCH</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Indicates two revision levels are incompatible.</para>
        /// </summary>
        public const int ERROR_REVISION_MISMATCH = 1306;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_OWNER</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  This security ID may not be assigned as the owner of this object.</para>
        /// </summary>
        public const int ERROR_INVALID_OWNER = 1307;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_PRIMARY_GROUP</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  This security ID may not be assigned as the primary group of an object.</para>
        /// </summary>
        public const int ERROR_INVALID_PRIMARY_GROUP = 1308;

        /// <summary>
        /// <para>// MessageId: ERROR_NO_IMPERSONATION_TOKEN</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An attempt has been made to operate on an impersonation token by a thread that is not currently  impersonating a client.</para>
        /// </summary>
        public const int ERROR_NO_IMPERSONATION_TOKEN = 1309;

        /// <summary>
        /// <para>// MessageId: ERROR_CANT_DISABLE_MANDATORY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The group may not be disabled.</para>
        /// </summary>
        public const int ERROR_CANT_DISABLE_MANDATORY = 1310;

        /// <summary>
        /// <para>// MessageId: ERROR_NO_LOGON_SERVERS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  There are currently no logon servers available to service the logon request.</para>
        /// </summary>
        public const int ERROR_NO_LOGON_SERVERS = 1311;

        /// <summary>
        /// <para>// MessageId: ERROR_NO_SUCH_LOGON_SESSION</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A specified logon session does not exist. It may already have been terminated.</para>
        /// </summary>
        public const int ERROR_NO_SUCH_LOGON_SESSION = 1312;

        /// <summary>
        /// <para>// MessageId: ERROR_NO_SUCH_PRIVILEGE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A specified privilege does not exist.</para>
        /// </summary>
        public const int ERROR_NO_SUCH_PRIVILEGE = 1313;

        /// <summary>
        /// <para>// MessageId: ERROR_PRIVILEGE_NOT_HELD</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A required privilege is not held by the client.</para>
        /// </summary>
        public const int ERROR_PRIVILEGE_NOT_HELD = 1314;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_ACCOUNT_NAME</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The name provided is not a properly formed account name.</para>
        /// </summary>
        public const int ERROR_INVALID_ACCOUNT_NAME = 1315;

        /// <summary>
        /// <para>// MessageId: ERROR_USER_EXISTS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified user already exists.</para>
        /// </summary>
        public const int ERROR_USER_EXISTS = 1316;

        /// <summary>
        /// <para>// MessageId: ERROR_NO_SUCH_USER</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified user does not exist.</para>
        /// </summary>
        public const int ERROR_NO_SUCH_USER = 1317;

        /// <summary>
        /// <para>// MessageId: ERROR_GROUP_EXISTS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified group already exists.</para>
        /// </summary>
        public const int ERROR_GROUP_EXISTS = 1318;

        /// <summary>
        /// <para>// MessageId: ERROR_NO_SUCH_GROUP</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified group does not exist.</para>
        /// </summary>
        public const int ERROR_NO_SUCH_GROUP = 1319;

        /// <summary>
        /// <para>// MessageId: ERROR_MEMBER_IN_GROUP</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Either the specified user account is already a member of the specified group, or the specified  group cannot be deleted because it contains a member.</para>
        /// </summary>
        public const int ERROR_MEMBER_IN_GROUP = 1320;

        /// <summary>
        /// <para>// MessageId: ERROR_MEMBER_NOT_IN_GROUP</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified user account is not a member of the specified group account.</para>
        /// </summary>
        public const int ERROR_MEMBER_NOT_IN_GROUP = 1321;

        /// <summary>
        /// <para>// MessageId: ERROR_LAST_ADMIN</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The last remaining administration account cannot be disabled or deleted.</para>
        /// </summary>
        public const int ERROR_LAST_ADMIN = 1322;

        /// <summary>
        /// <para>// MessageId: ERROR_WRONG_PASSWORD</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Unable to update the password. The value provided as the current password is incorrect.</para>
        /// </summary>
        public const int ERROR_WRONG_PASSWORD = 1323;

        /// <summary>
        /// <para>// MessageId: ERROR_ILL_FORMED_PASSWORD</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Unable to update the password. The value provided for the new password contains values that are  not allowed in passwords.</para>
        /// </summary>
        public const int ERROR_ILL_FORMED_PASSWORD = 1324;

        /// <summary>
        /// <para>// MessageId: ERROR_PASSWORD_RESTRICTION</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Unable to update the password. The value provided for the new password does not meet the length,  complexity, or history requirement of the domain.</para>
        /// </summary>
        public const int ERROR_PASSWORD_RESTRICTION = 1325;

        /// <summary>
        /// <para>// MessageId: ERROR_LOGON_FAILURE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Logon failure: unknown user name or bad password.</para>
        /// </summary>
        public const int ERROR_LOGON_FAILURE = 1326;

        /// <summary>
        /// <para>// MessageId: ERROR_ACCOUNT_RESTRICTION</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Logon failure: user account restriction.  Possible reasons are blank passwords not allowed, logon  hour restrictions, or a policy restriction has been enforced.</para>
        /// </summary>
        public const int ERROR_ACCOUNT_RESTRICTION = 1327;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_LOGON_HOURS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Logon failure: account logon time restriction violation.</para>
        /// </summary>
        public const int ERROR_INVALID_LOGON_HOURS = 1328;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_WORKSTATION</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Logon failure: user not allowed to log on to this computer.</para>
        /// </summary>
        public const int ERROR_INVALID_WORKSTATION = 1329;

        /// <summary>
        /// <para>// MessageId: ERROR_PASSWORD_EXPIRED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Logon failure: the specified account password has expired.</para>
        /// </summary>
        public const int ERROR_PASSWORD_EXPIRED = 1330;

        /// <summary>
        /// <para>// MessageId: ERROR_ACCOUNT_DISABLED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Logon failure: account currently disabled.</para>
        /// </summary>
        public const int ERROR_ACCOUNT_DISABLED = 1331;

        /// <summary>
        /// <para>// MessageId: ERROR_NONE_MAPPED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  No mapping between account names and security IDs was done.</para>
        /// </summary>
        public const int ERROR_NONE_MAPPED = 1332;

        /// <summary>
        /// <para>// MessageId: ERROR_TOO_MANY_LUIDS_REQUESTED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Too many local user identifiers (LUIDs) were requested at one time.</para>
        /// </summary>
        public const int ERROR_TOO_MANY_LUIDS_REQUESTED = 1333;

        /// <summary>
        /// <para>// MessageId: ERROR_LUIDS_EXHAUSTED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  No more local user identifiers (LUIDs) are available.</para>
        /// </summary>
        public const int ERROR_LUIDS_EXHAUSTED = 1334;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_SUB_AUTHORITY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The subauthority part of a security ID is invalid for this particular use.</para>
        /// </summary>
        public const int ERROR_INVALID_SUB_AUTHORITY = 1335;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_ACL</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The access control list (ACL) structure is invalid.</para>
        /// </summary>
        public const int ERROR_INVALID_ACL = 1336;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_SID</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The security ID structure is invalid.</para>
        /// </summary>
        public const int ERROR_INVALID_SID = 1337;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_SECURITY_DESCR</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The security descriptor structure is invalid.</para>
        /// </summary>
        public const int ERROR_INVALID_SECURITY_DESCR = 1338;

        /// <summary>
        /// <para>// MessageId: ERROR_BAD_INHERITANCE_ACL</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The inherited access control list (ACL) or access control entry (ACE) could not be built.</para>
        /// </summary>
        public const int ERROR_BAD_INHERITANCE_ACL = 1340;

        /// <summary>
        /// <para>// MessageId: ERROR_SERVER_DISABLED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The server is currently disabled.</para>
        /// </summary>
        public const int ERROR_SERVER_DISABLED = 1341;

        /// <summary>
        /// <para>// MessageId: ERROR_SERVER_NOT_DISABLED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The server is currently enabled.</para>
        /// </summary>
        public const int ERROR_SERVER_NOT_DISABLED = 1342;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_ID_AUTHORITY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The value provided was an invalid value for an identifier authority.</para>
        /// </summary>
        public const int ERROR_INVALID_ID_AUTHORITY = 1343;

        /// <summary>
        /// <para>// MessageId: ERROR_ALLOTTED_SPACE_EXCEEDED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  No more memory is available for security information updates.</para>
        /// </summary>
        public const int ERROR_ALLOTTED_SPACE_EXCEEDED = 1344;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_GROUP_ATTRIBUTES</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified attributes are invalid, or incompatible with the attributes for the group as a  whole.</para>
        /// </summary>
        public const int ERROR_INVALID_GROUP_ATTRIBUTES = 1345;

        /// <summary>
        /// <para>// MessageId: ERROR_BAD_IMPERSONATION_LEVEL</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Either a required impersonation level was not provided, or the provided impersonation level is  invalid.</para>
        /// </summary>
        public const int ERROR_BAD_IMPERSONATION_LEVEL = 1346;

        /// <summary>
        /// <para>// MessageId: ERROR_CANT_OPEN_ANONYMOUS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Cannot open an anonymous level security token.</para>
        /// </summary>
        public const int ERROR_CANT_OPEN_ANONYMOUS = 1347;

        /// <summary>
        /// <para>// MessageId: ERROR_BAD_VALIDATION_CLASS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The validation information class requested was invalid.</para>
        /// </summary>
        public const int ERROR_BAD_VALIDATION_CLASS = 1348;

        /// <summary>
        /// <para>// MessageId: ERROR_BAD_TOKEN_TYPE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The type of the token is inappropriate for its attempted use.</para>
        /// </summary>
        public const int ERROR_BAD_TOKEN_TYPE = 1349;

        /// <summary>
        /// <para>// MessageId: ERROR_NO_SECURITY_ON_OBJECT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Unable to perform a security operation on an object that has no associated security.</para>
        /// </summary>
        public const int ERROR_NO_SECURITY_ON_OBJECT = 1350;

        /// <summary>
        /// <para>// MessageId: ERROR_CANT_ACCESS_DOMAIN_INFO</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Configuration information could not be read from the domain controller, either because the machine  is unavailable, or access has been denied.</para>
        /// </summary>
        public const int ERROR_CANT_ACCESS_DOMAIN_INFO = 1351;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_SERVER_STATE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The security account manager (SAM) or local security authority (LSA) server was in the wrong state  to perform the security operation.</para>
        /// </summary>
        public const int ERROR_INVALID_SERVER_STATE = 1352;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_DOMAIN_STATE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The domain was in the wrong state to perform the security operation.</para>
        /// </summary>
        public const int ERROR_INVALID_DOMAIN_STATE = 1353;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_DOMAIN_ROLE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  This operation is only allowed for the Primary Domain Controller of the domain.</para>
        /// </summary>
        public const int ERROR_INVALID_DOMAIN_ROLE = 1354;

        /// <summary>
        /// <para>// MessageId: ERROR_NO_SUCH_DOMAIN</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified domain either does not exist or could not be contacted.</para>
        /// </summary>
        public const int ERROR_NO_SUCH_DOMAIN = 1355;

        /// <summary>
        /// <para>// MessageId: ERROR_DOMAIN_EXISTS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified domain already exists.</para>
        /// </summary>
        public const int ERROR_DOMAIN_EXISTS = 1356;

        /// <summary>
        /// <para>// MessageId: ERROR_DOMAIN_LIMIT_EXCEEDED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An attempt was made to exceed the limit on the number of domains per server.</para>
        /// </summary>
        public const int ERROR_DOMAIN_LIMIT_EXCEEDED = 1357;

        /// <summary>
        /// <para>// MessageId: ERROR_INTERNAL_DB_CORRUPTION</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Unable to complete the requested operation because of either a catastrophic media failure or a  data structure corruption on the disk.</para>
        /// </summary>
        public const int ERROR_INTERNAL_DB_CORRUPTION = 1358;

        /// <summary>
        /// <para>// MessageId: ERROR_INTERNAL_ERROR</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An internal error occurred.</para>
        /// </summary>
        public const int ERROR_INTERNAL_ERROR = 1359;

        /// <summary>
        /// <para>// MessageId: ERROR_GENERIC_NOT_MAPPED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Generic access types were contained in an access mask which should already be mapped to nongeneric  types.</para>
        /// </summary>
        public const int ERROR_GENERIC_NOT_MAPPED = 1360;

        /// <summary>
        /// <para>// MessageId: ERROR_BAD_DESCRIPTOR_FORMAT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A security descriptor is not in the right format (absolute or self-relative).</para>
        /// </summary>
        public const int ERROR_BAD_DESCRIPTOR_FORMAT = 1361;

        /// <summary>
        /// <para>// MessageId: ERROR_NOT_LOGON_PROCESS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The requested action is restricted for use by logon processes only. The calling process has not  registered as a logon process.</para>
        /// </summary>
        public const int ERROR_NOT_LOGON_PROCESS = 1362;

        /// <summary>
        /// <para>// MessageId: ERROR_LOGON_SESSION_EXISTS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Cannot start a new logon session with an ID that is already in use.</para>
        /// </summary>
        public const int ERROR_LOGON_SESSION_EXISTS = 1363;

        /// <summary>
        /// <para>// MessageId: ERROR_NO_SUCH_PACKAGE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A specified authentication package is unknown.</para>
        /// </summary>
        public const int ERROR_NO_SUCH_PACKAGE = 1364;

        /// <summary>
        /// <para>// MessageId: ERROR_BAD_LOGON_SESSION_STATE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The logon session is not in a state that is consistent with the requested operation.</para>
        /// </summary>
        public const int ERROR_BAD_LOGON_SESSION_STATE = 1365;

        /// <summary>
        /// <para>// MessageId: ERROR_LOGON_SESSION_COLLISION</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The logon session ID is already in use.</para>
        /// </summary>
        public const int ERROR_LOGON_SESSION_COLLISION = 1366;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_LOGON_TYPE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A logon request contained an invalid logon type value.</para>
        /// </summary>
        public const int ERROR_INVALID_LOGON_TYPE = 1367;

        /// <summary>
        /// <para>// MessageId: ERROR_CANNOT_IMPERSONATE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Unable to impersonate using a named pipe until data has been read from that pipe.</para>
        /// </summary>
        public const int ERROR_CANNOT_IMPERSONATE = 1368;

        /// <summary>
        /// <para>// MessageId: ERROR_RXACT_INVALID_STATE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The transaction state of a registry subtree is incompatible with the requested operation.</para>
        /// </summary>
        public const int ERROR_RXACT_INVALID_STATE = 1369;

        /// <summary>
        /// <para>// MessageId: ERROR_RXACT_COMMIT_FAILURE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An internal security database corruption has been encountered.</para>
        /// </summary>
        public const int ERROR_RXACT_COMMIT_FAILURE = 1370;

        /// <summary>
        /// <para>// MessageId: ERROR_SPECIAL_ACCOUNT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Cannot perform this operation on built-in accounts.</para>
        /// </summary>
        public const int ERROR_SPECIAL_ACCOUNT = 1371;

        /// <summary>
        /// <para>// MessageId: ERROR_SPECIAL_GROUP</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Cannot perform this operation on this built-in special group.</para>
        /// </summary>
        public const int ERROR_SPECIAL_GROUP = 1372;

        /// <summary>
        /// <para>// MessageId: ERROR_SPECIAL_USER</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Cannot perform this operation on this built-in special user.</para>
        /// </summary>
        public const int ERROR_SPECIAL_USER = 1373;

        /// <summary>
        /// <para>// MessageId: ERROR_MEMBERS_PRIMARY_GROUP</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The user cannot be removed from a group because the group is currently the user's primary group.</para>
        /// </summary>
        public const int ERROR_MEMBERS_PRIMARY_GROUP = 1374;

        /// <summary>
        /// <para>// MessageId: ERROR_TOKEN_ALREADY_IN_USE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The token is already in use as a primary token.</para>
        /// </summary>
        public const int ERROR_TOKEN_ALREADY_IN_USE = 1375;

        /// <summary>
        /// <para>// MessageId: ERROR_NO_SUCH_ALIAS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified local group does not exist.</para>
        /// </summary>
        public const int ERROR_NO_SUCH_ALIAS = 1376;

        /// <summary>
        /// <para>// MessageId: ERROR_MEMBER_NOT_IN_ALIAS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified account name is not a member of the local group.</para>
        /// </summary>
        public const int ERROR_MEMBER_NOT_IN_ALIAS = 1377;

        /// <summary>
        /// <para>// MessageId: ERROR_MEMBER_IN_ALIAS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified account name is already a member of the local group.</para>
        /// </summary>
        public const int ERROR_MEMBER_IN_ALIAS = 1378;

        /// <summary>
        /// <para>// MessageId: ERROR_ALIAS_EXISTS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified local group already exists.</para>
        /// </summary>
        public const int ERROR_ALIAS_EXISTS = 1379;

        /// <summary>
        /// <para>// MessageId: ERROR_LOGON_NOT_GRANTED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Logon failure: the user has not been granted the requested logon type at this computer.</para>
        /// </summary>
        public const int ERROR_LOGON_NOT_GRANTED = 1380;

        /// <summary>
        /// <para>// MessageId: ERROR_TOO_MANY_SECRETS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The maximum number of secrets that may be stored in a single system has been exceeded.</para>
        /// </summary>
        public const int ERROR_TOO_MANY_SECRETS = 1381;

        /// <summary>
        /// <para>// MessageId: ERROR_SECRET_TOO_LONG</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The length of a secret exceeds the maximum length allowed.</para>
        /// </summary>
        public const int ERROR_SECRET_TOO_LONG = 1382;

        /// <summary>
        /// <para>// MessageId: ERROR_INTERNAL_DB_ERROR</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The local security authority database contains an internal inconsistency.</para>
        /// </summary>
        public const int ERROR_INTERNAL_DB_ERROR = 1383;

        /// <summary>
        /// <para>// MessageId: ERROR_TOO_MANY_CONTEXT_IDS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  During a logon attempt, the user's security context accumulated too many security IDs.</para>
        /// </summary>
        public const int ERROR_TOO_MANY_CONTEXT_IDS = 1384;

        /// <summary>
        /// <para>// MessageId: ERROR_LOGON_TYPE_NOT_GRANTED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Logon failure: the user has not been granted the requested logon type at this computer.</para>
        /// </summary>
        public const int ERROR_LOGON_TYPE_NOT_GRANTED = 1385;

        /// <summary>
        /// <para>// MessageId: ERROR_NT_CROSS_ENCRYPTION_REQUIRED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A cross-encrypted password is necessary to change a user password.</para>
        /// </summary>
        public const int ERROR_NT_CROSS_ENCRYPTION_REQUIRED = 1386;

        /// <summary>
        /// <para>// MessageId: ERROR_NO_SUCH_MEMBER</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A member could not be added to or removed from the local group because the member does not exist.</para>
        /// </summary>
        public const int ERROR_NO_SUCH_MEMBER = 1387;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_MEMBER</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A new member could not be added to a local group because the member has the wrong account type.</para>
        /// </summary>
        public const int ERROR_INVALID_MEMBER = 1388;

        /// <summary>
        /// <para>// MessageId: ERROR_TOO_MANY_SIDS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Too many security IDs have been specified.</para>
        /// </summary>
        public const int ERROR_TOO_MANY_SIDS = 1389;

        /// <summary>
        /// <para>// MessageId: ERROR_LM_CROSS_ENCRYPTION_REQUIRED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A cross-encrypted password is necessary to change this user password.</para>
        /// </summary>
        public const int ERROR_LM_CROSS_ENCRYPTION_REQUIRED = 1390;

        /// <summary>
        /// <para>// MessageId: ERROR_NO_INHERITANCE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Indicates an ACL contains no inheritable components.</para>
        /// </summary>
        public const int ERROR_NO_INHERITANCE = 1391;

        /// <summary>
        /// <para>// MessageId: ERROR_FILE_CORRUPT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The file or directory is corrupted and unreadable.</para>
        /// </summary>
        public const int ERROR_FILE_CORRUPT = 1392;

        /// <summary>
        /// <para>// MessageId: ERROR_DISK_CORRUPT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The disk structure is corrupted and unreadable.</para>
        /// </summary>
        public const int ERROR_DISK_CORRUPT = 1393;

        /// <summary>
        /// <para>// MessageId: ERROR_NO_USER_SESSION_KEY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  There is no user session key for the specified logon session.</para>
        /// </summary>
        public const int ERROR_NO_USER_SESSION_KEY = 1394;

        /// <summary>
        /// <para>// MessageId: ERROR_LICENSE_QUOTA_EXCEEDED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The service being accessed is licensed for a particular number of connections.</para>
        /// <para>//  No more connections can be made to the service at this time because there are already as many  connections as the service can accept.</para>
        /// </summary>
        public const int ERROR_LICENSE_QUOTA_EXCEEDED = 1395;

        /// <summary>
        /// <para>// MessageId: ERROR_WRONG_TARGET_NAME</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Logon Failure: The target account name is incorrect.</para>
        /// </summary>
        public const int ERROR_WRONG_TARGET_NAME = 1396;

        /// <summary>
        /// <para>// MessageId: ERROR_MUTUAL_AUTH_FAILED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Mutual Authentication failed. The server's password is out of date at the domain controller.</para>
        /// </summary>
        public const int ERROR_MUTUAL_AUTH_FAILED = 1397;

        /// <summary>
        /// <para>// MessageId: ERROR_TIME_SKEW</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  There is a time and/or date difference between the client and server.</para>
        /// </summary>
        public const int ERROR_TIME_SKEW = 1398;

        /// <summary>
        /// <para>// MessageId: ERROR_CURRENT_DOMAIN_NOT_ALLOWED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  This operation can not be performed on the current domain.</para>
        /// </summary>
        public const int ERROR_CURRENT_DOMAIN_NOT_ALLOWED = 1399;

        // End of security error codes



        ///////////////////////////
        //                       //
        // WinUser Error Codes   //
        //                       //
        ///////////////////////////


        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_WINDOW_HANDLE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Invalid window handle.</para>
        /// </summary>
        public const int ERROR_INVALID_WINDOW_HANDLE = 1400;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_MENU_HANDLE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Invalid menu handle.</para>
        /// </summary>
        public const int ERROR_INVALID_MENU_HANDLE = 1401;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_CURSOR_HANDLE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Invalid cursor handle.</para>
        /// </summary>
        public const int ERROR_INVALID_CURSOR_HANDLE = 1402;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_ACCEL_HANDLE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Invalid accelerator table handle.</para>
        /// </summary>
        public const int ERROR_INVALID_ACCEL_HANDLE = 1403;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_HOOK_HANDLE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Invalid hook handle.</para>
        /// </summary>
        public const int ERROR_INVALID_HOOK_HANDLE = 1404;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_DWP_HANDLE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Invalid handle to a multiple-window position structure.</para>
        /// </summary>
        public const int ERROR_INVALID_DWP_HANDLE = 1405;

        /// <summary>
        /// <para>// MessageId: ERROR_TLW_WITH_WSCHILD</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Cannot create a top-level child window.</para>
        /// </summary>
        public const int ERROR_TLW_WITH_WSCHILD = 1406;

        /// <summary>
        /// <para>// MessageId: ERROR_CANNOT_FIND_WND_CLASS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Cannot find window class.</para>
        /// </summary>
        public const int ERROR_CANNOT_FIND_WND_CLASS = 1407;

        /// <summary>
        /// <para>// MessageId: ERROR_WINDOW_OF_OTHER_THREAD</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Invalid window; it belongs to other thread.</para>
        /// </summary>
        public const int ERROR_WINDOW_OF_OTHER_THREAD = 1408;

        /// <summary>
        /// <para>// MessageId: ERROR_HOTKEY_ALREADY_REGISTERED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Hot key is already registered.</para>
        /// </summary>
        public const int ERROR_HOTKEY_ALREADY_REGISTERED = 1409;

        /// <summary>
        /// <para>// MessageId: ERROR_CLASS_ALREADY_EXISTS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Class already exists.</para>
        /// </summary>
        public const int ERROR_CLASS_ALREADY_EXISTS = 1410;

        /// <summary>
        /// <para>// MessageId: ERROR_CLASS_DOES_NOT_EXIST</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Class does not exist.</para>
        /// </summary>
        public const int ERROR_CLASS_DOES_NOT_EXIST = 1411;

        /// <summary>
        /// <para>// MessageId: ERROR_CLASS_HAS_WINDOWS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Class still has open windows.</para>
        /// </summary>
        public const int ERROR_CLASS_HAS_WINDOWS = 1412;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_INDEX</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Invalid index.</para>
        /// </summary>
        public const int ERROR_INVALID_INDEX = 1413;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_ICON_HANDLE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Invalid icon handle.</para>
        /// </summary>
        public const int ERROR_INVALID_ICON_HANDLE = 1414;

        /// <summary>
        /// <para>// MessageId: ERROR_PRIVATE_DIALOG_INDEX</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Using private DIALOG window words.</para>
        /// </summary>
        public const int ERROR_PRIVATE_DIALOG_INDEX = 1415;

        /// <summary>
        /// <para>// MessageId: ERROR_LISTBOX_ID_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The list box identifier was not found.</para>
        /// </summary>
        public const int ERROR_LISTBOX_ID_NOT_FOUND = 1416;

        /// <summary>
        /// <para>// MessageId: ERROR_NO_WILDCARD_CHARACTERS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  No wildcards were found.</para>
        /// </summary>
        public const int ERROR_NO_WILDCARD_CHARACTERS = 1417;

        /// <summary>
        /// <para>// MessageId: ERROR_CLIPBOARD_NOT_OPEN</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Thread does not have a clipboard open.</para>
        /// </summary>
        public const int ERROR_CLIPBOARD_NOT_OPEN = 1418;

        /// <summary>
        /// <para>// MessageId: ERROR_HOTKEY_NOT_REGISTERED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Hot key is not registered.</para>
        /// </summary>
        public const int ERROR_HOTKEY_NOT_REGISTERED = 1419;

        /// <summary>
        /// <para>// MessageId: ERROR_WINDOW_NOT_DIALOG</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The window is not a valid dialog window.</para>
        /// </summary>
        public const int ERROR_WINDOW_NOT_DIALOG = 1420;

        /// <summary>
        /// <para>// MessageId: ERROR_CONTROL_ID_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Control ID not found.</para>
        /// </summary>
        public const int ERROR_CONTROL_ID_NOT_FOUND = 1421;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_COMBOBOX_MESSAGE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Invalid message for a combo box because it does not have an edit control.</para>
        /// </summary>
        public const int ERROR_INVALID_COMBOBOX_MESSAGE = 1422;

        /// <summary>
        /// <para>// MessageId: ERROR_WINDOW_NOT_COMBOBOX</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The window is not a combo box.</para>
        /// </summary>
        public const int ERROR_WINDOW_NOT_COMBOBOX = 1423;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_EDIT_HEIGHT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Height must be less than 256.</para>
        /// </summary>
        public const int ERROR_INVALID_EDIT_HEIGHT = 1424;

        /// <summary>
        /// <para>// MessageId: ERROR_DC_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Invalid device context (DC) handle.</para>
        /// </summary>
        public const int ERROR_DC_NOT_FOUND = 1425;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_HOOK_FILTER</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Invalid hook procedure type.</para>
        /// </summary>
        public const int ERROR_INVALID_HOOK_FILTER = 1426;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_FILTER_PROC</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Invalid hook procedure.</para>
        /// </summary>
        public const int ERROR_INVALID_FILTER_PROC = 1427;

        /// <summary>
        /// <para>// MessageId: ERROR_HOOK_NEEDS_HMOD</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Cannot set nonlocal hook without a module handle.</para>
        /// </summary>
        public const int ERROR_HOOK_NEEDS_HMOD = 1428;

        /// <summary>
        /// <para>// MessageId: ERROR_GLOBAL_ONLY_HOOK</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  This hook procedure can only be set globally.</para>
        /// </summary>
        public const int ERROR_GLOBAL_ONLY_HOOK = 1429;

        /// <summary>
        /// <para>// MessageId: ERROR_JOURNAL_HOOK_SET</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The journal hook procedure is already installed.</para>
        /// </summary>
        public const int ERROR_JOURNAL_HOOK_SET = 1430;

        /// <summary>
        /// <para>// MessageId: ERROR_HOOK_NOT_INSTALLED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The hook procedure is not installed.</para>
        /// </summary>
        public const int ERROR_HOOK_NOT_INSTALLED = 1431;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_LB_MESSAGE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Invalid message for single-selection list box.</para>
        /// </summary>
        public const int ERROR_INVALID_LB_MESSAGE = 1432;

        /// <summary>
        /// <para>// MessageId: ERROR_SETCOUNT_ON_BAD_LB</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  LB_SETCOUNT sent to non-lazy list box.</para>
        /// </summary>
        public const int ERROR_SETCOUNT_ON_BAD_LB = 1433;

        /// <summary>
        /// <para>// MessageId: ERROR_LB_WITHOUT_TABSTOPS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  This list box does not support tab stops.</para>
        /// </summary>
        public const int ERROR_LB_WITHOUT_TABSTOPS = 1434;

        /// <summary>
        /// <para>// MessageId: ERROR_DESTROY_OBJECT_OF_OTHER_THREAD</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Cannot destroy object created by another thread.</para>
        /// </summary>
        public const int ERROR_DESTROY_OBJECT_OF_OTHER_THREAD = 1435;

        /// <summary>
        /// <para>// MessageId: ERROR_CHILD_WINDOW_MENU</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Child windows cannot have menus.</para>
        /// </summary>
        public const int ERROR_CHILD_WINDOW_MENU = 1436;

        /// <summary>
        /// <para>// MessageId: ERROR_NO_SYSTEM_MENU</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The window does not have a system menu.</para>
        /// </summary>
        public const int ERROR_NO_SYSTEM_MENU = 1437;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_MSGBOX_STYLE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Invalid message box style.</para>
        /// </summary>
        public const int ERROR_INVALID_MSGBOX_STYLE = 1438;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_SPI_VALUE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Invalid system-wide (SPI_*) parameter.</para>
        /// </summary>
        public const int ERROR_INVALID_SPI_VALUE = 1439;

        /// <summary>
        /// <para>// MessageId: ERROR_SCREEN_ALREADY_LOCKED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Screen already locked.</para>
        /// </summary>
        public const int ERROR_SCREEN_ALREADY_LOCKED = 1440;

        /// <summary>
        /// <para>// MessageId: ERROR_HWNDS_HAVE_DIFF_PARENT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  All handles to windows in a multiple-window position structure must have the same parent.</para>
        /// </summary>
        public const int ERROR_HWNDS_HAVE_DIFF_PARENT = 1441;

        /// <summary>
        /// <para>// MessageId: ERROR_NOT_CHILD_WINDOW</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The window is not a child window.</para>
        /// </summary>
        public const int ERROR_NOT_CHILD_WINDOW = 1442;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_GW_COMMAND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Invalid GW_* command.</para>
        /// </summary>
        public const int ERROR_INVALID_GW_COMMAND = 1443;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_THREAD_ID</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Invalid thread identifier.</para>
        /// </summary>
        public const int ERROR_INVALID_THREAD_ID = 1444;

        /// <summary>
        /// <para>// MessageId: ERROR_NON_MDICHILD_WINDOW</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Cannot process a message from a window that is not a multiple document interface (MDI) window.</para>
        /// </summary>
        public const int ERROR_NON_MDICHILD_WINDOW = 1445;

        /// <summary>
        /// <para>// MessageId: ERROR_POPUP_ALREADY_ACTIVE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Popup menu already active.</para>
        /// </summary>
        public const int ERROR_POPUP_ALREADY_ACTIVE = 1446;

        /// <summary>
        /// <para>// MessageId: ERROR_NO_SCROLLBARS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The window does not have scroll bars.</para>
        /// </summary>
        public const int ERROR_NO_SCROLLBARS = 1447;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_SCROLLBAR_RANGE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Scroll bar range cannot be greater than MAXLONG.</para>
        /// </summary>
        public const int ERROR_INVALID_SCROLLBAR_RANGE = 1448;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_SHOWWIN_COMMAND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Cannot show or remove the window in the way specified.</para>
        /// </summary>
        public const int ERROR_INVALID_SHOWWIN_COMMAND = 1449;

        /// <summary>
        /// <para>// MessageId: ERROR_NO_SYSTEM_RESOURCES</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Insufficient system resources exist to complete the requested service.</para>
        /// </summary>
        public const int ERROR_NO_SYSTEM_RESOURCES = 1450;

        /// <summary>
        /// <para>// MessageId: ERROR_NONPAGED_SYSTEM_RESOURCES</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Insufficient system resources exist to complete the requested service.</para>
        /// </summary>
        public const int ERROR_NONPAGED_SYSTEM_RESOURCES = 1451;

        /// <summary>
        /// <para>// MessageId: ERROR_PAGED_SYSTEM_RESOURCES</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Insufficient system resources exist to complete the requested service.</para>
        /// </summary>
        public const int ERROR_PAGED_SYSTEM_RESOURCES = 1452;

        /// <summary>
        /// <para>// MessageId: ERROR_WORKING_SET_QUOTA</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Insufficient quota to complete the requested service.</para>
        /// </summary>
        public const int ERROR_WORKING_SET_QUOTA = 1453;

        /// <summary>
        /// <para>// MessageId: ERROR_PAGEFILE_QUOTA</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Insufficient quota to complete the requested service.</para>
        /// </summary>
        public const int ERROR_PAGEFILE_QUOTA = 1454;

        /// <summary>
        /// <para>// MessageId: ERROR_COMMITMENT_LIMIT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The paging file is too small for this operation to complete.</para>
        /// </summary>
        public const int ERROR_COMMITMENT_LIMIT = 1455;

        /// <summary>
        /// <para>// MessageId: ERROR_MENU_ITEM_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A menu item was not found.</para>
        /// </summary>
        public const int ERROR_MENU_ITEM_NOT_FOUND = 1456;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_KEYBOARD_HANDLE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Invalid keyboard layout handle.</para>
        /// </summary>
        public const int ERROR_INVALID_KEYBOARD_HANDLE = 1457;

        /// <summary>
        /// <para>// MessageId: ERROR_HOOK_TYPE_NOT_ALLOWED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Hook type not allowed.</para>
        /// </summary>
        public const int ERROR_HOOK_TYPE_NOT_ALLOWED = 1458;

        /// <summary>
        /// <para>// MessageId: ERROR_REQUIRES_INTERACTIVE_WINDOWSTATION</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  This operation requires an interactive window station.</para>
        /// </summary>
        public const int ERROR_REQUIRES_INTERACTIVE_WINDOWSTATION = 1459;

        /// <summary>
        /// <para>// MessageId: ERROR_TIMEOUT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  This operation returned because the timeout period expired.</para>
        /// </summary>
        public const int ERROR_TIMEOUT = 1460;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_MONITOR_HANDLE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Invalid monitor handle.</para>
        /// </summary>
        public const int ERROR_INVALID_MONITOR_HANDLE = 1461;

        /// <summary>
        /// <para>// MessageId: ERROR_INCORRECT_SIZE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Incorrect size argument.</para>
        /// </summary>
        public const int ERROR_INCORRECT_SIZE = 1462;

        // End of WinUser error codes



        ///////////////////////////
        //                       //
        // Eventlog Status Codes //
        //                       //
        ///////////////////////////


        /// <summary>
        /// <para>// MessageId: ERROR_EVENTLOG_FILE_CORRUPT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The event log file is corrupted.</para>
        /// </summary>
        public const int ERROR_EVENTLOG_FILE_CORRUPT = 1500;

        /// <summary>
        /// <para>// MessageId: ERROR_EVENTLOG_CANT_START</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  No event log file could be opened, so the event logging service did not start.</para>
        /// </summary>
        public const int ERROR_EVENTLOG_CANT_START = 1501;

        /// <summary>
        /// <para>// MessageId: ERROR_LOG_FILE_FULL</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The event log file is full.</para>
        /// </summary>
        public const int ERROR_LOG_FILE_FULL = 1502;

        /// <summary>
        /// <para>// MessageId: ERROR_EVENTLOG_FILE_CHANGED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The event log file has changed between read operations.</para>
        /// </summary>
        public const int ERROR_EVENTLOG_FILE_CHANGED = 1503;

        // End of eventlog error codes



        ///////////////////////////
        //                       //
        // MSI Error Codes       //
        //                       //
        ///////////////////////////


        /// <summary>
        /// <para>// MessageId: ERROR_INSTALL_SERVICE_FAILURE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The Windows Installer Service could not be accessed. This can occur if you are running Windows in  safe mode, or if the Windows Installer is not correctly installed. Contact your support personnel for  assistance.</para>
        /// </summary>
        public const int ERROR_INSTALL_SERVICE_FAILURE = 1601;

        /// <summary>
        /// <para>// MessageId: ERROR_INSTALL_USEREXIT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  User cancelled installation.</para>
        /// </summary>
        public const int ERROR_INSTALL_USEREXIT = 1602;

        /// <summary>
        /// <para>// MessageId: ERROR_INSTALL_FAILURE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Fatal error during installation.</para>
        /// </summary>
        public const int ERROR_INSTALL_FAILURE = 1603;

        /// <summary>
        /// <para>// MessageId: ERROR_INSTALL_SUSPEND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Installation suspended, incomplete.</para>
        /// </summary>
        public const int ERROR_INSTALL_SUSPEND = 1604;

        /// <summary>
        /// <para>// MessageId: ERROR_UNKNOWN_PRODUCT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  This action is only valid for products that are currently installed.</para>
        /// </summary>
        public const int ERROR_UNKNOWN_PRODUCT = 1605;

        /// <summary>
        /// <para>// MessageId: ERROR_UNKNOWN_FEATURE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Feature ID not registered.</para>
        /// </summary>
        public const int ERROR_UNKNOWN_FEATURE = 1606;

        /// <summary>
        /// <para>// MessageId: ERROR_UNKNOWN_COMPONENT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Component ID not registered.</para>
        /// </summary>
        public const int ERROR_UNKNOWN_COMPONENT = 1607;

        /// <summary>
        /// <para>// MessageId: ERROR_UNKNOWN_PROPERTY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Unknown property.</para>
        /// </summary>
        public const int ERROR_UNKNOWN_PROPERTY = 1608;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_HANDLE_STATE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Handle is in an invalid state.</para>
        /// </summary>
        public const int ERROR_INVALID_HANDLE_STATE = 1609;

        /// <summary>
        /// <para>// MessageId: ERROR_BAD_CONFIGURATION</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The configuration data for this product is corrupt.  Contact your support personnel.</para>
        /// </summary>
        public const int ERROR_BAD_CONFIGURATION = 1610;

        /// <summary>
        /// <para>// MessageId: ERROR_INDEX_ABSENT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Component qualifier not present.</para>
        /// </summary>
        public const int ERROR_INDEX_ABSENT = 1611;

        /// <summary>
        /// <para>// MessageId: ERROR_INSTALL_SOURCE_ABSENT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The installation source for this product is not available.  Verify that the source exists and that  you can access it.</para>
        /// </summary>
        public const int ERROR_INSTALL_SOURCE_ABSENT = 1612;

        /// <summary>
        /// <para>// MessageId: ERROR_INSTALL_PACKAGE_VERSION</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  This installation package cannot be installed by the Windows Installer service.  You must install  a Windows service pack that contains a newer version of the Windows Installer service.</para>
        /// </summary>
        public const int ERROR_INSTALL_PACKAGE_VERSION = 1613;

        /// <summary>
        /// <para>// MessageId: ERROR_PRODUCT_UNINSTALLED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Product is uninstalled.</para>
        /// </summary>
        public const int ERROR_PRODUCT_UNINSTALLED = 1614;

        /// <summary>
        /// <para>// MessageId: ERROR_BAD_QUERY_SYNTAX</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  SQL query syntax invalid or unsupported.</para>
        /// </summary>
        public const int ERROR_BAD_QUERY_SYNTAX = 1615;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_FIELD</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Record field does not exist.</para>
        /// </summary>
        public const int ERROR_INVALID_FIELD = 1616;

        /// <summary>
        /// <para>// MessageId: ERROR_DEVICE_REMOVED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The device has been removed.</para>
        /// </summary>
        public const int ERROR_DEVICE_REMOVED = 1617;

        /// <summary>
        /// <para>// MessageId: ERROR_INSTALL_ALREADY_RUNNING</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Another installation is already in progress.  Complete that installation before proceeding with  this install.</para>
        /// </summary>
        public const int ERROR_INSTALL_ALREADY_RUNNING = 1618;

        /// <summary>
        /// <para>// MessageId: ERROR_INSTALL_PACKAGE_OPEN_FAILED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  This installation package could not be opened.  Verify that the package exists and that you can  access it, or contact the application vendor to verify that this is a valid Windows Installer package.</para>
        /// </summary>
        public const int ERROR_INSTALL_PACKAGE_OPEN_FAILED = 1619;

        /// <summary>
        /// <para>// MessageId: ERROR_INSTALL_PACKAGE_INVALID</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  This installation package could not be opened.  Contact the application vendor to verify that this  is a valid Windows Installer package.</para>
        /// </summary>
        public const int ERROR_INSTALL_PACKAGE_INVALID = 1620;

        /// <summary>
        /// <para>// MessageId: ERROR_INSTALL_UI_FAILURE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  There was an error starting the Windows Installer service user interface.  Contact your support  personnel.</para>
        /// </summary>
        public const int ERROR_INSTALL_UI_FAILURE = 1621;

        /// <summary>
        /// <para>// MessageId: ERROR_INSTALL_LOG_FAILURE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Error opening installation log file. Verify that the specified log file location exists and that  you can write to it.</para>
        /// </summary>
        public const int ERROR_INSTALL_LOG_FAILURE = 1622;

        /// <summary>
        /// <para>// MessageId: ERROR_INSTALL_LANGUAGE_UNSUPPORTED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The language of this installation package is not supported by your system.</para>
        /// </summary>
        public const int ERROR_INSTALL_LANGUAGE_UNSUPPORTED = 1623;

        /// <summary>
        /// <para>// MessageId: ERROR_INSTALL_TRANSFORM_FAILURE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Error applying transforms.  Verify that the specified transform paths are valid.</para>
        /// </summary>
        public const int ERROR_INSTALL_TRANSFORM_FAILURE = 1624;

        /// <summary>
        /// <para>// MessageId: ERROR_INSTALL_PACKAGE_REJECTED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  This installation is forbidden by system policy.  Contact your system administrator.</para>
        /// </summary>
        public const int ERROR_INSTALL_PACKAGE_REJECTED = 1625;

        /// <summary>
        /// <para>// MessageId: ERROR_FUNCTION_NOT_CALLED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Function could not be executed.</para>
        /// </summary>
        public const int ERROR_FUNCTION_NOT_CALLED = 1626;

        /// <summary>
        /// <para>// MessageId: ERROR_FUNCTION_FAILED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Function failed during execution.</para>
        /// </summary>
        public const int ERROR_FUNCTION_FAILED = 1627;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_TABLE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Invalid or unknown table specified.</para>
        /// </summary>
        public const int ERROR_INVALID_TABLE = 1628;

        /// <summary>
        /// <para>// MessageId: ERROR_DATATYPE_MISMATCH</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Data supplied is of wrong type.</para>
        /// </summary>
        public const int ERROR_DATATYPE_MISMATCH = 1629;

        /// <summary>
        /// <para>// MessageId: ERROR_UNSUPPORTED_TYPE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Data of this type is not supported.</para>
        /// </summary>
        public const int ERROR_UNSUPPORTED_TYPE = 1630;

        /// <summary>
        /// <para>// MessageId: ERROR_CREATE_FAILED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The Windows Installer service failed to start.  Contact your support personnel.</para>
        /// </summary>
        public const int ERROR_CREATE_FAILED = 1631;

        /// <summary>
        /// <para>// MessageId: ERROR_INSTALL_TEMP_UNWRITABLE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The Temp folder is on a drive that is full or is inaccessible. Free up space on the drive or  verify that you have write permission on the Temp folder.</para>
        /// </summary>
        public const int ERROR_INSTALL_TEMP_UNWRITABLE = 1632;

        /// <summary>
        /// <para>// MessageId: ERROR_INSTALL_PLATFORM_UNSUPPORTED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  This installation package is not supported by this processor type. Contact your product vendor.</para>
        /// </summary>
        public const int ERROR_INSTALL_PLATFORM_UNSUPPORTED = 1633;

        /// <summary>
        /// <para>// MessageId: ERROR_INSTALL_NOTUSED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Component not used on this computer.</para>
        /// </summary>
        public const int ERROR_INSTALL_NOTUSED = 1634;

        /// <summary>
        /// <para>// MessageId: ERROR_PATCH_PACKAGE_OPEN_FAILED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  This patch package could not be opened.  Verify that the patch package exists and that you can  access it, or contact the application vendor to verify that this is a valid Windows Installer patch  package.</para>
        /// </summary>
        public const int ERROR_PATCH_PACKAGE_OPEN_FAILED = 1635;

        /// <summary>
        /// <para>// MessageId: ERROR_PATCH_PACKAGE_INVALID</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  This patch package could not be opened.  Contact the application vendor to verify that this is a  valid Windows Installer patch package.</para>
        /// </summary>
        public const int ERROR_PATCH_PACKAGE_INVALID = 1636;

        /// <summary>
        /// <para>// MessageId: ERROR_PATCH_PACKAGE_UNSUPPORTED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  This patch package cannot be processed by the Windows Installer service.  You must install a  Windows service pack that contains a newer version of the Windows Installer service.</para>
        /// </summary>
        public const int ERROR_PATCH_PACKAGE_UNSUPPORTED = 1637;

        /// <summary>
        /// <para>// MessageId: ERROR_PRODUCT_VERSION</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Another version of this product is already installed.  Installation of this version cannot  continue.  To configure or remove the existing version of this product, use Add/Remove Programs on the  Control Panel.</para>
        /// </summary>
        public const int ERROR_PRODUCT_VERSION = 1638;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_COMMAND_LINE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Invalid command line argument.  Consult the Windows Installer SDK for detailed command line help.</para>
        /// </summary>
        public const int ERROR_INVALID_COMMAND_LINE = 1639;

        /// <summary>
        /// <para>// MessageId: ERROR_INSTALL_REMOTE_DISALLOWED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Only administrators have permission to add, remove, or configure server software during a Terminal  services remote session. If you want to install or configure software on the server, contact your  network administrator.</para>
        /// </summary>
        public const int ERROR_INSTALL_REMOTE_DISALLOWED = 1640;

        /// <summary>
        /// <para>// MessageId: ERROR_SUCCESS_REBOOT_INITIATED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The requested operation completed successfully.  The system will be restarted so the changes can  take effect.</para>
        /// </summary>
        public const int ERROR_SUCCESS_REBOOT_INITIATED = 1641;

        /// <summary>
        /// <para>// MessageId: ERROR_PATCH_TARGET_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The upgrade patch cannot be installed by the Windows Installer service because the program to be  upgraded may be missing, or the upgrade patch may update a different version of the program. Verify  that the program to be upgraded exists on your computer an</para>
        /// <para>//  d that you have the correct upgrade patch.</para>
        /// </summary>
        public const int ERROR_PATCH_TARGET_NOT_FOUND = 1642;

        /// <summary>
        /// <para>// MessageId: ERROR_PATCH_PACKAGE_REJECTED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The patch package is not permitted by software restriction policy.</para>
        /// </summary>
        public const int ERROR_PATCH_PACKAGE_REJECTED = 1643;

        /// <summary>
        /// <para>// MessageId: ERROR_INSTALL_TRANSFORM_REJECTED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  One or more customizations are not permitted by software restriction policy.</para>
        /// </summary>
        public const int ERROR_INSTALL_TRANSFORM_REJECTED = 1644;

        /// <summary>
        /// <para>// MessageId: ERROR_INSTALL_REMOTE_PROHIBITED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The Windows Installer does not permit installation from a Remote Desktop Connection.</para>
        /// </summary>
        public const int ERROR_INSTALL_REMOTE_PROHIBITED = 1645;

        // End of MSI error codes



        ///////////////////////////
        //                       //
        //   RPC Status Codes    //
        //                       //
        ///////////////////////////


        /// <summary>
        /// <para>// MessageId: RPC_S_INVALID_STRING_BINDING</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The string binding is invalid.</para>
        /// </summary>
        public const int RPC_S_INVALID_STRING_BINDING = 1700;

        /// <summary>
        /// <para>// MessageId: RPC_S_WRONG_KIND_OF_BINDING</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The binding handle is not the correct type.</para>
        /// </summary>
        public const int RPC_S_WRONG_KIND_OF_BINDING = 1701;

        /// <summary>
        /// <para>// MessageId: RPC_S_INVALID_BINDING</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The binding handle is invalid.</para>
        /// </summary>
        public const int RPC_S_INVALID_BINDING = 1702;

        /// <summary>
        /// <para>// MessageId: RPC_S_PROTSEQ_NOT_SUPPORTED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The RPC protocol sequence is not supported.</para>
        /// </summary>
        public const int RPC_S_PROTSEQ_NOT_SUPPORTED = 1703;

        /// <summary>
        /// <para>// MessageId: RPC_S_INVALID_RPC_PROTSEQ</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The RPC protocol sequence is invalid.</para>
        /// </summary>
        public const int RPC_S_INVALID_RPC_PROTSEQ = 1704;

        /// <summary>
        /// <para>// MessageId: RPC_S_INVALID_STRING_UUID</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The string universal unique identifier (UUID) is invalid.</para>
        /// </summary>
        public const int RPC_S_INVALID_STRING_UUID = 1705;

        /// <summary>
        /// <para>// MessageId: RPC_S_INVALID_ENDPOINT_FORMAT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The endpoint format is invalid.</para>
        /// </summary>
        public const int RPC_S_INVALID_ENDPOINT_FORMAT = 1706;

        /// <summary>
        /// <para>// MessageId: RPC_S_INVALID_NET_ADDR</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The network address is invalid.</para>
        /// </summary>
        public const int RPC_S_INVALID_NET_ADDR = 1707;

        /// <summary>
        /// <para>// MessageId: RPC_S_NO_ENDPOINT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  No endpoint was found.</para>
        /// </summary>
        public const int RPC_S_NO_ENDPOINT_FOUND = 1708;

        /// <summary>
        /// <para>// MessageId: RPC_S_INVALID_TIMEOUT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The timeout value is invalid.</para>
        /// </summary>
        public const int RPC_S_INVALID_TIMEOUT = 1709;

        /// <summary>
        /// <para>// MessageId: RPC_S_OBJECT_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The object universal unique identifier (UUID) was not found.</para>
        /// </summary>
        public const int RPC_S_OBJECT_NOT_FOUND = 1710;

        /// <summary>
        /// <para>// MessageId: RPC_S_ALREADY_REGISTERED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The object universal unique identifier (UUID) has already been registered.</para>
        /// </summary>
        public const int RPC_S_ALREADY_REGISTERED = 1711;

        /// <summary>
        /// <para>// MessageId: RPC_S_TYPE_ALREADY_REGISTERED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The type universal unique identifier (UUID) has already been registered.</para>
        /// </summary>
        public const int RPC_S_TYPE_ALREADY_REGISTERED = 1712;

        /// <summary>
        /// <para>// MessageId: RPC_S_ALREADY_LISTENING</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The RPC server is already listening.</para>
        /// </summary>
        public const int RPC_S_ALREADY_LISTENING = 1713;

        /// <summary>
        /// <para>// MessageId: RPC_S_NO_PROTSEQS_REGISTERED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  No protocol sequences have been registered.</para>
        /// </summary>
        public const int RPC_S_NO_PROTSEQS_REGISTERED = 1714;

        /// <summary>
        /// <para>// MessageId: RPC_S_NOT_LISTENING</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The RPC server is not listening.</para>
        /// </summary>
        public const int RPC_S_NOT_LISTENING = 1715;

        /// <summary>
        /// <para>// MessageId: RPC_S_UNKNOWN_MGR_TYPE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The manager type is unknown.</para>
        /// </summary>
        public const int RPC_S_UNKNOWN_MGR_TYPE = 1716;

        /// <summary>
        /// <para>// MessageId: RPC_S_UNKNOWN_IF</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The interface is unknown.</para>
        /// </summary>
        public const int RPC_S_UNKNOWN_IF = 1717;

        /// <summary>
        /// <para>// MessageId: RPC_S_NO_BINDINGS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  There are no bindings.</para>
        /// </summary>
        public const int RPC_S_NO_BINDINGS = 1718;

        /// <summary>
        /// <para>// MessageId: RPC_S_NO_PROTSEQS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  There are no protocol sequences.</para>
        /// </summary>
        public const int RPC_S_NO_PROTSEQS = 1719;

        /// <summary>
        /// <para>// MessageId: RPC_S_CANT_CREATE_ENDPOINT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The endpoint cannot be created.</para>
        /// </summary>
        public const int RPC_S_CANT_CREATE_ENDPOINT = 1720;

        /// <summary>
        /// <para>// MessageId: RPC_S_OUT_OF_RESOURCES</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Not enough resources are available to complete this operation.</para>
        /// </summary>
        public const int RPC_S_OUT_OF_RESOURCES = 1721;

        /// <summary>
        /// <para>// MessageId: RPC_S_SERVER_UNAVAILABLE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The RPC server is unavailable.</para>
        /// </summary>
        public const int RPC_S_SERVER_UNAVAILABLE = 1722;

        /// <summary>
        /// <para>// MessageId: RPC_S_SERVER_TOO_BUSY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The RPC server is too busy to complete this operation.</para>
        /// </summary>
        public const int RPC_S_SERVER_TOO_BUSY = 1723;

        /// <summary>
        /// <para>// MessageId: RPC_S_INVALID_NETWORK_OPTIONS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The network options are invalid.</para>
        /// </summary>
        public const int RPC_S_INVALID_NETWORK_OPTIONS = 1724;

        /// <summary>
        /// <para>// MessageId: RPC_S_NO_CALL_ACTIVE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  There are no remote procedure calls active on this thread.</para>
        /// </summary>
        public const int RPC_S_NO_CALL_ACTIVE = 1725;

        /// <summary>
        /// <para>// MessageId: RPC_S_CALL_FAILED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The remote procedure call failed.</para>
        /// </summary>
        public const int RPC_S_CALL_FAILED = 1726;

        /// <summary>
        /// <para>// MessageId: RPC_S_CALL_FAILED_DNE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The remote procedure call failed and did not execute.</para>
        /// </summary>
        public const int RPC_S_CALL_FAILED_DNE = 1727;

        /// <summary>
        /// <para>// MessageId: RPC_S_PROTOCOL_ERROR</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A remote procedure call (RPC) protocol error occurred.</para>
        /// </summary>
        public const int RPC_S_PROTOCOL_ERROR = 1728;

        /// <summary>
        /// <para>// MessageId: RPC_S_UNSUPPORTED_TRANS_SYN</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The transfer syntax is not supported by the RPC server.</para>
        /// </summary>
        public const int RPC_S_UNSUPPORTED_TRANS_SYN = 1730;

        /// <summary>
        /// <para>// MessageId: RPC_S_UNSUPPORTED_TYPE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The universal unique identifier (UUID) type is not supported.</para>
        /// </summary>
        public const int RPC_S_UNSUPPORTED_TYPE = 1732;

        /// <summary>
        /// <para>// MessageId: RPC_S_INVALID_TAG</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The tag is invalid.</para>
        /// </summary>
        public const int RPC_S_INVALID_TAG = 1733;

        /// <summary>
        /// <para>// MessageId: RPC_S_INVALID_BOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The array bounds are invalid.</para>
        /// </summary>
        public const int RPC_S_INVALID_BOUND = 1734;

        /// <summary>
        /// <para>// MessageId: RPC_S_NO_ENTRY_NAME</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The binding does not contain an entry name.</para>
        /// </summary>
        public const int RPC_S_NO_ENTRY_NAME = 1735;

        /// <summary>
        /// <para>// MessageId: RPC_S_INVALID_NAME_SYNTAX</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The name syntax is invalid.</para>
        /// </summary>
        public const int RPC_S_INVALID_NAME_SYNTAX = 1736;

        /// <summary>
        /// <para>// MessageId: RPC_S_UNSUPPORTED_NAME_SYNTAX</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The name syntax is not supported.</para>
        /// </summary>
        public const int RPC_S_UNSUPPORTED_NAME_SYNTAX = 1737;

        /// <summary>
        /// <para>// MessageId: RPC_S_UUID_NO_ADDRESS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  No network address is available to use to construct a universal unique identifier (UUID).</para>
        /// </summary>
        public const int RPC_S_UUID_NO_ADDRESS = 1739;

        /// <summary>
        /// <para>// MessageId: RPC_S_DUPLICATE_ENDPOINT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The endpoint is a duplicate.</para>
        /// </summary>
        public const int RPC_S_DUPLICATE_ENDPOINT = 1740;

        /// <summary>
        /// <para>// MessageId: RPC_S_UNKNOWN_AUTHN_TYPE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The authentication type is unknown.</para>
        /// </summary>
        public const int RPC_S_UNKNOWN_AUTHN_TYPE = 1741;

        /// <summary>
        /// <para>// MessageId: RPC_S_MAX_CALLS_TOO_SMALL</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The maximum number of calls is too small.</para>
        /// </summary>
        public const int RPC_S_MAX_CALLS_TOO_SMALL = 1742;

        /// <summary>
        /// <para>// MessageId: RPC_S_STRING_TOO_LONG</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The string is too long.</para>
        /// </summary>
        public const int RPC_S_STRING_TOO_LONG = 1743;

        /// <summary>
        /// <para>// MessageId: RPC_S_PROTSEQ_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The RPC protocol sequence was not found.</para>
        /// </summary>
        public const int RPC_S_PROTSEQ_NOT_FOUND = 1744;

        /// <summary>
        /// <para>// MessageId: RPC_S_PROCNUM_OUT_OF_RANGE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The procedure number is out of range.</para>
        /// </summary>
        public const int RPC_S_PROCNUM_OUT_OF_RANGE = 1745;

        /// <summary>
        /// <para>// MessageId: RPC_S_BINDING_HAS_NO_AUTH</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The binding does not contain any authentication information.</para>
        /// </summary>
        public const int RPC_S_BINDING_HAS_NO_AUTH = 1746;

        /// <summary>
        /// <para>// MessageId: RPC_S_UNKNOWN_AUTHN_SERVICE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The authentication service is unknown.</para>
        /// </summary>
        public const int RPC_S_UNKNOWN_AUTHN_SERVICE = 1747;

        /// <summary>
        /// <para>// MessageId: RPC_S_UNKNOWN_AUTHN_LEVEL</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The authentication level is unknown.</para>
        /// </summary>
        public const int RPC_S_UNKNOWN_AUTHN_LEVEL = 1748;

        /// <summary>
        /// <para>// MessageId: RPC_S_INVALID_AUTH_IDENTITY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The security context is invalid.</para>
        /// </summary>
        public const int RPC_S_INVALID_AUTH_IDENTITY = 1749;

        /// <summary>
        /// <para>// MessageId: RPC_S_UNKNOWN_AUTHZ_SERVICE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The authorization service is unknown.</para>
        /// </summary>
        public const int RPC_S_UNKNOWN_AUTHZ_SERVICE = 1750;

        /// <summary>
        /// <para>// MessageId: EPT_S_INVALID_ENTRY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The entry is invalid.</para>
        /// </summary>
        public const int EPT_S_INVALID_ENTRY = 1751;

        /// <summary>
        /// <para>// MessageId: EPT_S_CANT_PERFORM_OP</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The server endpoint cannot perform the operation.</para>
        /// </summary>
        public const int EPT_S_CANT_PERFORM_OP = 1752;

        /// <summary>
        /// <para>// MessageId: EPT_S_NOT_REGISTERED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  There are no more endpoints available from the endpoint mapper.</para>
        /// </summary>
        public const int EPT_S_NOT_REGISTERED = 1753;

        /// <summary>
        /// <para>// MessageId: RPC_S_NOTHING_TO_EXPORT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  No interfaces have been exported.</para>
        /// </summary>
        public const int RPC_S_NOTHING_TO_EXPORT = 1754;

        /// <summary>
        /// <para>// MessageId: RPC_S_INCOMPLETE_NAME</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The entry name is incomplete.</para>
        /// </summary>
        public const int RPC_S_INCOMPLETE_NAME = 1755;

        /// <summary>
        /// <para>// MessageId: RPC_S_INVALID_VERS_OPTION</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The version option is invalid.</para>
        /// </summary>
        public const int RPC_S_INVALID_VERS_OPTION = 1756;

        /// <summary>
        /// <para>// MessageId: RPC_S_NO_MORE_MEMBERS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  There are no more members.</para>
        /// </summary>
        public const int RPC_S_NO_MORE_MEMBERS = 1757;

        /// <summary>
        /// <para>// MessageId: RPC_S_NOT_ALL_OBJS_UNEXPORTED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  There is nothing to unexport.</para>
        /// </summary>
        public const int RPC_S_NOT_ALL_OBJS_UNEXPORTED = 1758;

        /// <summary>
        /// <para>// MessageId: RPC_S_INTERFACE_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The interface was not found.</para>
        /// </summary>
        public const int RPC_S_INTERFACE_NOT_FOUND = 1759;

        /// <summary>
        /// <para>// MessageId: RPC_S_ENTRY_ALREADY_EXISTS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The entry already exists.</para>
        /// </summary>
        public const int RPC_S_ENTRY_ALREADY_EXISTS = 1760;

        /// <summary>
        /// <para>// MessageId: RPC_S_ENTRY_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The entry is not found.</para>
        /// </summary>
        public const int RPC_S_ENTRY_NOT_FOUND = 1761;

        /// <summary>
        /// <para>// MessageId: RPC_S_NAME_SERVICE_UNAVAILABLE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The name service is unavailable.</para>
        /// </summary>
        public const int RPC_S_NAME_SERVICE_UNAVAILABLE = 1762;

        /// <summary>
        /// <para>// MessageId: RPC_S_INVALID_NAF_ID</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The network address family is invalid.</para>
        /// </summary>
        public const int RPC_S_INVALID_NAF_ID = 1763;

        /// <summary>
        /// <para>// MessageId: RPC_S_CANNOT_SUPPORT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The requested operation is not supported.</para>
        /// </summary>
        public const int RPC_S_CANNOT_SUPPORT = 1764;

        /// <summary>
        /// <para>// MessageId: RPC_S_NO_CONTEXT_AVAILABLE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  No security context is available to allow impersonation.</para>
        /// </summary>
        public const int RPC_S_NO_CONTEXT_AVAILABLE = 1765;

        /// <summary>
        /// <para>// MessageId: RPC_S_INTERNAL_ERROR</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An internal error occurred in a remote procedure call (RPC).</para>
        /// </summary>
        public const int RPC_S_INTERNAL_ERROR = 1766;

        /// <summary>
        /// <para>// MessageId: RPC_S_ZERO_DIVIDE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The RPC server attempted an integer division by zero.</para>
        /// </summary>
        public const int RPC_S_ZERO_DIVIDE = 1767;

        /// <summary>
        /// <para>// MessageId: RPC_S_ADDRESS_ERROR</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An addressing error occurred in the RPC server.</para>
        /// </summary>
        public const int RPC_S_ADDRESS_ERROR = 1768;

        /// <summary>
        /// <para>// MessageId: RPC_S_FP_DIV_ZERO</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A floating-point operation at the RPC server caused a division by zero.</para>
        /// </summary>
        public const int RPC_S_FP_DIV_ZERO = 1769;

        /// <summary>
        /// <para>// MessageId: RPC_S_FP_UNDERFLOW</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A floating-point underflow occurred at the RPC server.</para>
        /// </summary>
        public const int RPC_S_FP_UNDERFLOW = 1770;

        /// <summary>
        /// <para>// MessageId: RPC_S_FP_OVERFLOW</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A floating-point overflow occurred at the RPC server.</para>
        /// </summary>
        public const int RPC_S_FP_OVERFLOW = 1771;

        /// <summary>
        /// <para>// MessageId: RPC_X_NO_MORE_ENTRIES</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The list of RPC servers available for the binding of auto handles has been exhausted.</para>
        /// </summary>
        public const int RPC_X_NO_MORE_ENTRIES = 1772;

        /// <summary>
        /// <para>// MessageId: RPC_X_SS_CHAR_TRANS_OPEN_FAIL</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Unable to open the character translation table file.</para>
        /// </summary>
        public const int RPC_X_SS_CHAR_TRANS_OPEN_FAIL = 1773;

        /// <summary>
        /// <para>// MessageId: RPC_X_SS_CHAR_TRANS_SHORT_FILE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The file containing the character translation table has fewer than 512 bytes.</para>
        /// </summary>
        public const int RPC_X_SS_CHAR_TRANS_SHORT_FILE = 1774;

        /// <summary>
        /// <para>// MessageId: RPC_X_SS_IN_NULL_CONTEXT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A null context handle was passed from the client to the host during a remote procedure call.</para>
        /// </summary>
        public const int RPC_X_SS_IN_NULL_CONTEXT = 1775;

        /// <summary>
        /// <para>// MessageId: RPC_X_SS_CONTEXT_DAMAGED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The context handle changed during a remote procedure call.</para>
        /// </summary>
        public const int RPC_X_SS_CONTEXT_DAMAGED = 1777;

        /// <summary>
        /// <para>// MessageId: RPC_X_SS_HANDLES_MISMATCH</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The binding handles passed to a remote procedure call do not match.</para>
        /// </summary>
        public const int RPC_X_SS_HANDLES_MISMATCH = 1778;

        /// <summary>
        /// <para>// MessageId: RPC_X_SS_CANNOT_GET_CALL_HANDLE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The stub is unable to get the remote procedure call handle.</para>
        /// </summary>
        public const int RPC_X_SS_CANNOT_GET_CALL_HANDLE = 1779;

        /// <summary>
        /// <para>// MessageId: RPC_X_NULL_REF_POINTER</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A null reference pointer was passed to the stub.</para>
        /// </summary>
        public const int RPC_X_NULL_REF_POINTER = 1780;

        /// <summary>
        /// <para>// MessageId: RPC_X_ENUM_VALUE_OUT_OF_RANGE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The enumeration value is out of range.</para>
        /// </summary>
        public const int RPC_X_ENUM_VALUE_OUT_OF_RANGE = 1781;

        /// <summary>
        /// <para>// MessageId: RPC_X_BYTE_COUNT_TOO_SMALL</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The byte count is too small.</para>
        /// </summary>
        public const int RPC_X_BYTE_COUNT_TOO_SMALL = 1782;

        /// <summary>
        /// <para>// MessageId: RPC_X_BAD_STUB_DATA</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The stub received bad data.</para>
        /// </summary>
        public const int RPC_X_BAD_STUB_DATA = 1783;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_USER_BUFFER</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The supplied user buffer is not valid for the requested operation.</para>
        /// </summary>
        public const int ERROR_INVALID_USER_BUFFER = 1784;

        /// <summary>
        /// <para>// MessageId: ERROR_UNRECOGNIZED_MEDIA</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The disk media is not recognized. It may not be formatted.</para>
        /// </summary>
        public const int ERROR_UNRECOGNIZED_MEDIA = 1785;

        /// <summary>
        /// <para>// MessageId: ERROR_NO_TRUST_LSA_SECRET</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The workstation does not have a trust secret.</para>
        /// </summary>
        public const int ERROR_NO_TRUST_LSA_SECRET = 1786;

        /// <summary>
        /// <para>// MessageId: ERROR_NO_TRUST_SAM_ACCOUNT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The security database on the server does not have a computer account for this workstation trust  relationship.</para>
        /// </summary>
        public const int ERROR_NO_TRUST_SAM_ACCOUNT = 1787;

        /// <summary>
        /// <para>// MessageId: ERROR_TRUSTED_DOMAIN_FAILURE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The trust relationship between the primary domain and the trusted domain failed.</para>
        /// </summary>
        public const int ERROR_TRUSTED_DOMAIN_FAILURE = 1788;

        /// <summary>
        /// <para>// MessageId: ERROR_TRUSTED_RELATIONSHIP_FAILURE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The trust relationship between this workstation and the primary domain failed.</para>
        /// </summary>
        public const int ERROR_TRUSTED_RELATIONSHIP_FAILURE = 1789;

        /// <summary>
        /// <para>// MessageId: ERROR_TRUST_FAILURE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The network logon failed.</para>
        /// </summary>
        public const int ERROR_TRUST_FAILURE = 1790;

        /// <summary>
        /// <para>// MessageId: RPC_S_CALL_IN_PROGRESS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A remote procedure call is already in progress for this thread.</para>
        /// </summary>
        public const int RPC_S_CALL_IN_PROGRESS = 1791;

        /// <summary>
        /// <para>// MessageId: ERROR_NETLOGON_NOT_STARTED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An attempt was made to logon, but the network logon service was not started.</para>
        /// </summary>
        public const int ERROR_NETLOGON_NOT_STARTED = 1792;

        /// <summary>
        /// <para>// MessageId: ERROR_ACCOUNT_EXPIRED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The user's account has expired.</para>
        /// </summary>
        public const int ERROR_ACCOUNT_EXPIRED = 1793;

        /// <summary>
        /// <para>// MessageId: ERROR_REDIRECTOR_HAS_OPEN_HANDLES</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The redirector is in use and cannot be unloaded.</para>
        /// </summary>
        public const int ERROR_REDIRECTOR_HAS_OPEN_HANDLES = 1794;

        /// <summary>
        /// <para>// MessageId: ERROR_PRINTER_DRIVER_ALREADY_INSTALLED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified printer driver is already installed.</para>
        /// </summary>
        public const int ERROR_PRINTER_DRIVER_ALREADY_INSTALLED = 1795;

        /// <summary>
        /// <para>// MessageId: ERROR_UNKNOWN_PORT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified port is unknown.</para>
        /// </summary>
        public const int ERROR_UNKNOWN_PORT = 1796;

        /// <summary>
        /// <para>// MessageId: ERROR_UNKNOWN_PRINTER_DRIVER</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The printer driver is unknown.</para>
        /// </summary>
        public const int ERROR_UNKNOWN_PRINTER_DRIVER = 1797;

        /// <summary>
        /// <para>// MessageId: ERROR_UNKNOWN_PRINTPROCESSOR</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The print processor is unknown.</para>
        /// </summary>
        public const int ERROR_UNKNOWN_PRINTPROCESSOR = 1798;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_SEPARATOR_FILE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified separator file is invalid.</para>
        /// </summary>
        public const int ERROR_INVALID_SEPARATOR_FILE = 1799;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_PRIORITY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified priority is invalid.</para>
        /// </summary>
        public const int ERROR_INVALID_PRIORITY = 1800;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_PRINTER_NAME</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The printer name is invalid.</para>
        /// </summary>
        public const int ERROR_INVALID_PRINTER_NAME = 1801;

        /// <summary>
        /// <para>// MessageId: ERROR_PRINTER_ALREADY_EXISTS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The printer already exists.</para>
        /// </summary>
        public const int ERROR_PRINTER_ALREADY_EXISTS = 1802;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_PRINTER_COMMAND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The printer command is invalid.</para>
        /// </summary>
        public const int ERROR_INVALID_PRINTER_COMMAND = 1803;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_DATATYPE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified datatype is invalid.</para>
        /// </summary>
        public const int ERROR_INVALID_DATATYPE = 1804;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_ENVIRONMENT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The environment specified is invalid.</para>
        /// </summary>
        public const int ERROR_INVALID_ENVIRONMENT = 1805;

        /// <summary>
        /// <para>// MessageId: RPC_S_NO_MORE_BINDINGS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  There are no more bindings.</para>
        /// </summary>
        public const int RPC_S_NO_MORE_BINDINGS = 1806;

        /// <summary>
        /// <para>// MessageId: ERROR_NOLOGON_INTERDOMAIN_TRUST_ACCOUNT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The account used is an interdomain trust account. Use your global user account or local user  account to access this server.</para>
        /// </summary>
        public const int ERROR_NOLOGON_INTERDOMAIN_TRUST_ACCOUNT = 1807;

        /// <summary>
        /// <para>// MessageId: ERROR_NOLOGON_WORKSTATION_TRUST_ACCOUNT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The account used is a computer account. Use your global user account or local user account to  access this server.</para>
        /// </summary>
        public const int ERROR_NOLOGON_WORKSTATION_TRUST_ACCOUNT = 1808;

        /// <summary>
        /// <para>// MessageId: ERROR_NOLOGON_SERVER_TRUST_ACCOUNT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The account used is a server trust account. Use your global user account or local user account to  access this server.</para>
        /// </summary>
        public const int ERROR_NOLOGON_SERVER_TRUST_ACCOUNT = 1809;

        /// <summary>
        /// <para>// MessageId: ERROR_DOMAIN_TRUST_INCONSISTENT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The name or security ID (SID) of the domain specified is inconsistent with the trust information  for that domain.</para>
        /// </summary>
        public const int ERROR_DOMAIN_TRUST_INCONSISTENT = 1810;

        /// <summary>
        /// <para>// MessageId: ERROR_SERVER_HAS_OPEN_HANDLES</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The server is in use and cannot be unloaded.</para>
        /// </summary>
        public const int ERROR_SERVER_HAS_OPEN_HANDLES = 1811;

        /// <summary>
        /// <para>// MessageId: ERROR_RESOURCE_DATA_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified image file did not contain a resource section.</para>
        /// </summary>
        public const int ERROR_RESOURCE_DATA_NOT_FOUND = 1812;

        /// <summary>
        /// <para>// MessageId: ERROR_RESOURCE_TYPE_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified resource type cannot be found in the image file.</para>
        /// </summary>
        public const int ERROR_RESOURCE_TYPE_NOT_FOUND = 1813;

        /// <summary>
        /// <para>// MessageId: ERROR_RESOURCE_NAME_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified resource name cannot be found in the image file.</para>
        /// </summary>
        public const int ERROR_RESOURCE_NAME_NOT_FOUND = 1814;

        /// <summary>
        /// <para>// MessageId: ERROR_RESOURCE_LANG_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified resource language ID cannot be found in the image file.</para>
        /// </summary>
        public const int ERROR_RESOURCE_LANG_NOT_FOUND = 1815;

        /// <summary>
        /// <para>// MessageId: ERROR_NOT_ENOUGH_QUOTA</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Not enough quota is available to process this command.</para>
        /// </summary>
        public const int ERROR_NOT_ENOUGH_QUOTA = 1816;

        /// <summary>
        /// <para>// MessageId: RPC_S_NO_INTERFACES</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  No interfaces have been registered.</para>
        /// </summary>
        public const int RPC_S_NO_INTERFACES = 1817;

        /// <summary>
        /// <para>// MessageId: RPC_S_CALL_CANCELLED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The remote procedure call was cancelled.</para>
        /// </summary>
        public const int RPC_S_CALL_CANCELLED = 1818;

        /// <summary>
        /// <para>// MessageId: RPC_S_BINDING_INCOMPLETE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The binding handle does not contain all required information.</para>
        /// </summary>
        public const int RPC_S_BINDING_INCOMPLETE = 1819;

        /// <summary>
        /// <para>// MessageId: RPC_S_COMM_FAILURE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A communications failure occurred during a remote procedure call.</para>
        /// </summary>
        public const int RPC_S_COMM_FAILURE = 1820;

        /// <summary>
        /// <para>// MessageId: RPC_S_UNSUPPORTED_AUTHN_LEVEL</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The requested authentication level is not supported.</para>
        /// </summary>
        public const int RPC_S_UNSUPPORTED_AUTHN_LEVEL = 1821;

        /// <summary>
        /// <para>// MessageId: RPC_S_NO_PRINC_NAME</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  No principal name registered.</para>
        /// </summary>
        public const int RPC_S_NO_PRINC_NAME = 1822;

        /// <summary>
        /// <para>// MessageId: RPC_S_NOT_RPC_ERROR</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The error specified is not a valid Windows RPC error code.</para>
        /// </summary>
        public const int RPC_S_NOT_RPC_ERROR = 1823;

        /// <summary>
        /// <para>// MessageId: RPC_S_UUID_LOCAL_ONLY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A UUID that is valid only on this computer has been allocated.</para>
        /// </summary>
        public const int RPC_S_UUID_LOCAL_ONLY = 1824;

        /// <summary>
        /// <para>// MessageId: RPC_S_SEC_PKG_ERROR</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A security package specific error occurred.</para>
        /// </summary>
        public const int RPC_S_SEC_PKG_ERROR = 1825;

        /// <summary>
        /// <para>// MessageId: RPC_S_NOT_CANCELLED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Thread is not canceled.</para>
        /// </summary>
        public const int RPC_S_NOT_CANCELLED = 1826;

        /// <summary>
        /// <para>// MessageId: RPC_X_INVALID_ES_ACTION</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Invalid operation on the encoding/decoding handle.</para>
        /// </summary>
        public const int RPC_X_INVALID_ES_ACTION = 1827;

        /// <summary>
        /// <para>// MessageId: RPC_X_WRONG_ES_VERSION</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Incompatible version of the serializing package.</para>
        /// </summary>
        public const int RPC_X_WRONG_ES_VERSION = 1828;

        /// <summary>
        /// <para>// MessageId: RPC_X_WRONG_STUB_VERSION</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Incompatible version of the RPC stub.</para>
        /// </summary>
        public const int RPC_X_WRONG_STUB_VERSION = 1829;

        /// <summary>
        /// <para>// MessageId: RPC_X_INVALID_PIPE_OBJECT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The RPC pipe object is invalid or corrupted.</para>
        /// </summary>
        public const int RPC_X_INVALID_PIPE_OBJECT = 1830;

        /// <summary>
        /// <para>// MessageId: RPC_X_WRONG_PIPE_ORDER</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An invalid operation was attempted on an RPC pipe object.</para>
        /// </summary>
        public const int RPC_X_WRONG_PIPE_ORDER = 1831;

        /// <summary>
        /// <para>// MessageId: RPC_X_WRONG_PIPE_VERSION</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Unsupported RPC pipe version.</para>
        /// </summary>
        public const int RPC_X_WRONG_PIPE_VERSION = 1832;

        /// <summary>
        /// <para>// MessageId: RPC_S_GROUP_MEMBER_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The group member was not found.</para>
        /// </summary>
        public const int RPC_S_GROUP_MEMBER_NOT_FOUND = 1898;

        /// <summary>
        /// <para>// MessageId: EPT_S_CANT_CREATE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The endpoint mapper database entry could not be created.</para>
        /// </summary>
        public const int EPT_S_CANT_CREATE = 1899;

        /// <summary>
        /// <para>// MessageId: RPC_S_INVALID_OBJECT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The object universal unique identifier (UUID) is the nil UUID.</para>
        /// </summary>
        public const int RPC_S_INVALID_OBJECT = 1900;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_TIME</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified time is invalid.</para>
        /// </summary>
        public const int ERROR_INVALID_TIME = 1901;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_FORM_NAME</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified form name is invalid.</para>
        /// </summary>
        public const int ERROR_INVALID_FORM_NAME = 1902;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_FORM_SIZE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified form size is invalid.</para>
        /// </summary>
        public const int ERROR_INVALID_FORM_SIZE = 1903;

        /// <summary>
        /// <para>// MessageId: ERROR_ALREADY_WAITING</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified printer handle is already being waited on</para>
        /// </summary>
        public const int ERROR_ALREADY_WAITING = 1904;

        /// <summary>
        /// <para>// MessageId: ERROR_PRINTER_DELETED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified printer has been deleted.</para>
        /// </summary>
        public const int ERROR_PRINTER_DELETED = 1905;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_PRINTER_STATE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The state of the printer is invalid.</para>
        /// </summary>
        public const int ERROR_INVALID_PRINTER_STATE = 1906;

        /// <summary>
        /// <para>// MessageId: ERROR_PASSWORD_MUST_CHANGE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The user's password must be changed before logging on the first time.</para>
        /// </summary>
        public const int ERROR_PASSWORD_MUST_CHANGE = 1907;

        /// <summary>
        /// <para>// MessageId: ERROR_DOMAIN_CONTROLLER_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Could not find the domain controller for this domain.</para>
        /// </summary>
        public const int ERROR_DOMAIN_CONTROLLER_NOT_FOUND = 1908;

        /// <summary>
        /// <para>// MessageId: ERROR_ACCOUNT_LOCKED_OUT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The referenced account is currently locked out and may not be logged on to.</para>
        /// </summary>
        public const int ERROR_ACCOUNT_LOCKED_OUT = 1909;

        /// <summary>
        /// <para>// MessageId: OR_INVALID_OXID</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The object exporter specified was not found.</para>
        /// </summary>
        public const int OR_INVALID_OXID = 1910;

        /// <summary>
        /// <para>// MessageId: OR_INVALID_OID</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The object specified was not found.</para>
        /// </summary>
        public const int OR_INVALID_OID = 1911;

        /// <summary>
        /// <para>// MessageId: OR_INVALID_SET</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The object resolver set specified was not found.</para>
        /// </summary>
        public const int OR_INVALID_SET = 1912;

        /// <summary>
        /// <para>// MessageId: RPC_S_SEND_INCOMPLETE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Some data remains to be sent in the request buffer.</para>
        /// </summary>
        public const int RPC_S_SEND_INCOMPLETE = 1913;

        /// <summary>
        /// <para>// MessageId: RPC_S_INVALID_ASYNC_HANDLE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Invalid asynchronous remote procedure call handle.</para>
        /// </summary>
        public const int RPC_S_INVALID_ASYNC_HANDLE = 1914;

        /// <summary>
        /// <para>// MessageId: RPC_S_INVALID_ASYNC_CALL</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Invalid asynchronous RPC call handle for this operation.</para>
        /// </summary>
        public const int RPC_S_INVALID_ASYNC_CALL = 1915;

        /// <summary>
        /// <para>// MessageId: RPC_X_PIPE_CLOSED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The RPC pipe object has already been closed.</para>
        /// </summary>
        public const int RPC_X_PIPE_CLOSED = 1916;

        /// <summary>
        /// <para>// MessageId: RPC_X_PIPE_DISCIPLINE_ERROR</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The RPC call completed before all pipes were processed.</para>
        /// </summary>
        public const int RPC_X_PIPE_DISCIPLINE_ERROR = 1917;

        /// <summary>
        /// <para>// MessageId: RPC_X_PIPE_EMPTY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  No more data is available from the RPC pipe.</para>
        /// </summary>
        public const int RPC_X_PIPE_EMPTY = 1918;

        /// <summary>
        /// <para>// MessageId: ERROR_NO_SITENAME</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  No site name is available for this machine.</para>
        /// </summary>
        public const int ERROR_NO_SITENAME = 1919;

        /// <summary>
        /// <para>// MessageId: ERROR_CANT_ACCESS_FILE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The file can not be accessed by the system.</para>
        /// </summary>
        public const int ERROR_CANT_ACCESS_FILE = 1920;

        /// <summary>
        /// <para>// MessageId: ERROR_CANT_RESOLVE_FILENAME</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The name of the file cannot be resolved by the system.</para>
        /// </summary>
        public const int ERROR_CANT_RESOLVE_FILENAME = 1921;

        /// <summary>
        /// <para>// MessageId: RPC_S_ENTRY_TYPE_MISMATCH</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The entry is not of the expected type.</para>
        /// </summary>
        public const int RPC_S_ENTRY_TYPE_MISMATCH = 1922;

        /// <summary>
        /// <para>// MessageId: RPC_S_NOT_ALL_OBJS_EXPORTED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Not all object UUIDs could be exported to the specified entry.</para>
        /// </summary>
        public const int RPC_S_NOT_ALL_OBJS_EXPORTED = 1923;

        /// <summary>
        /// <para>// MessageId: RPC_S_INTERFACE_NOT_EXPORTED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Interface could not be exported to the specified entry.</para>
        /// </summary>
        public const int RPC_S_INTERFACE_NOT_EXPORTED = 1924;

        /// <summary>
        /// <para>// MessageId: RPC_S_PROFILE_NOT_ADDED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified profile entry could not be added.</para>
        /// </summary>
        public const int RPC_S_PROFILE_NOT_ADDED = 1925;

        /// <summary>
        /// <para>// MessageId: RPC_S_PRF_ELT_NOT_ADDED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified profile element could not be added.</para>
        /// </summary>
        public const int RPC_S_PRF_ELT_NOT_ADDED = 1926;

        /// <summary>
        /// <para>// MessageId: RPC_S_PRF_ELT_NOT_REMOVED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified profile element could not be removed.</para>
        /// </summary>
        public const int RPC_S_PRF_ELT_NOT_REMOVED = 1927;

        /// <summary>
        /// <para>// MessageId: RPC_S_GRP_ELT_NOT_ADDED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The group element could not be added.</para>
        /// </summary>
        public const int RPC_S_GRP_ELT_NOT_ADDED = 1928;

        /// <summary>
        /// <para>// MessageId: RPC_S_GRP_ELT_NOT_REMOVED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The group element could not be removed.</para>
        /// </summary>
        public const int RPC_S_GRP_ELT_NOT_REMOVED = 1929;

        /// <summary>
        /// <para>// MessageId: ERROR_KM_DRIVER_BLOCKED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The printer driver is not compatible with a policy enabled on your computer that blocks NT 4.0  drivers.</para>
        /// </summary>
        public const int ERROR_KM_DRIVER_BLOCKED = 1930;

        /// <summary>
        /// <para>// MessageId: ERROR_CONTEXT_EXPIRED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The context has expired and can no longer be used.</para>
        /// </summary>
        public const int ERROR_CONTEXT_EXPIRED = 1931;

        /// <summary>
        /// <para>// MessageId: ERROR_PER_USER_TRUST_QUOTA_EXCEEDED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The current user's delegated trust creation quota has been exceeded.</para>
        /// </summary>
        public const int ERROR_PER_USER_TRUST_QUOTA_EXCEEDED = 1932;

        /// <summary>
        /// <para>// MessageId: ERROR_ALL_USER_TRUST_QUOTA_EXCEEDED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The total delegated trust creation quota has been exceeded.</para>
        /// </summary>
        public const int ERROR_ALL_USER_TRUST_QUOTA_EXCEEDED = 1933;

        /// <summary>
        /// <para>// MessageId: ERROR_USER_DELETE_TRUST_QUOTA_EXCEEDED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The current user's delegated trust deletion quota has been exceeded.</para>
        /// </summary>
        public const int ERROR_USER_DELETE_TRUST_QUOTA_EXCEEDED = 1934;

        /// <summary>
        /// <para>// MessageId: ERROR_AUTHENTICATION_FIREWALL_FAILED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Logon Failure: The machine you are logging onto is protected by an authentication firewall.  The  specified account is not allowed to authenticate to the machine.</para>
        /// </summary>
        public const int ERROR_AUTHENTICATION_FIREWALL_FAILED = 1935;

        /// <summary>
        /// <para>// MessageId: ERROR_REMOTE_PRINT_CONNECTIONS_BLOCKED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Remote connections to the Print Spooler are blocked by a policy set on your machine.</para>
        /// </summary>
        public const int ERROR_REMOTE_PRINT_CONNECTIONS_BLOCKED = 1936;




        ///////////////////////////
        //                       //
        //   OpenGL Error Code   //
        //                       //
        ///////////////////////////


        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_PIXEL_FORMAT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The pixel format is invalid.</para>
        /// </summary>
        public const int ERROR_INVALID_PIXEL_FORMAT = 2000;

        /// <summary>
        /// <para>// MessageId: ERROR_BAD_DRIVER</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified driver is invalid.</para>
        /// </summary>
        public const int ERROR_BAD_DRIVER = 2001;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_WINDOW_STYLE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The window style or class attribute is invalid for this operation.</para>
        /// </summary>
        public const int ERROR_INVALID_WINDOW_STYLE = 2002;

        /// <summary>
        /// <para>// MessageId: ERROR_METAFILE_NOT_SUPPORTED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The requested metafile operation is not supported.</para>
        /// </summary>
        public const int ERROR_METAFILE_NOT_SUPPORTED = 2003;

        /// <summary>
        /// <para>// MessageId: ERROR_TRANSFORM_NOT_SUPPORTED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The requested transformation operation is not supported.</para>
        /// </summary>
        public const int ERROR_TRANSFORM_NOT_SUPPORTED = 2004;

        /// <summary>
        /// <para>// MessageId: ERROR_CLIPPING_NOT_SUPPORTED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The requested clipping operation is not supported.</para>
        /// </summary>
        public const int ERROR_CLIPPING_NOT_SUPPORTED = 2005;

        // End of OpenGL error codes



        ///////////////////////////////////////////
        //                                       //
        //   Image Color Management Error Code   //
        //                                       //
        ///////////////////////////////////////////


        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_CMM</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified color management module is invalid.</para>
        /// </summary>
        public const int ERROR_INVALID_CMM = 2010;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_PROFILE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified color profile is invalid.</para>
        /// </summary>
        public const int ERROR_INVALID_PROFILE = 2011;

        /// <summary>
        /// <para>// MessageId: ERROR_TAG_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified tag was not found.</para>
        /// </summary>
        public const int ERROR_TAG_NOT_FOUND = 2012;

        /// <summary>
        /// <para>// MessageId: ERROR_TAG_NOT_PRESENT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A required tag is not present.</para>
        /// </summary>
        public const int ERROR_TAG_NOT_PRESENT = 2013;

        /// <summary>
        /// <para>// MessageId: ERROR_DUPLICATE_TAG</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified tag is already present.</para>
        /// </summary>
        public const int ERROR_DUPLICATE_TAG = 2014;

        /// <summary>
        /// <para>// MessageId: ERROR_PROFILE_NOT_ASSOCIATED_WITH_DEVICE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified color profile is not associated with any device.</para>
        /// </summary>
        public const int ERROR_PROFILE_NOT_ASSOCIATED_WITH_DEVICE = 2015;

        /// <summary>
        /// <para>// MessageId: ERROR_PROFILE_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified color profile was not found.</para>
        /// </summary>
        public const int ERROR_PROFILE_NOT_FOUND = 2016;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_COLORSPACE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified color space is invalid.</para>
        /// </summary>
        public const int ERROR_INVALID_COLORSPACE = 2017;

        /// <summary>
        /// <para>// MessageId: ERROR_ICM_NOT_ENABLED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Image Color Management is not enabled.</para>
        /// </summary>
        public const int ERROR_ICM_NOT_ENABLED = 2018;

        /// <summary>
        /// <para>// MessageId: ERROR_DELETING_ICM_XFORM</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  There was an error while deleting the color transform.</para>
        /// </summary>
        public const int ERROR_DELETING_ICM_XFORM = 2019;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_TRANSFORM</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified color transform is invalid.</para>
        /// </summary>
        public const int ERROR_INVALID_TRANSFORM = 2020;

        /// <summary>
        /// <para>// MessageId: ERROR_COLORSPACE_MISMATCH</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified transform does not match the bitmap's color space.</para>
        /// </summary>
        public const int ERROR_COLORSPACE_MISMATCH = 2021;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_COLORINDEX</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified named color index is not present in the profile.</para>
        /// </summary>
        public const int ERROR_INVALID_COLORINDEX = 2022;



        ///////////////////////////
        //                       //
        // Winnet32 Status Codes //
        //                       //
        // The range 2100 through 2999 is reserved for network status codes.
        // See lmerr.h for a complete listing
        ///////////////////////////


        /// <summary>
        /// <para>// MessageId: ERROR_CONNECTED_OTHER_PASSWORD</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The network connection was made successfully, but the user had to be prompted for a password other  than the one originally specified.</para>
        /// </summary>
        public const int ERROR_CONNECTED_OTHER_PASSWORD = 2108;

        /// <summary>
        /// <para>// MessageId: ERROR_CONNECTED_OTHER_PASSWORD_DEFAULT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The network connection was made successfully using default credentials.</para>
        /// </summary>
        public const int ERROR_CONNECTED_OTHER_PASSWORD_DEFAULT = 2109;

        /// <summary>
        /// <para>// MessageId: ERROR_BAD_USERNAME</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified username is invalid.</para>
        /// </summary>
        public const int ERROR_BAD_USERNAME = 2202;

        /// <summary>
        /// <para>// MessageId: ERROR_NOT_CONNECTED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  This network connection does not exist.</para>
        /// </summary>
        public const int ERROR_NOT_CONNECTED = 2250;

        /// <summary>
        /// <para>// MessageId: ERROR_OPEN_FILES</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  This network connection has files open or requests pending.</para>
        /// </summary>
        public const int ERROR_OPEN_FILES = 2401;

        /// <summary>
        /// <para>// MessageId: ERROR_ACTIVE_CONNECTIONS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Active connections still exist.</para>
        /// </summary>
        public const int ERROR_ACTIVE_CONNECTIONS = 2402;

        /// <summary>
        /// <para>// MessageId: ERROR_DEVICE_IN_USE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The device is in use by an active process and cannot be disconnected.</para>
        /// </summary>
        public const int ERROR_DEVICE_IN_USE = 2404;


        /// <summary>
        /// <para>////////////////////////////////////</para>
        /// <para>//                                //</para>
        /// <para>//     Win32 Spooler Error Codes  //</para>
        /// <para>//                                //</para>
        /// <para>////////////////////////////////////</para>
        /// <para>//</para>
        /// <para>// MessageId: ERROR_UNKNOWN_PRINT_MONITOR</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified print monitor is unknown.</para>
        /// </summary>
        public const int ERROR_UNKNOWN_PRINT_MONITOR = 3000;

        /// <summary>
        /// <para>// MessageId: ERROR_PRINTER_DRIVER_IN_USE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified printer driver is currently in use.</para>
        /// </summary>
        public const int ERROR_PRINTER_DRIVER_IN_USE = 3001;

        /// <summary>
        /// <para>// MessageId: ERROR_SPOOL_FILE_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The spool file was not found.</para>
        /// </summary>
        public const int ERROR_SPOOL_FILE_NOT_FOUND = 3002;

        /// <summary>
        /// <para>// MessageId: ERROR_SPL_NO_STARTDOC</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A StartDocPrinter call was not issued.</para>
        /// </summary>
        public const int ERROR_SPL_NO_STARTDOC = 3003;

        /// <summary>
        /// <para>// MessageId: ERROR_SPL_NO_ADDJOB</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An AddJob call was not issued.</para>
        /// </summary>
        public const int ERROR_SPL_NO_ADDJOB = 3004;

        /// <summary>
        /// <para>// MessageId: ERROR_PRINT_PROCESSOR_ALREADY_INSTALLED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified print processor has already been installed.</para>
        /// </summary>
        public const int ERROR_PRINT_PROCESSOR_ALREADY_INSTALLED = 3005;

        /// <summary>
        /// <para>// MessageId: ERROR_PRINT_MONITOR_ALREADY_INSTALLED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified print monitor has already been installed.</para>
        /// </summary>
        public const int ERROR_PRINT_MONITOR_ALREADY_INSTALLED = 3006;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_PRINT_MONITOR</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified print monitor does not have the required functions.</para>
        /// </summary>
        public const int ERROR_INVALID_PRINT_MONITOR = 3007;

        /// <summary>
        /// <para>// MessageId: ERROR_PRINT_MONITOR_IN_USE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified print monitor is currently in use.</para>
        /// </summary>
        public const int ERROR_PRINT_MONITOR_IN_USE = 3008;

        /// <summary>
        /// <para>// MessageId: ERROR_PRINTER_HAS_JOBS_QUEUED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The requested operation is not allowed when there are jobs queued to the printer.</para>
        /// </summary>
        public const int ERROR_PRINTER_HAS_JOBS_QUEUED = 3009;

        /// <summary>
        /// <para>// MessageId: ERROR_SUCCESS_REBOOT_REQUIRED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The requested operation is successful. Changes will not be effective until the system is rebooted.</para>
        /// </summary>
        public const int ERROR_SUCCESS_REBOOT_REQUIRED = 3010;

        /// <summary>
        /// <para>// MessageId: ERROR_SUCCESS_RESTART_REQUIRED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The requested operation is successful. Changes will not be effective until the service is  restarted.</para>
        /// </summary>
        public const int ERROR_SUCCESS_RESTART_REQUIRED = 3011;

        /// <summary>
        /// <para>// MessageId: ERROR_PRINTER_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  No printers were found.</para>
        /// </summary>
        public const int ERROR_PRINTER_NOT_FOUND = 3012;

        /// <summary>
        /// <para>// MessageId: ERROR_PRINTER_DRIVER_WARNED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The printer driver is known to be unreliable.</para>
        /// </summary>
        public const int ERROR_PRINTER_DRIVER_WARNED = 3013;

        /// <summary>
        /// <para>// MessageId: ERROR_PRINTER_DRIVER_BLOCKED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The printer driver is known to harm the system.</para>
        /// </summary>
        public const int ERROR_PRINTER_DRIVER_BLOCKED = 3014;

        /// <summary>
        /// <para>////////////////////////////////////</para>
        /// <para>//                                //</para>
        /// <para>//     Wins Error Codes           //</para>
        /// <para>//                                //</para>
        /// <para>////////////////////////////////////</para>
        /// <para>//</para>
        /// <para>// MessageId: ERROR_WINS_INTERNAL</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  WINS encountered an error while processing the command.</para>
        /// </summary>
        public const int ERROR_WINS_INTERNAL = 4000;

        /// <summary>
        /// <para>// MessageId: ERROR_CAN_NOT_DEL_LOCAL_WINS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The local WINS can not be deleted.</para>
        /// </summary>
        public const int ERROR_CAN_NOT_DEL_LOCAL_WINS = 4001;

        /// <summary>
        /// <para>// MessageId: ERROR_STATIC_INIT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The importation from the file failed.</para>
        /// </summary>
        public const int ERROR_STATIC_INIT = 4002;

        /// <summary>
        /// <para>// MessageId: ERROR_INC_BACKUP</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The backup failed. Was a full backup done before?</para>
        /// </summary>
        public const int ERROR_INC_BACKUP = 4003;

        /// <summary>
        /// <para>// MessageId: ERROR_FULL_BACKUP</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The backup failed. Check the directory to which you are backing the database.</para>
        /// </summary>
        public const int ERROR_FULL_BACKUP = 4004;

        /// <summary>
        /// <para>// MessageId: ERROR_REC_NON_EXISTENT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The name does not exist in the WINS database.</para>
        /// </summary>
        public const int ERROR_REC_NON_EXISTENT = 4005;

        /// <summary>
        /// <para>// MessageId: ERROR_RPL_NOT_ALLOWED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Replication with a nonconfigured partner is not allowed.</para>
        /// </summary>
        public const int ERROR_RPL_NOT_ALLOWED = 4006;

        /// <summary>
        /// <para>////////////////////////////////////</para>
        /// <para>//                                //</para>
        /// <para>//     DHCP Error Codes           //</para>
        /// <para>//                                //</para>
        /// <para>////////////////////////////////////</para>
        /// <para>//</para>
        /// <para>// MessageId: ERROR_DHCP_ADDRESS_CONFLICT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The DHCP client has obtained an IP address that is already in use on the network. The local  interface will be disabled until the DHCP client can obtain a new address.</para>
        /// </summary>
        public const int ERROR_DHCP_ADDRESS_CONFLICT = 4100;

        /// <summary>
        /// <para>////////////////////////////////////</para>
        /// <para>//                                //</para>
        /// <para>//     WMI Error Codes            //</para>
        /// <para>//                                //</para>
        /// <para>////////////////////////////////////</para>
        /// <para>//</para>
        /// <para>// MessageId: ERROR_WMI_GUID_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The GUID passed was not recognized as valid by a WMI data provider.</para>
        /// </summary>
        public const int ERROR_WMI_GUID_NOT_FOUND = 4200;

        /// <summary>
        /// <para>// MessageId: ERROR_WMI_INSTANCE_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The instance name passed was not recognized as valid by a WMI data provider.</para>
        /// </summary>
        public const int ERROR_WMI_INSTANCE_NOT_FOUND = 4201;

        /// <summary>
        /// <para>// MessageId: ERROR_WMI_ITEMID_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The data item ID passed was not recognized as valid by a WMI data provider.</para>
        /// </summary>
        public const int ERROR_WMI_ITEMID_NOT_FOUND = 4202;

        /// <summary>
        /// <para>// MessageId: ERROR_WMI_TRY_AGAIN</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The WMI request could not be completed and should be retried.</para>
        /// </summary>
        public const int ERROR_WMI_TRY_AGAIN = 4203;

        /// <summary>
        /// <para>// MessageId: ERROR_WMI_DP_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The WMI data provider could not be located.</para>
        /// </summary>
        public const int ERROR_WMI_DP_NOT_FOUND = 4204;

        /// <summary>
        /// <para>// MessageId: ERROR_WMI_UNRESOLVED_INSTANCE_REF</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The WMI data provider references an instance set that has not been registered.</para>
        /// </summary>
        public const int ERROR_WMI_UNRESOLVED_INSTANCE_REF = 4205;

        /// <summary>
        /// <para>// MessageId: ERROR_WMI_ALREADY_ENABLED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The WMI data block or event notification has already been enabled.</para>
        /// </summary>
        public const int ERROR_WMI_ALREADY_ENABLED = 4206;

        /// <summary>
        /// <para>// MessageId: ERROR_WMI_GUID_DISCONNECTED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The WMI data block is no longer available.</para>
        /// </summary>
        public const int ERROR_WMI_GUID_DISCONNECTED = 4207;

        /// <summary>
        /// <para>// MessageId: ERROR_WMI_SERVER_UNAVAILABLE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The WMI data service is not available.</para>
        /// </summary>
        public const int ERROR_WMI_SERVER_UNAVAILABLE = 4208;

        /// <summary>
        /// <para>// MessageId: ERROR_WMI_DP_FAILED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The WMI data provider failed to carry out the request.</para>
        /// </summary>
        public const int ERROR_WMI_DP_FAILED = 4209;

        /// <summary>
        /// <para>// MessageId: ERROR_WMI_INVALID_MOF</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The WMI MOF information is not valid.</para>
        /// </summary>
        public const int ERROR_WMI_INVALID_MOF = 4210;

        /// <summary>
        /// <para>// MessageId: ERROR_WMI_INVALID_REGINFO</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The WMI registration information is not valid.</para>
        /// </summary>
        public const int ERROR_WMI_INVALID_REGINFO = 4211;

        /// <summary>
        /// <para>// MessageId: ERROR_WMI_ALREADY_DISABLED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The WMI data block or event notification has already been disabled.</para>
        /// </summary>
        public const int ERROR_WMI_ALREADY_DISABLED = 4212;

        /// <summary>
        /// <para>// MessageId: ERROR_WMI_READ_ONLY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The WMI data item or data block is read only.</para>
        /// </summary>
        public const int ERROR_WMI_READ_ONLY = 4213;

        /// <summary>
        /// <para>// MessageId: ERROR_WMI_SET_FAILURE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The WMI data item or data block could not be changed.</para>
        /// </summary>
        public const int ERROR_WMI_SET_FAILURE = 4214;

        /// <summary>
        /// <para>//////////////////////////////////////////</para>
        /// <para>//                                      //</para>
        /// <para>// NT Media Services (RSM) Error Codes  //</para>
        /// <para>//                                      //</para>
        /// <para>//////////////////////////////////////////</para>
        /// <para>//</para>
        /// <para>// MessageId: ERROR_INVALID_MEDIA</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The media identifier does not represent a valid medium.</para>
        /// </summary>
        public const int ERROR_INVALID_MEDIA = 4300;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_LIBRARY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The library identifier does not represent a valid library.</para>
        /// </summary>
        public const int ERROR_INVALID_LIBRARY = 4301;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_MEDIA_POOL</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The media pool identifier does not represent a valid media pool.</para>
        /// </summary>
        public const int ERROR_INVALID_MEDIA_POOL = 4302;

        /// <summary>
        /// <para>// MessageId: ERROR_DRIVE_MEDIA_MISMATCH</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The drive and medium are not compatible or exist in different libraries.</para>
        /// </summary>
        public const int ERROR_DRIVE_MEDIA_MISMATCH = 4303;

        /// <summary>
        /// <para>// MessageId: ERROR_MEDIA_OFFLINE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The medium currently exists in an offline library and must be online to perform this operation.</para>
        /// </summary>
        public const int ERROR_MEDIA_OFFLINE = 4304;

        /// <summary>
        /// <para>// MessageId: ERROR_LIBRARY_OFFLINE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The operation cannot be performed on an offline library.</para>
        /// </summary>
        public const int ERROR_LIBRARY_OFFLINE = 4305;

        /// <summary>
        /// <para>// MessageId: ERROR_EMPTY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The library, drive, or media pool is empty.</para>
        /// </summary>
        public const int ERROR_EMPTY = 4306;

        /// <summary>
        /// <para>// MessageId: ERROR_NOT_EMPTY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The library, drive, or media pool must be empty to perform this operation.</para>
        /// </summary>
        public const int ERROR_NOT_EMPTY = 4307;

        /// <summary>
        /// <para>// MessageId: ERROR_MEDIA_UNAVAILABLE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  No media is currently available in this media pool or library.</para>
        /// </summary>
        public const int ERROR_MEDIA_UNAVAILABLE = 4308;

        /// <summary>
        /// <para>// MessageId: ERROR_RESOURCE_DISABLED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A resource required for this operation is disabled.</para>
        /// </summary>
        public const int ERROR_RESOURCE_DISABLED = 4309;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_CLEANER</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The media identifier does not represent a valid cleaner.</para>
        /// </summary>
        public const int ERROR_INVALID_CLEANER = 4310;

        /// <summary>
        /// <para>// MessageId: ERROR_UNABLE_TO_CLEAN</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The drive cannot be cleaned or does not support cleaning.</para>
        /// </summary>
        public const int ERROR_UNABLE_TO_CLEAN = 4311;

        /// <summary>
        /// <para>// MessageId: ERROR_OBJECT_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The object identifier does not represent a valid object.</para>
        /// </summary>
        public const int ERROR_OBJECT_NOT_FOUND = 4312;

        /// <summary>
        /// <para>// MessageId: ERROR_DATABASE_FAILURE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Unable to read from or write to the database.</para>
        /// </summary>
        public const int ERROR_DATABASE_FAILURE = 4313;

        /// <summary>
        /// <para>// MessageId: ERROR_DATABASE_FULL</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The database is full.</para>
        /// </summary>
        public const int ERROR_DATABASE_FULL = 4314;

        /// <summary>
        /// <para>// MessageId: ERROR_MEDIA_INCOMPATIBLE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The medium is not compatible with the device or media pool.</para>
        /// </summary>
        public const int ERROR_MEDIA_INCOMPATIBLE = 4315;

        /// <summary>
        /// <para>// MessageId: ERROR_RESOURCE_NOT_PRESENT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The resource required for this operation does not exist.</para>
        /// </summary>
        public const int ERROR_RESOURCE_NOT_PRESENT = 4316;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_OPERATION</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The operation identifier is not valid.</para>
        /// </summary>
        public const int ERROR_INVALID_OPERATION = 4317;

        /// <summary>
        /// <para>// MessageId: ERROR_MEDIA_NOT_AVAILABLE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The media is not mounted or ready for use.</para>
        /// </summary>
        public const int ERROR_MEDIA_NOT_AVAILABLE = 4318;

        /// <summary>
        /// <para>// MessageId: ERROR_DEVICE_NOT_AVAILABLE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The device is not ready for use.</para>
        /// </summary>
        public const int ERROR_DEVICE_NOT_AVAILABLE = 4319;

        /// <summary>
        /// <para>// MessageId: ERROR_REQUEST_REFUSED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The operator or administrator has refused the request.</para>
        /// </summary>
        public const int ERROR_REQUEST_REFUSED = 4320;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_DRIVE_OBJECT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The drive identifier does not represent a valid drive.</para>
        /// </summary>
        public const int ERROR_INVALID_DRIVE_OBJECT = 4321;

        /// <summary>
        /// <para>// MessageId: ERROR_LIBRARY_FULL</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Library is full.  No slot is available for use.</para>
        /// </summary>
        public const int ERROR_LIBRARY_FULL = 4322;

        /// <summary>
        /// <para>// MessageId: ERROR_MEDIUM_NOT_ACCESSIBLE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The transport cannot access the medium.</para>
        /// </summary>
        public const int ERROR_MEDIUM_NOT_ACCESSIBLE = 4323;

        /// <summary>
        /// <para>// MessageId: ERROR_UNABLE_TO_LOAD_MEDIUM</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Unable to load the medium into the drive.</para>
        /// </summary>
        public const int ERROR_UNABLE_TO_LOAD_MEDIUM = 4324;

        /// <summary>
        /// <para>// MessageId: ERROR_UNABLE_TO_INVENTORY_DRIVE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Unable to retrieve the drive status.</para>
        /// </summary>
        public const int ERROR_UNABLE_TO_INVENTORY_DRIVE = 4325;

        /// <summary>
        /// <para>// MessageId: ERROR_UNABLE_TO_INVENTORY_SLOT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Unable to retrieve the slot status.</para>
        /// </summary>
        public const int ERROR_UNABLE_TO_INVENTORY_SLOT = 4326;

        /// <summary>
        /// <para>// MessageId: ERROR_UNABLE_TO_INVENTORY_TRANSPORT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Unable to retrieve status about the transport.</para>
        /// </summary>
        public const int ERROR_UNABLE_TO_INVENTORY_TRANSPORT = 4327;

        /// <summary>
        /// <para>// MessageId: ERROR_TRANSPORT_FULL</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Cannot use the transport because it is already in use.</para>
        /// </summary>
        public const int ERROR_TRANSPORT_FULL = 4328;

        /// <summary>
        /// <para>// MessageId: ERROR_CONTROLLING_IEPORT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Unable to open or close the inject/eject port.</para>
        /// </summary>
        public const int ERROR_CONTROLLING_IEPORT = 4329;

        /// <summary>
        /// <para>// MessageId: ERROR_UNABLE_TO_EJECT_MOUNTED_MEDIA</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Unable to eject the medium because it is in a drive.</para>
        /// </summary>
        public const int ERROR_UNABLE_TO_EJECT_MOUNTED_MEDIA = 4330;

        /// <summary>
        /// <para>// MessageId: ERROR_CLEANER_SLOT_SET</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A cleaner slot is already reserved.</para>
        /// </summary>
        public const int ERROR_CLEANER_SLOT_SET = 4331;

        /// <summary>
        /// <para>// MessageId: ERROR_CLEANER_SLOT_NOT_SET</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A cleaner slot is not reserved.</para>
        /// </summary>
        public const int ERROR_CLEANER_SLOT_NOT_SET = 4332;

        /// <summary>
        /// <para>// MessageId: ERROR_CLEANER_CARTRIDGE_SPENT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The cleaner cartridge has performed the maximum number of drive cleanings.</para>
        /// </summary>
        public const int ERROR_CLEANER_CARTRIDGE_SPENT = 4333;

        /// <summary>
        /// <para>// MessageId: ERROR_UNEXPECTED_OMID</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Unexpected on-medium identifier.</para>
        /// </summary>
        public const int ERROR_UNEXPECTED_OMID = 4334;

        /// <summary>
        /// <para>// MessageId: ERROR_CANT_DELETE_LAST_ITEM</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The last remaining item in this group or resource cannot be deleted.</para>
        /// </summary>
        public const int ERROR_CANT_DELETE_LAST_ITEM = 4335;

        /// <summary>
        /// <para>// MessageId: ERROR_MESSAGE_EXCEEDS_MAX_SIZE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The message provided exceeds the maximum size allowed for this parameter.</para>
        /// </summary>
        public const int ERROR_MESSAGE_EXCEEDS_MAX_SIZE = 4336;

        /// <summary>
        /// <para>// MessageId: ERROR_VOLUME_CONTAINS_SYS_FILES</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The volume contains system or paging files.</para>
        /// </summary>
        public const int ERROR_VOLUME_CONTAINS_SYS_FILES = 4337;

        /// <summary>
        /// <para>// MessageId: ERROR_INDIGENOUS_TYPE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The media type cannot be removed from this library since at least one drive in the library reports  it can support this media type.</para>
        /// </summary>
        public const int ERROR_INDIGENOUS_TYPE = 4338;

        /// <summary>
        /// <para>// MessageId: ERROR_NO_SUPPORTING_DRIVES</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  This offline media cannot be mounted on this system since no enabled drives are present which can  be used.</para>
        /// </summary>
        public const int ERROR_NO_SUPPORTING_DRIVES = 4339;

        /// <summary>
        /// <para>// MessageId: ERROR_CLEANER_CARTRIDGE_INSTALLED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A cleaner cartridge is present in the tape library.</para>
        /// </summary>
        public const int ERROR_CLEANER_CARTRIDGE_INSTALLED = 4340;

        /// <summary>
        /// <para>// MessageId: ERROR_IEPORT_FULL</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Cannot use the ieport because it is not empty.</para>
        /// </summary>
        public const int ERROR_IEPORT_FULL = 4341;

        /// <summary>
        /// <para>////////////////////////////////////////////</para>
        /// <para>//                                        //</para>
        /// <para>// NT Remote Storage Service Error Codes  //</para>
        /// <para>//                                        //</para>
        /// <para>////////////////////////////////////////////</para>
        /// <para>//</para>
        /// <para>// MessageId: ERROR_FILE_OFFLINE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The remote storage service was not able to recall the file.</para>
        /// </summary>
        public const int ERROR_FILE_OFFLINE = 4350;

        /// <summary>
        /// <para>// MessageId: ERROR_REMOTE_STORAGE_NOT_ACTIVE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The remote storage service is not operational at this time.</para>
        /// </summary>
        public const int ERROR_REMOTE_STORAGE_NOT_ACTIVE = 4351;

        /// <summary>
        /// <para>// MessageId: ERROR_REMOTE_STORAGE_MEDIA_ERROR</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The remote storage service encountered a media error.</para>
        /// </summary>
        public const int ERROR_REMOTE_STORAGE_MEDIA_ERROR = 4352;

        /// <summary>
        /// <para>////////////////////////////////////////////</para>
        /// <para>//                                        //</para>
        /// <para>// NT Reparse Points Error Codes          //</para>
        /// <para>//                                        //</para>
        /// <para>////////////////////////////////////////////</para>
        /// <para>//</para>
        /// <para>// MessageId: ERROR_NOT_A_REPARSE_POINT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The file or directory is not a reparse point.</para>
        /// </summary>
        public const int ERROR_NOT_A_REPARSE_POINT = 4390;

        /// <summary>
        /// <para>// MessageId: ERROR_REPARSE_ATTRIBUTE_CONFLICT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The reparse point attribute cannot be set because it conflicts with an existing attribute.</para>
        /// </summary>
        public const int ERROR_REPARSE_ATTRIBUTE_CONFLICT = 4391;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_REPARSE_DATA</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The data present in the reparse point buffer is invalid.</para>
        /// </summary>
        public const int ERROR_INVALID_REPARSE_DATA = 4392;

        /// <summary>
        /// <para>// MessageId: ERROR_REPARSE_TAG_INVALID</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The tag present in the reparse point buffer is invalid.</para>
        /// </summary>
        public const int ERROR_REPARSE_TAG_INVALID = 4393;

        /// <summary>
        /// <para>// MessageId: ERROR_REPARSE_TAG_MISMATCH</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  There is a mismatch between the tag specified in the request and the tag present in the reparse  point.</para>
        /// <para>//  </para>
        /// </summary>
        public const int ERROR_REPARSE_TAG_MISMATCH = 4394;

        /// <summary>
        /// <para>////////////////////////////////////////////</para>
        /// <para>//                                        //</para>
        /// <para>// NT Single Instance Store Error Codes   //</para>
        /// <para>//                                        //</para>
        /// <para>////////////////////////////////////////////</para>
        /// <para>//</para>
        /// <para>// MessageId: ERROR_VOLUME_NOT_SIS_ENABLED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Single Instance Storage is not available on this volume.</para>
        /// </summary>
        public const int ERROR_VOLUME_NOT_SIS_ENABLED = 4500;

        /// <summary>
        /// <para>////////////////////////////////////</para>
        /// <para>//                                //</para>
        /// <para>//     Cluster Error Codes        //</para>
        /// <para>//                                //</para>
        /// <para>////////////////////////////////////</para>
        /// <para>//</para>
        /// <para>// MessageId: ERROR_DEPENDENT_RESOURCE_EXISTS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The cluster resource cannot be moved to another group because other resources are dependent on it.</para>
        /// </summary>
        public const int ERROR_DEPENDENT_RESOURCE_EXISTS = 5001;

        /// <summary>
        /// <para>// MessageId: ERROR_DEPENDENCY_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The cluster resource dependency cannot be found.</para>
        /// </summary>
        public const int ERROR_DEPENDENCY_NOT_FOUND = 5002;

        /// <summary>
        /// <para>// MessageId: ERROR_DEPENDENCY_ALREADY_EXISTS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The cluster resource cannot be made dependent on the specified resource because it is already  dependent.</para>
        /// </summary>
        public const int ERROR_DEPENDENCY_ALREADY_EXISTS = 5003;

        /// <summary>
        /// <para>// MessageId: ERROR_RESOURCE_NOT_ONLINE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The cluster resource is not online.</para>
        /// </summary>
        public const int ERROR_RESOURCE_NOT_ONLINE = 5004;

        /// <summary>
        /// <para>// MessageId: ERROR_HOST_NODE_NOT_AVAILABLE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A cluster node is not available for this operation.</para>
        /// </summary>
        public const int ERROR_HOST_NODE_NOT_AVAILABLE = 5005;

        /// <summary>
        /// <para>// MessageId: ERROR_RESOURCE_NOT_AVAILABLE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The cluster resource is not available.</para>
        /// </summary>
        public const int ERROR_RESOURCE_NOT_AVAILABLE = 5006;

        /// <summary>
        /// <para>// MessageId: ERROR_RESOURCE_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The cluster resource could not be found.</para>
        /// </summary>
        public const int ERROR_RESOURCE_NOT_FOUND = 5007;

        /// <summary>
        /// <para>// MessageId: ERROR_SHUTDOWN_CLUSTER</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The cluster is being shut down.</para>
        /// </summary>
        public const int ERROR_SHUTDOWN_CLUSTER = 5008;

        /// <summary>
        /// <para>// MessageId: ERROR_CANT_EVICT_ACTIVE_NODE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A cluster node cannot be evicted from the cluster unless the node is down or it is the last node.</para>
        /// </summary>
        public const int ERROR_CANT_EVICT_ACTIVE_NODE = 5009;

        /// <summary>
        /// <para>// MessageId: ERROR_OBJECT_ALREADY_EXISTS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The object already exists.</para>
        /// </summary>
        public const int ERROR_OBJECT_ALREADY_EXISTS = 5010;

        /// <summary>
        /// <para>// MessageId: ERROR_OBJECT_IN_LIST</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The object is already in the list.</para>
        /// </summary>
        public const int ERROR_OBJECT_IN_LIST = 5011;

        /// <summary>
        /// <para>// MessageId: ERROR_GROUP_NOT_AVAILABLE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The cluster group is not available for any new requests.</para>
        /// </summary>
        public const int ERROR_GROUP_NOT_AVAILABLE = 5012;

        /// <summary>
        /// <para>// MessageId: ERROR_GROUP_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The cluster group could not be found.</para>
        /// </summary>
        public const int ERROR_GROUP_NOT_FOUND = 5013;

        /// <summary>
        /// <para>// MessageId: ERROR_GROUP_NOT_ONLINE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The operation could not be completed because the cluster group is not online.</para>
        /// </summary>
        public const int ERROR_GROUP_NOT_ONLINE = 5014;

        /// <summary>
        /// <para>// MessageId: ERROR_HOST_NODE_NOT_RESOURCE_OWNER</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The cluster node is not the owner of the resource.</para>
        /// </summary>
        public const int ERROR_HOST_NODE_NOT_RESOURCE_OWNER = 5015;

        /// <summary>
        /// <para>// MessageId: ERROR_HOST_NODE_NOT_GROUP_OWNER</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The cluster node is not the owner of the group.</para>
        /// </summary>
        public const int ERROR_HOST_NODE_NOT_GROUP_OWNER = 5016;

        /// <summary>
        /// <para>// MessageId: ERROR_RESMON_CREATE_FAILED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The cluster resource could not be created in the specified resource monitor.</para>
        /// </summary>
        public const int ERROR_RESMON_CREATE_FAILED = 5017;

        /// <summary>
        /// <para>// MessageId: ERROR_RESMON_ONLINE_FAILED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The cluster resource could not be brought online by the resource monitor.</para>
        /// </summary>
        public const int ERROR_RESMON_ONLINE_FAILED = 5018;

        /// <summary>
        /// <para>// MessageId: ERROR_RESOURCE_ONLINE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The operation could not be completed because the cluster resource is online.</para>
        /// </summary>
        public const int ERROR_RESOURCE_ONLINE = 5019;

        /// <summary>
        /// <para>// MessageId: ERROR_QUORUM_RESOURCE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The cluster resource could not be deleted or brought offline because it is the quorum resource.</para>
        /// </summary>
        public const int ERROR_QUORUM_RESOURCE = 5020;

        /// <summary>
        /// <para>// MessageId: ERROR_NOT_QUORUM_CAPABLE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The cluster could not make the specified resource a quorum resource because it is not capable of  being a quorum resource.</para>
        /// </summary>
        public const int ERROR_NOT_QUORUM_CAPABLE = 5021;

        /// <summary>
        /// <para>// MessageId: ERROR_CLUSTER_SHUTTING_DOWN</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The cluster software is shutting down.</para>
        /// </summary>
        public const int ERROR_CLUSTER_SHUTTING_DOWN = 5022;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_STATE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The group or resource is not in the correct state to perform the requested operation.</para>
        /// </summary>
        public const int ERROR_INVALID_STATE = 5023;

        /// <summary>
        /// <para>// MessageId: ERROR_RESOURCE_PROPERTIES_STORED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The properties were stored but not all changes will take effect until the next time the resource  is brought online.</para>
        /// </summary>
        public const int ERROR_RESOURCE_PROPERTIES_STORED = 5024;

        /// <summary>
        /// <para>// MessageId: ERROR_NOT_QUORUM_CLASS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The cluster could not make the specified resource a quorum resource because it does not belong to  a shared storage class.</para>
        /// </summary>
        public const int ERROR_NOT_QUORUM_CLASS = 5025;

        /// <summary>
        /// <para>// MessageId: ERROR_CORE_RESOURCE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The cluster resource could not be deleted since it is a core resource.</para>
        /// </summary>
        public const int ERROR_CORE_RESOURCE = 5026;

        /// <summary>
        /// <para>// MessageId: ERROR_QUORUM_RESOURCE_ONLINE_FAILED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The quorum resource failed to come online.</para>
        /// </summary>
        public const int ERROR_QUORUM_RESOURCE_ONLINE_FAILED = 5027;

        /// <summary>
        /// <para>// MessageId: ERROR_QUORUMLOG_OPEN_FAILED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The quorum log could not be created or mounted successfully.</para>
        /// </summary>
        public const int ERROR_QUORUMLOG_OPEN_FAILED = 5028;

        /// <summary>
        /// <para>// MessageId: ERROR_CLUSTERLOG_CORRUPT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The cluster log is corrupt.</para>
        /// </summary>
        public const int ERROR_CLUSTERLOG_CORRUPT = 5029;

        /// <summary>
        /// <para>// MessageId: ERROR_CLUSTERLOG_RECORD_EXCEEDS_MAXSIZE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The record could not be written to the cluster log since it exceeds the maximum size.</para>
        /// </summary>
        public const int ERROR_CLUSTERLOG_RECORD_EXCEEDS_MAXSIZE = 5030;

        /// <summary>
        /// <para>// MessageId: ERROR_CLUSTERLOG_EXCEEDS_MAXSIZE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The cluster log exceeds its maximum size.</para>
        /// </summary>
        public const int ERROR_CLUSTERLOG_EXCEEDS_MAXSIZE = 5031;

        /// <summary>
        /// <para>// MessageId: ERROR_CLUSTERLOG_CHKPOINT_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  No checkpoint record was found in the cluster log.</para>
        /// </summary>
        public const int ERROR_CLUSTERLOG_CHKPOINT_NOT_FOUND = 5032;

        /// <summary>
        /// <para>// MessageId: ERROR_CLUSTERLOG_NOT_ENOUGH_SPACE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The minimum required disk space needed for logging is not available.</para>
        /// </summary>
        public const int ERROR_CLUSTERLOG_NOT_ENOUGH_SPACE = 5033;

        /// <summary>
        /// <para>// MessageId: ERROR_QUORUM_OWNER_ALIVE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The cluster node failed to take control of the quorum resource because the resource is owned by  another active node.</para>
        /// </summary>
        public const int ERROR_QUORUM_OWNER_ALIVE = 5034;

        /// <summary>
        /// <para>// MessageId: ERROR_NETWORK_NOT_AVAILABLE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A cluster network is not available for this operation.</para>
        /// </summary>
        public const int ERROR_NETWORK_NOT_AVAILABLE = 5035;

        /// <summary>
        /// <para>// MessageId: ERROR_NODE_NOT_AVAILABLE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A cluster node is not available for this operation.</para>
        /// </summary>
        public const int ERROR_NODE_NOT_AVAILABLE = 5036;

        /// <summary>
        /// <para>// MessageId: ERROR_ALL_NODES_NOT_AVAILABLE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  All cluster nodes must be running to perform this operation.</para>
        /// </summary>
        public const int ERROR_ALL_NODES_NOT_AVAILABLE = 5037;

        /// <summary>
        /// <para>// MessageId: ERROR_RESOURCE_FAILED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A cluster resource failed.</para>
        /// </summary>
        public const int ERROR_RESOURCE_FAILED = 5038;

        /// <summary>
        /// <para>// MessageId: ERROR_CLUSTER_INVALID_NODE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The cluster node is not valid.</para>
        /// </summary>
        public const int ERROR_CLUSTER_INVALID_NODE = 5039;

        /// <summary>
        /// <para>// MessageId: ERROR_CLUSTER_NODE_EXISTS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The cluster node already exists.</para>
        /// </summary>
        public const int ERROR_CLUSTER_NODE_EXISTS = 5040;

        /// <summary>
        /// <para>// MessageId: ERROR_CLUSTER_JOIN_IN_PROGRESS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A node is in the process of joining the cluster.</para>
        /// </summary>
        public const int ERROR_CLUSTER_JOIN_IN_PROGRESS = 5041;

        /// <summary>
        /// <para>// MessageId: ERROR_CLUSTER_NODE_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The cluster node was not found.</para>
        /// </summary>
        public const int ERROR_CLUSTER_NODE_NOT_FOUND = 5042;

        /// <summary>
        /// <para>// MessageId: ERROR_CLUSTER_LOCAL_NODE_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The cluster local node information was not found.</para>
        /// </summary>
        public const int ERROR_CLUSTER_LOCAL_NODE_NOT_FOUND = 5043;

        /// <summary>
        /// <para>// MessageId: ERROR_CLUSTER_NETWORK_EXISTS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The cluster network already exists.</para>
        /// </summary>
        public const int ERROR_CLUSTER_NETWORK_EXISTS = 5044;

        /// <summary>
        /// <para>// MessageId: ERROR_CLUSTER_NETWORK_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The cluster network was not found.</para>
        /// </summary>
        public const int ERROR_CLUSTER_NETWORK_NOT_FOUND = 5045;

        /// <summary>
        /// <para>// MessageId: ERROR_CLUSTER_NETINTERFACE_EXISTS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The cluster network interface already exists.</para>
        /// </summary>
        public const int ERROR_CLUSTER_NETINTERFACE_EXISTS = 5046;

        /// <summary>
        /// <para>// MessageId: ERROR_CLUSTER_NETINTERFACE_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The cluster network interface was not found.</para>
        /// </summary>
        public const int ERROR_CLUSTER_NETINTERFACE_NOT_FOUND = 5047;

        /// <summary>
        /// <para>// MessageId: ERROR_CLUSTER_INVALID_REQUEST</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The cluster request is not valid for this object.</para>
        /// </summary>
        public const int ERROR_CLUSTER_INVALID_REQUEST = 5048;

        /// <summary>
        /// <para>// MessageId: ERROR_CLUSTER_INVALID_NETWORK_PROVIDER</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The cluster network provider is not valid.</para>
        /// </summary>
        public const int ERROR_CLUSTER_INVALID_NETWORK_PROVIDER = 5049;

        /// <summary>
        /// <para>// MessageId: ERROR_CLUSTER_NODE_DOWN</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The cluster node is down.</para>
        /// </summary>
        public const int ERROR_CLUSTER_NODE_DOWN = 5050;

        /// <summary>
        /// <para>// MessageId: ERROR_CLUSTER_NODE_UNREACHABLE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The cluster node is not reachable.</para>
        /// </summary>
        public const int ERROR_CLUSTER_NODE_UNREACHABLE = 5051;

        /// <summary>
        /// <para>// MessageId: ERROR_CLUSTER_NODE_NOT_MEMBER</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The cluster node is not a member of the cluster.</para>
        /// </summary>
        public const int ERROR_CLUSTER_NODE_NOT_MEMBER = 5052;

        /// <summary>
        /// <para>// MessageId: ERROR_CLUSTER_JOIN_NOT_IN_PROGRESS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A cluster join operation is not in progress.</para>
        /// </summary>
        public const int ERROR_CLUSTER_JOIN_NOT_IN_PROGRESS = 5053;

        /// <summary>
        /// <para>// MessageId: ERROR_CLUSTER_INVALID_NETWORK</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The cluster network is not valid.</para>
        /// </summary>
        public const int ERROR_CLUSTER_INVALID_NETWORK = 5054;

        /// <summary>
        /// <para>// MessageId: ERROR_CLUSTER_NODE_UP</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The cluster node is up.</para>
        /// </summary>
        public const int ERROR_CLUSTER_NODE_UP = 5056;

        /// <summary>
        /// <para>// MessageId: ERROR_CLUSTER_IPADDR_IN_USE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The cluster IP address is already in use.</para>
        /// </summary>
        public const int ERROR_CLUSTER_IPADDR_IN_USE = 5057;

        /// <summary>
        /// <para>// MessageId: ERROR_CLUSTER_NODE_NOT_PAUSED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The cluster node is not paused.</para>
        /// </summary>
        public const int ERROR_CLUSTER_NODE_NOT_PAUSED = 5058;

        /// <summary>
        /// <para>// MessageId: ERROR_CLUSTER_NO_SECURITY_CONTEXT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  No cluster security context is available.</para>
        /// </summary>
        public const int ERROR_CLUSTER_NO_SECURITY_CONTEXT = 5059;

        /// <summary>
        /// <para>// MessageId: ERROR_CLUSTER_NETWORK_NOT_INTERNAL</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The cluster network is not configured for internal cluster communication.</para>
        /// </summary>
        public const int ERROR_CLUSTER_NETWORK_NOT_INTERNAL = 5060;

        /// <summary>
        /// <para>// MessageId: ERROR_CLUSTER_NODE_ALREADY_UP</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The cluster node is already up.</para>
        /// </summary>
        public const int ERROR_CLUSTER_NODE_ALREADY_UP = 5061;

        /// <summary>
        /// <para>// MessageId: ERROR_CLUSTER_NODE_ALREADY_DOWN</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The cluster node is already down.</para>
        /// </summary>
        public const int ERROR_CLUSTER_NODE_ALREADY_DOWN = 5062;

        /// <summary>
        /// <para>// MessageId: ERROR_CLUSTER_NETWORK_ALREADY_ONLINE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The cluster network is already online.</para>
        /// </summary>
        public const int ERROR_CLUSTER_NETWORK_ALREADY_ONLINE = 5063;

        /// <summary>
        /// <para>// MessageId: ERROR_CLUSTER_NETWORK_ALREADY_OFFLINE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The cluster network is already offline.</para>
        /// </summary>
        public const int ERROR_CLUSTER_NETWORK_ALREADY_OFFLINE = 5064;

        /// <summary>
        /// <para>// MessageId: ERROR_CLUSTER_NODE_ALREADY_MEMBER</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The cluster node is already a member of the cluster.</para>
        /// </summary>
        public const int ERROR_CLUSTER_NODE_ALREADY_MEMBER = 5065;

        /// <summary>
        /// <para>// MessageId: ERROR_CLUSTER_LAST_INTERNAL_NETWORK</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The cluster network is the only one configured for internal cluster communication between two or  more active cluster nodes. The internal communication capability cannot be removed from the network.</para>
        /// </summary>
        public const int ERROR_CLUSTER_LAST_INTERNAL_NETWORK = 5066;

        /// <summary>
        /// <para>// MessageId: ERROR_CLUSTER_NETWORK_HAS_DEPENDENTS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  One or more cluster resources depend on the network to provide service to clients. The client  access capability cannot be removed from the network.</para>
        /// </summary>
        public const int ERROR_CLUSTER_NETWORK_HAS_DEPENDENTS = 5067;

        /// <summary>
        /// <para>// MessageId: ERROR_INVALID_OPERATION_ON_QUORUM</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  This operation cannot be performed on the cluster resource as it the quorum resource. You may not  bring the quorum resource offline or modify its possible owners list.</para>
        /// </summary>
        public const int ERROR_INVALID_OPERATION_ON_QUORUM = 5068;

        /// <summary>
        /// <para>// MessageId: ERROR_DEPENDENCY_NOT_ALLOWED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The cluster quorum resource is not allowed to have any dependencies.</para>
        /// </summary>
        public const int ERROR_DEPENDENCY_NOT_ALLOWED = 5069;

        /// <summary>
        /// <para>// MessageId: ERROR_CLUSTER_NODE_PAUSED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The cluster node is paused.</para>
        /// </summary>
        public const int ERROR_CLUSTER_NODE_PAUSED = 5070;

        /// <summary>
        /// <para>// MessageId: ERROR_NODE_CANT_HOST_RESOURCE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The cluster resource cannot be brought online. The owner node cannot run this resource.</para>
        /// </summary>
        public const int ERROR_NODE_CANT_HOST_RESOURCE = 5071;

        /// <summary>
        /// <para>// MessageId: ERROR_CLUSTER_NODE_NOT_READY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The cluster node is not ready to perform the requested operation.</para>
        /// </summary>
        public const int ERROR_CLUSTER_NODE_NOT_READY = 5072;

        /// <summary>
        /// <para>// MessageId: ERROR_CLUSTER_NODE_SHUTTING_DOWN</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The cluster node is shutting down.</para>
        /// </summary>
        public const int ERROR_CLUSTER_NODE_SHUTTING_DOWN = 5073;

        /// <summary>
        /// <para>// MessageId: ERROR_CLUSTER_JOIN_ABORTED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The cluster join operation was aborted.</para>
        /// </summary>
        public const int ERROR_CLUSTER_JOIN_ABORTED = 5074;

        /// <summary>
        /// <para>// MessageId: ERROR_CLUSTER_INCOMPATIBLE_VERSIONS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The cluster join operation failed due to incompatible software versions between the joining node  and its sponsor.</para>
        /// </summary>
        public const int ERROR_CLUSTER_INCOMPATIBLE_VERSIONS = 5075;

        /// <summary>
        /// <para>// MessageId: ERROR_CLUSTER_MAXNUM_OF_RESOURCES_EXCEEDED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  This resource cannot be created because the cluster has reached the limit on the number of  resources it can monitor.</para>
        /// </summary>
        public const int ERROR_CLUSTER_MAXNUM_OF_RESOURCES_EXCEEDED = 5076;

        /// <summary>
        /// <para>// MessageId: ERROR_CLUSTER_SYSTEM_CONFIG_CHANGED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The system configuration changed during the cluster join or form operation. The join or form  operation was aborted.</para>
        /// </summary>
        public const int ERROR_CLUSTER_SYSTEM_CONFIG_CHANGED = 5077;

        /// <summary>
        /// <para>// MessageId: ERROR_CLUSTER_RESOURCE_TYPE_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified resource type was not found.</para>
        /// </summary>
        public const int ERROR_CLUSTER_RESOURCE_TYPE_NOT_FOUND = 5078;

        /// <summary>
        /// <para>// MessageId: ERROR_CLUSTER_RESTYPE_NOT_SUPPORTED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified node does not support a resource of this type.  This may be due to version  inconsistencies or due to the absence of the resource DLL on this node.</para>
        /// </summary>
        public const int ERROR_CLUSTER_RESTYPE_NOT_SUPPORTED = 5079;

        /// <summary>
        /// <para>// MessageId: ERROR_CLUSTER_RESNAME_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified resource name is not supported by this resource DLL. This may be due to a bad (or  changed) name supplied to the resource DLL.</para>
        /// </summary>
        public const int ERROR_CLUSTER_RESNAME_NOT_FOUND = 5080;

        /// <summary>
        /// <para>// MessageId: ERROR_CLUSTER_NO_RPC_PACKAGES_REGISTERED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  No authentication package could be registered with the RPC server.</para>
        /// </summary>
        public const int ERROR_CLUSTER_NO_RPC_PACKAGES_REGISTERED = 5081;

        /// <summary>
        /// <para>// MessageId: ERROR_CLUSTER_OWNER_NOT_IN_PREFLIST</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  You cannot bring the group online because the owner of the group is not in the preferred list for  the group. To change the owner node for the group, move the group.</para>
        /// </summary>
        public const int ERROR_CLUSTER_OWNER_NOT_IN_PREFLIST = 5082;

        /// <summary>
        /// <para>// MessageId: ERROR_CLUSTER_DATABASE_SEQMISMATCH</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The join operation failed because the cluster database sequence number has changed or is  incompatible with the locker node. This may happen during a join operation if the cluster database was  changing during the join.</para>
        /// </summary>
        public const int ERROR_CLUSTER_DATABASE_SEQMISMATCH = 5083;

        /// <summary>
        /// <para>// MessageId: ERROR_RESMON_INVALID_STATE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The resource monitor will not allow the fail operation to be performed while the resource is in  its current state. This may happen if the resource is in a pending state.</para>
        /// </summary>
        public const int ERROR_RESMON_INVALID_STATE = 5084;

        /// <summary>
        /// <para>// MessageId: ERROR_CLUSTER_GUM_NOT_LOCKER</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A non locker code got a request to reserve the lock for making global updates.</para>
        /// </summary>
        public const int ERROR_CLUSTER_GUM_NOT_LOCKER = 5085;

        /// <summary>
        /// <para>// MessageId: ERROR_QUORUM_DISK_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The quorum disk could not be located by the cluster service.</para>
        /// </summary>
        public const int ERROR_QUORUM_DISK_NOT_FOUND = 5086;

        /// <summary>
        /// <para>// MessageId: ERROR_DATABASE_BACKUP_CORRUPT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The backed up cluster database is possibly corrupt.</para>
        /// </summary>
        public const int ERROR_DATABASE_BACKUP_CORRUPT = 5087;

        /// <summary>
        /// <para>// MessageId: ERROR_CLUSTER_NODE_ALREADY_HAS_DFS_ROOT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A DFS root already exists in this cluster node.</para>
        /// </summary>
        public const int ERROR_CLUSTER_NODE_ALREADY_HAS_DFS_ROOT = 5088;

        /// <summary>
        /// <para>// MessageId: ERROR_RESOURCE_PROPERTY_UNCHANGEABLE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An attempt to modify a resource property failed because it conflicts with another existing  property.</para>
        /// </summary>
        public const int ERROR_RESOURCE_PROPERTY_UNCHANGEABLE = 5089;

        /*
         Codes from 4300 through 5889 overlap with codes in ds\published\inc\apperr2.w.
         Do not add any more error codes in that range.
        */
        /// <summary>
        /// <para>// MessageId: ERROR_CLUSTER_MEMBERSHIP_INVALID_STATE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An operation was attempted that is incompatible with the current membership state of the node.</para>
        /// </summary>
        public const int ERROR_CLUSTER_MEMBERSHIP_INVALID_STATE = 5890;

        /// <summary>
        /// <para>// MessageId: ERROR_CLUSTER_QUORUMLOG_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The quorum resource does not contain the quorum log.</para>
        /// </summary>
        public const int ERROR_CLUSTER_QUORUMLOG_NOT_FOUND = 5891;

        /// <summary>
        /// <para>// MessageId: ERROR_CLUSTER_MEMBERSHIP_HALT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The membership engine requested shutdown of the cluster service on this node.</para>
        /// </summary>
        public const int ERROR_CLUSTER_MEMBERSHIP_HALT = 5892;

        /// <summary>
        /// <para>// MessageId: ERROR_CLUSTER_INSTANCE_ID_MISMATCH</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The join operation failed because the cluster instance ID of the joining node does not match the  cluster instance ID of the sponsor node.</para>
        /// </summary>
        public const int ERROR_CLUSTER_INSTANCE_ID_MISMATCH = 5893;

        /// <summary>
        /// <para>// MessageId: ERROR_CLUSTER_NETWORK_NOT_FOUND_FOR_IP</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A matching network for the specified IP address could not be found. Please also specify a subnet  mask and a cluster network.</para>
        /// </summary>
        public const int ERROR_CLUSTER_NETWORK_NOT_FOUND_FOR_IP = 5894;

        /// <summary>
        /// <para>// MessageId: ERROR_CLUSTER_PROPERTY_DATA_TYPE_MISMATCH</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The actual data type of the property did not match the expected data type of the property.</para>
        /// </summary>
        public const int ERROR_CLUSTER_PROPERTY_DATA_TYPE_MISMATCH = 5895;

        /// <summary>
        /// <para>// MessageId: ERROR_CLUSTER_EVICT_WITHOUT_CLEANUP</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The cluster node was evicted from the cluster successfully, but the node was not cleaned up.   Extended status information explaining why the node was not cleaned up is available.</para>
        /// </summary>
        public const int ERROR_CLUSTER_EVICT_WITHOUT_CLEANUP = 5896;

        /// <summary>
        /// <para>// MessageId: ERROR_CLUSTER_PARAMETER_MISMATCH</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Two or more parameter values specified for a resource's properties are in conflict.</para>
        /// </summary>
        public const int ERROR_CLUSTER_PARAMETER_MISMATCH = 5897;

        /// <summary>
        /// <para>// MessageId: ERROR_NODE_CANNOT_BE_CLUSTERED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  This computer cannot be made a member of a cluster.</para>
        /// </summary>
        public const int ERROR_NODE_CANNOT_BE_CLUSTERED = 5898;

        /// <summary>
        /// <para>// MessageId: ERROR_CLUSTER_WRONG_OS_VERSION</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  This computer cannot be made a member of a cluster because it does not have the correct version of  Windows installed.</para>
        /// </summary>
        public const int ERROR_CLUSTER_WRONG_OS_VERSION = 5899;

        /// <summary>
        /// <para>// MessageId: ERROR_CLUSTER_CANT_CREATE_DUP_CLUSTER_NAME</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A cluster cannot be created with the specified cluster name because that cluster name is already  in use. Specify a different name for the cluster.</para>
        /// </summary>
        public const int ERROR_CLUSTER_CANT_CREATE_DUP_CLUSTER_NAME = 5900;

        /// <summary>
        /// <para>// MessageId: ERROR_CLUSCFG_ALREADY_COMMITTED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The cluster configuration action has already been committed.</para>
        /// </summary>
        public const int ERROR_CLUSCFG_ALREADY_COMMITTED = 5901;

        /// <summary>
        /// <para>// MessageId: ERROR_CLUSCFG_ROLLBACK_FAILED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The cluster configuration action could not be rolled back.</para>
        /// </summary>
        public const int ERROR_CLUSCFG_ROLLBACK_FAILED = 5902;

        /// <summary>
        /// <para>// MessageId: ERROR_CLUSCFG_SYSTEM_DISK_DRIVE_LETTER_CONFLICT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The drive letter assigned to a system disk on one node conflicted with the drive letter assigned  to a disk on another node.</para>
        /// </summary>
        public const int ERROR_CLUSCFG_SYSTEM_DISK_DRIVE_LETTER_CONFLICT = 5903;

        /// <summary>
        /// <para>// MessageId: ERROR_CLUSTER_OLD_VERSION</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  One or more nodes in the cluster are running a version of Windows that does not support this  operation.</para>
        /// </summary>
        public const int ERROR_CLUSTER_OLD_VERSION = 5904;

        /// <summary>
        /// <para>// MessageId: ERROR_CLUSTER_MISMATCHED_COMPUTER_ACCT_NAME</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The name of the corresponding computer account doesn't match the Network Name for this resource.</para>
        /// </summary>
        public const int ERROR_CLUSTER_MISMATCHED_COMPUTER_ACCT_NAME = 5905;

        /// <summary>
        /// <para>////////////////////////////////////</para>
        /// <para>//                                //</para>
        /// <para>//     EFS Error Codes            //</para>
        /// <para>//                                //</para>
        /// <para>////////////////////////////////////</para>
        /// <para>//</para>
        /// <para>// MessageId: ERROR_ENCRYPTION_FAILED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified file could not be encrypted.</para>
        /// </summary>
        public const int ERROR_ENCRYPTION_FAILED = 6000;

        /// <summary>
        /// <para>// MessageId: ERROR_DECRYPTION_FAILED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified file could not be decrypted.</para>
        /// </summary>
        public const int ERROR_DECRYPTION_FAILED = 6001;

        /// <summary>
        /// <para>// MessageId: ERROR_FILE_ENCRYPTED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified file is encrypted and the user does not have the ability to decrypt it.</para>
        /// </summary>
        public const int ERROR_FILE_ENCRYPTED = 6002;

        /// <summary>
        /// <para>// MessageId: ERROR_NO_RECOVERY_POLICY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  There is no valid encryption recovery policy configured for this system.</para>
        /// </summary>
        public const int ERROR_NO_RECOVERY_POLICY = 6003;

        /// <summary>
        /// <para>// MessageId: ERROR_NO_EFS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The required encryption driver is not loaded for this system.</para>
        /// </summary>
        public const int ERROR_NO_EFS = 6004;

        /// <summary>
        /// <para>// MessageId: ERROR_WRONG_EFS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The file was encrypted with a different encryption driver than is currently loaded.</para>
        /// </summary>
        public const int ERROR_WRONG_EFS = 6005;

        /// <summary>
        /// <para>// MessageId: ERROR_NO_USER_KEYS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  There are no EFS keys defined for the user.</para>
        /// </summary>
        public const int ERROR_NO_USER_KEYS = 6006;

        /// <summary>
        /// <para>// MessageId: ERROR_FILE_NOT_ENCRYPTED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified file is not encrypted.</para>
        /// </summary>
        public const int ERROR_FILE_NOT_ENCRYPTED = 6007;

        /// <summary>
        /// <para>// MessageId: ERROR_NOT_EXPORT_FORMAT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified file is not in the defined EFS export format.</para>
        /// </summary>
        public const int ERROR_NOT_EXPORT_FORMAT = 6008;

        /// <summary>
        /// <para>// MessageId: ERROR_FILE_READ_ONLY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified file is read only.</para>
        /// </summary>
        public const int ERROR_FILE_READ_ONLY = 6009;

        /// <summary>
        /// <para>// MessageId: ERROR_DIR_EFS_DISALLOWED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The directory has been disabled for encryption.</para>
        /// </summary>
        public const int ERROR_DIR_EFS_DISALLOWED = 6010;

        /// <summary>
        /// <para>// MessageId: ERROR_EFS_SERVER_NOT_TRUSTED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The server is not trusted for remote encryption operation.</para>
        /// </summary>
        public const int ERROR_EFS_SERVER_NOT_TRUSTED = 6011;

        /// <summary>
        /// <para>// MessageId: ERROR_BAD_RECOVERY_POLICY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Recovery policy configured for this system contains invalid recovery certificate.</para>
        /// </summary>
        public const int ERROR_BAD_RECOVERY_POLICY = 6012;

        /// <summary>
        /// <para>// MessageId: ERROR_EFS_ALG_BLOB_TOO_BIG</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The encryption algorithm used on the source file needs a bigger key buffer than the one on the  destination file.</para>
        /// </summary>
        public const int ERROR_EFS_ALG_BLOB_TOO_BIG = 6013;

        /// <summary>
        /// <para>// MessageId: ERROR_VOLUME_NOT_SUPPORT_EFS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The disk partition does not support file encryption.</para>
        /// </summary>
        public const int ERROR_VOLUME_NOT_SUPPORT_EFS = 6014;

        /// <summary>
        /// <para>// MessageId: ERROR_EFS_DISABLED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  This machine is disabled for file encryption.</para>
        /// </summary>
        public const int ERROR_EFS_DISABLED = 6015;

        /// <summary>
        /// <para>// MessageId: ERROR_EFS_VERSION_NOT_SUPPORT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A newer system is required to decrypt this encrypted file.</para>
        /// </summary>
        public const int ERROR_EFS_VERSION_NOT_SUPPORT = 6016;

        /// <summary>
        /// <para>// This message number is for historical purposes and cannot be changed or re-used.</para>
        /// <para>//</para>
        /// <para>// MessageId: ERROR_NO_BROWSER_SERVERS_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The list of servers for this workgroup is not currently available</para>
        /// </summary>
        public const int ERROR_NO_BROWSER_SERVERS_FOUND = 6118;

        /// <summary>
        /// <para>//////////////////////////////////////////////////////////////////</para>
        /// <para>//                                                              //</para>
        /// <para>// Task Scheduler Error Codes that NET START must understand    //</para>
        /// <para>//                                                              //</para>
        /// <para>//////////////////////////////////////////////////////////////////</para>
        /// <para>//</para>
        /// <para>// MessageId: SCHED_E_SERVICE_NOT_LOCALSYSTEM</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The Task Scheduler service must be configured to run in the System account to function properly.   Individual tasks may be configured to run in other accounts.</para>
        /// </summary>
        public const int SCHED_E_SERVICE_NOT_LOCALSYSTEM = 6200;

        /// <summary>
        /// <para>////////////////////////////////////</para>
        /// <para>//                                //</para>
        /// <para>// Terminal Server Error Codes    //</para>
        /// <para>//                                //</para>
        /// <para>////////////////////////////////////</para>
        /// <para>//</para>
        /// <para>// MessageId: ERROR_CTX_WINSTATION_NAME_INVALID</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified session name is invalid.</para>
        /// </summary>
        public const int ERROR_CTX_WINSTATION_NAME_INVALID = 7001;

        /// <summary>
        /// <para>// MessageId: ERROR_CTX_INVALID_PD</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified protocol driver is invalid.</para>
        /// </summary>
        public const int ERROR_CTX_INVALID_PD = 7002;

        /// <summary>
        /// <para>// MessageId: ERROR_CTX_PD_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified protocol driver was not found in the system path.</para>
        /// </summary>
        public const int ERROR_CTX_PD_NOT_FOUND = 7003;

        /// <summary>
        /// <para>// MessageId: ERROR_CTX_WD_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified terminal connection driver was not found in the system path.</para>
        /// </summary>
        public const int ERROR_CTX_WD_NOT_FOUND = 7004;

        /// <summary>
        /// <para>// MessageId: ERROR_CTX_CANNOT_MAKE_EVENTLOG_ENTRY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A registry key for event logging could not be created for this session.</para>
        /// </summary>
        public const int ERROR_CTX_CANNOT_MAKE_EVENTLOG_ENTRY = 7005;

        /// <summary>
        /// <para>// MessageId: ERROR_CTX_SERVICE_NAME_COLLISION</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A service with the same name already exists on the system.</para>
        /// </summary>
        public const int ERROR_CTX_SERVICE_NAME_COLLISION = 7006;

        /// <summary>
        /// <para>// MessageId: ERROR_CTX_CLOSE_PENDING</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A close operation is pending on the session.</para>
        /// </summary>
        public const int ERROR_CTX_CLOSE_PENDING = 7007;

        /// <summary>
        /// <para>// MessageId: ERROR_CTX_NO_OUTBUF</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  There are no free output buffers available.</para>
        /// </summary>
        public const int ERROR_CTX_NO_OUTBUF = 7008;

        /// <summary>
        /// <para>// MessageId: ERROR_CTX_MODEM_INF_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The MODEM.INF file was not found.</para>
        /// </summary>
        public const int ERROR_CTX_MODEM_INF_NOT_FOUND = 7009;

        /// <summary>
        /// <para>// MessageId: ERROR_CTX_INVALID_MODEMNAME</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The modem name was not found in MODEM.INF.</para>
        /// </summary>
        public const int ERROR_CTX_INVALID_MODEMNAME = 7010;

        /// <summary>
        /// <para>// MessageId: ERROR_CTX_MODEM_RESPONSE_ERROR</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The modem did not accept the command sent to it. Verify that the configured modem name matches the  attached modem.</para>
        /// </summary>
        public const int ERROR_CTX_MODEM_RESPONSE_ERROR = 7011;

        /// <summary>
        /// <para>// MessageId: ERROR_CTX_MODEM_RESPONSE_TIMEOUT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The modem did not respond to the command sent to it. Verify that the modem is properly cabled and  powered on.</para>
        /// </summary>
        public const int ERROR_CTX_MODEM_RESPONSE_TIMEOUT = 7012;

        /// <summary>
        /// <para>// MessageId: ERROR_CTX_MODEM_RESPONSE_NO_CARRIER</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Carrier detect has failed or carrier has been dropped due to disconnect.</para>
        /// </summary>
        public const int ERROR_CTX_MODEM_RESPONSE_NO_CARRIER = 7013;

        /// <summary>
        /// <para>// MessageId: ERROR_CTX_MODEM_RESPONSE_NO_DIALTONE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Dial tone not detected within the required time. Verify that the phone cable is properly attached  and functional.</para>
        /// </summary>
        public const int ERROR_CTX_MODEM_RESPONSE_NO_DIALTONE = 7014;

        /// <summary>
        /// <para>// MessageId: ERROR_CTX_MODEM_RESPONSE_BUSY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Busy signal detected at remote site on callback.</para>
        /// </summary>
        public const int ERROR_CTX_MODEM_RESPONSE_BUSY = 7015;

        /// <summary>
        /// <para>// MessageId: ERROR_CTX_MODEM_RESPONSE_VOICE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Voice detected at remote site on callback.</para>
        /// </summary>
        public const int ERROR_CTX_MODEM_RESPONSE_VOICE = 7016;

        /// <summary>
        /// <para>// MessageId: ERROR_CTX_TD_ERROR</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Transport driver error</para>
        /// </summary>
        public const int ERROR_CTX_TD_ERROR = 7017;

        /// <summary>
        /// <para>// MessageId: ERROR_CTX_WINSTATION_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified session cannot be found.</para>
        /// </summary>
        public const int ERROR_CTX_WINSTATION_NOT_FOUND = 7022;

        /// <summary>
        /// <para>// MessageId: ERROR_CTX_WINSTATION_ALREADY_EXISTS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified session name is already in use.</para>
        /// </summary>
        public const int ERROR_CTX_WINSTATION_ALREADY_EXISTS = 7023;

        /// <summary>
        /// <para>// MessageId: ERROR_CTX_WINSTATION_BUSY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The requested operation cannot be completed because the terminal connection is currently busy  processing a connect, disconnect, reset, or delete operation.</para>
        /// </summary>
        public const int ERROR_CTX_WINSTATION_BUSY = 7024;

        /// <summary>
        /// <para>// MessageId: ERROR_CTX_BAD_VIDEO_MODE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An attempt has been made to connect to a session whose video mode is not supported by the current  client.</para>
        /// </summary>
        public const int ERROR_CTX_BAD_VIDEO_MODE = 7025;

        /// <summary>
        /// <para>// MessageId: ERROR_CTX_GRAPHICS_INVALID</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The application attempted to enable DOS graphics mode.</para>
        /// <para>//  DOS graphics mode is not supported.</para>
        /// </summary>
        public const int ERROR_CTX_GRAPHICS_INVALID = 7035;

        /// <summary>
        /// <para>// MessageId: ERROR_CTX_LOGON_DISABLED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Your interactive logon privilege has been disabled.</para>
        /// <para>//  Please contact your administrator.</para>
        /// </summary>
        public const int ERROR_CTX_LOGON_DISABLED = 7037;

        /// <summary>
        /// <para>// MessageId: ERROR_CTX_NOT_CONSOLE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The requested operation can be performed only on the system console.</para>
        /// <para>//  This is most often the result of a driver or system DLL requiring direct console access.</para>
        /// </summary>
        public const int ERROR_CTX_NOT_CONSOLE = 7038;

        /// <summary>
        /// <para>// MessageId: ERROR_CTX_CLIENT_QUERY_TIMEOUT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The client failed to respond to the server connect message.</para>
        /// </summary>
        public const int ERROR_CTX_CLIENT_QUERY_TIMEOUT = 7040;

        /// <summary>
        /// <para>// MessageId: ERROR_CTX_CONSOLE_DISCONNECT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Disconnecting the console session is not supported.</para>
        /// </summary>
        public const int ERROR_CTX_CONSOLE_DISCONNECT = 7041;

        /// <summary>
        /// <para>// MessageId: ERROR_CTX_CONSOLE_CONNECT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Reconnecting a disconnected session to the console is not supported.</para>
        /// </summary>
        public const int ERROR_CTX_CONSOLE_CONNECT = 7042;

        /// <summary>
        /// <para>// MessageId: ERROR_CTX_SHADOW_DENIED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The request to control another session remotely was denied.</para>
        /// </summary>
        public const int ERROR_CTX_SHADOW_DENIED = 7044;

        /// <summary>
        /// <para>// MessageId: ERROR_CTX_WINSTATION_ACCESS_DENIED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The requested session access is denied.</para>
        /// </summary>
        public const int ERROR_CTX_WINSTATION_ACCESS_DENIED = 7045;

        /// <summary>
        /// <para>// MessageId: ERROR_CTX_INVALID_WD</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified terminal connection driver is invalid.</para>
        /// </summary>
        public const int ERROR_CTX_INVALID_WD = 7049;

        /// <summary>
        /// <para>// MessageId: ERROR_CTX_SHADOW_INVALID</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The requested session cannot be controlled remotely.</para>
        /// <para>//  This may be because the session is disconnected or does not currently have a user logged on.</para>
        /// </summary>
        public const int ERROR_CTX_SHADOW_INVALID = 7050;

        /// <summary>
        /// <para>// MessageId: ERROR_CTX_SHADOW_DISABLED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The requested session is not configured to allow remote control.</para>
        /// </summary>
        public const int ERROR_CTX_SHADOW_DISABLED = 7051;

        /// <summary>
        /// <para>// MessageId: ERROR_CTX_CLIENT_LICENSE_IN_USE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Your request to connect to this Terminal Server has been rejected. Your Terminal Server client  license number is currently being used by another user.</para>
        /// <para>//  Please call your system administrator to obtain a unique license number.</para>
        /// </summary>
        public const int ERROR_CTX_CLIENT_LICENSE_IN_USE = 7052;

        /// <summary>
        /// <para>// MessageId: ERROR_CTX_CLIENT_LICENSE_NOT_SET</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Your request to connect to this Terminal Server has been rejected. Your Terminal Server client  license number has not been entered for this copy of the Terminal Server client.</para>
        /// <para>//  Please contact your system administrator.</para>
        /// </summary>
        public const int ERROR_CTX_CLIENT_LICENSE_NOT_SET = 7053;

        /// <summary>
        /// <para>// MessageId: ERROR_CTX_LICENSE_NOT_AVAILABLE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The system has reached its licensed logon limit.</para>
        /// <para>//  Please try again later.</para>
        /// </summary>
        public const int ERROR_CTX_LICENSE_NOT_AVAILABLE = 7054;

        /// <summary>
        /// <para>// MessageId: ERROR_CTX_LICENSE_CLIENT_INVALID</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The client you are using is not licensed to use this system.  Your logon request is denied.</para>
        /// </summary>
        public const int ERROR_CTX_LICENSE_CLIENT_INVALID = 7055;

        /// <summary>
        /// <para>// MessageId: ERROR_CTX_LICENSE_EXPIRED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The system license has expired.  Your logon request is denied.</para>
        /// </summary>
        public const int ERROR_CTX_LICENSE_EXPIRED = 7056;

        /// <summary>
        /// <para>// MessageId: ERROR_CTX_SHADOW_NOT_RUNNING</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Remote control could not be terminated because the specified session is not currently being  remotely controlled.</para>
        /// </summary>
        public const int ERROR_CTX_SHADOW_NOT_RUNNING = 7057;

        /// <summary>
        /// <para>// MessageId: ERROR_CTX_SHADOW_ENDED_BY_MODE_CHANGE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The remote control of the console was terminated because the display mode was changed. Changing  the display mode in a remote control session is not supported.</para>
        /// </summary>
        public const int ERROR_CTX_SHADOW_ENDED_BY_MODE_CHANGE = 7058;

        /// <summary>
        /// <para>// MessageId: ERROR_ACTIVATION_COUNT_EXCEEDED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Activation has already been reset the maximum number of times for this installation. Your  activation timer will not be cleared.</para>
        /// </summary>
        public const int ERROR_ACTIVATION_COUNT_EXCEEDED = 7059;

        /// <summary>
        /// <para>///////////////////////////////////////////////////</para>
        /// <para>//                                                /</para>
        /// <para>//             Traffic Control Error Codes        /</para>
        /// <para>//                                                /</para>
        /// <para>//                  7500 to  7999                 /</para>
        /// <para>//                                                /</para>
        /// <para>//         defined in: tcerror.h                  /</para>
        /// <para>///////////////////////////////////////////////////</para>
        /// <para>///////////////////////////////////////////////////</para>
        /// <para>//                                                /</para>
        /// <para>//             Active Directory Error Codes       /</para>
        /// <para>//                                                /</para>
        /// <para>//                  8000 to  8999                 /</para>
        /// <para>///////////////////////////////////////////////////</para>
        /// <para>// *****************</para>
        /// <para>// FACILITY_FILE_REPLICATION_SERVICE</para>
        /// <para>// *****************</para>
        /// <para>//</para>
        /// <para>// MessageId: FRS_ERR_INVALID_API_SEQUENCE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The file replication service API was called incorrectly.</para>
        /// </summary>
        public const int FRS_ERR_INVALID_API_SEQUENCE = 8001;

        /// <summary>
        /// <para>// MessageId: FRS_ERR_STARTING_SERVICE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The file replication service cannot be started.</para>
        /// </summary>
        public const int FRS_ERR_STARTING_SERVICE = 8002;

        /// <summary>
        /// <para>// MessageId: FRS_ERR_STOPPING_SERVICE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The file replication service cannot be stopped.</para>
        /// </summary>
        public const int FRS_ERR_STOPPING_SERVICE = 8003;

        /// <summary>
        /// <para>// MessageId: FRS_ERR_INTERNAL_API</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The file replication service API terminated the request.</para>
        /// <para>//  The event log may have more information.</para>
        /// </summary>
        public const int FRS_ERR_INTERNAL_API = 8004;

        /// <summary>
        /// <para>// MessageId: FRS_ERR_INTERNAL</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The file replication service terminated the request.</para>
        /// <para>//  The event log may have more information.</para>
        /// </summary>
        public const int FRS_ERR_INTERNAL = 8005;

        /// <summary>
        /// <para>// MessageId: FRS_ERR_SERVICE_COMM</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The file replication service cannot be contacted.</para>
        /// <para>//  The event log may have more information.</para>
        /// </summary>
        public const int FRS_ERR_SERVICE_COMM = 8006;

        /// <summary>
        /// <para>// MessageId: FRS_ERR_INSUFFICIENT_PRIV</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The file replication service cannot satisfy the request because the user has insufficient  privileges.</para>
        /// <para>//  The event log may have more information.</para>
        /// </summary>
        public const int FRS_ERR_INSUFFICIENT_PRIV = 8007;

        /// <summary>
        /// <para>// MessageId: FRS_ERR_AUTHENTICATION</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The file replication service cannot satisfy the request because authenticated RPC is not  available.</para>
        /// <para>//  The event log may have more information.</para>
        /// </summary>
        public const int FRS_ERR_AUTHENTICATION = 8008;

        /// <summary>
        /// <para>// MessageId: FRS_ERR_PARENT_INSUFFICIENT_PRIV</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The file replication service cannot satisfy the request because the user has insufficient  privileges on the domain controller.</para>
        /// <para>//  The event log may have more information.</para>
        /// </summary>
        public const int FRS_ERR_PARENT_INSUFFICIENT_PRIV = 8009;

        /// <summary>
        /// <para>// MessageId: FRS_ERR_PARENT_AUTHENTICATION</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The file replication service cannot satisfy the request because authenticated RPC is not available  on the domain controller.</para>
        /// <para>//  The event log may have more information.</para>
        /// </summary>
        public const int FRS_ERR_PARENT_AUTHENTICATION = 8010;

        /// <summary>
        /// <para>// MessageId: FRS_ERR_CHILD_TO_PARENT_COMM</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The file replication service cannot communicate with the file replication service on the domain  controller.</para>
        /// <para>//  The event log may have more information.</para>
        /// </summary>
        public const int FRS_ERR_CHILD_TO_PARENT_COMM = 8011;

        /// <summary>
        /// <para>// MessageId: FRS_ERR_PARENT_TO_CHILD_COMM</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The file replication service on the domain controller cannot communicate with the file replication  service on this computer.</para>
        /// <para>//  The event log may have more information.</para>
        /// </summary>
        public const int FRS_ERR_PARENT_TO_CHILD_COMM = 8012;

        /// <summary>
        /// <para>// MessageId: FRS_ERR_SYSVOL_POPULATE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The file replication service cannot populate the system volume because of an internal error.</para>
        /// <para>//  The event log may have more information.</para>
        /// </summary>
        public const int FRS_ERR_SYSVOL_POPULATE = 8013;

        /// <summary>
        /// <para>// MessageId: FRS_ERR_SYSVOL_POPULATE_TIMEOUT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The file replication service cannot populate the system volume because of an internal timeout.</para>
        /// <para>//  The event log may have more information.</para>
        /// </summary>
        public const int FRS_ERR_SYSVOL_POPULATE_TIMEOUT = 8014;

        /// <summary>
        /// <para>// MessageId: FRS_ERR_SYSVOL_IS_BUSY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The file replication service cannot process the request. The system volume is busy with a previous  request.</para>
        /// </summary>
        public const int FRS_ERR_SYSVOL_IS_BUSY = 8015;

        /// <summary>
        /// <para>// MessageId: FRS_ERR_SYSVOL_DEMOTE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The file replication service cannot stop replicating the system volume because of an internal  error.</para>
        /// <para>//  The event log may have more information.</para>
        /// </summary>
        public const int FRS_ERR_SYSVOL_DEMOTE = 8016;

        /// <summary>
        /// <para>// MessageId: FRS_ERR_INVALID_SERVICE_PARAMETER</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The file replication service detected an invalid parameter.</para>
        /// </summary>
        public const int FRS_ERR_INVALID_SERVICE_PARAMETER = 8017;

        /// <summary>
        /// <para>// *****************</para>
        /// <para>// FACILITY DIRECTORY SERVICE</para>
        /// <para>// *****************</para>
        /// </summary> 
        public const int DS_S_SUCCESS = NO_ERROR;
        /// <summary>
        /// <para>// MessageId: ERROR_DS_NOT_INSTALLED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An error occurred while installing the directory service. For more information, see the event log.</para>
        /// </summary>
        public const int ERROR_DS_NOT_INSTALLED = 8200;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_MEMBERSHIP_EVALUATED_LOCALLY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The directory service evaluated group memberships locally.</para>
        /// </summary>
        public const int ERROR_DS_MEMBERSHIP_EVALUATED_LOCALLY = 8201;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_NO_ATTRIBUTE_OR_VALUE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified directory service attribute or value does not exist.</para>
        /// </summary>
        public const int ERROR_DS_NO_ATTRIBUTE_OR_VALUE = 8202;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_INVALID_ATTRIBUTE_SYNTAX</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The attribute syntax specified to the directory service is invalid.</para>
        /// </summary>
        public const int ERROR_DS_INVALID_ATTRIBUTE_SYNTAX = 8203;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_ATTRIBUTE_TYPE_UNDEFINED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The attribute type specified to the directory service is not defined.</para>
        /// </summary>
        public const int ERROR_DS_ATTRIBUTE_TYPE_UNDEFINED = 8204;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_ATTRIBUTE_OR_VALUE_EXISTS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified directory service attribute or value already exists.</para>
        /// </summary>
        public const int ERROR_DS_ATTRIBUTE_OR_VALUE_EXISTS = 8205;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_BUSY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The directory service is busy.</para>
        /// </summary>
        public const int ERROR_DS_BUSY = 8206;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_UNAVAILABLE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The directory service is unavailable.</para>
        /// </summary>
        public const int ERROR_DS_UNAVAILABLE = 8207;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_NO_RIDS_ALLOCATED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The directory service was unable to allocate a relative identifier.</para>
        /// </summary>
        public const int ERROR_DS_NO_RIDS_ALLOCATED = 8208;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_NO_MORE_RIDS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The directory service has exhausted the pool of relative identifiers.</para>
        /// </summary>
        public const int ERROR_DS_NO_MORE_RIDS = 8209;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_INCORRECT_ROLE_OWNER</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The requested operation could not be performed because the directory service is not the master for  that type of operation.</para>
        /// </summary>
        public const int ERROR_DS_INCORRECT_ROLE_OWNER = 8210;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_RIDMGR_INIT_ERROR</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The directory service was unable to initialize the subsystem that allocates relative identifiers.</para>
        /// </summary>
        public const int ERROR_DS_RIDMGR_INIT_ERROR = 8211;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_OBJ_CLASS_VIOLATION</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The requested operation did not satisfy one or more constraints associated with the class of the  object.</para>
        /// </summary>
        public const int ERROR_DS_OBJ_CLASS_VIOLATION = 8212;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_CANT_ON_NON_LEAF</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The directory service can perform the requested operation only on a leaf object.</para>
        /// </summary>
        public const int ERROR_DS_CANT_ON_NON_LEAF = 8213;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_CANT_ON_RDN</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The directory service cannot perform the requested operation on the RDN attribute of an object.</para>
        /// </summary>
        public const int ERROR_DS_CANT_ON_RDN = 8214;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_CANT_MOD_OBJ_CLASS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The directory service detected an attempt to modify the object class of an object.</para>
        /// </summary>
        public const int ERROR_DS_CANT_MOD_OBJ_CLASS = 8215;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_CROSS_DOM_MOVE_ERROR</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The requested cross-domain move operation could not be performed.</para>
        /// </summary>
        public const int ERROR_DS_CROSS_DOM_MOVE_ERROR = 8216;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_GC_NOT_AVAILABLE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Unable to contact the global catalog server.</para>
        /// </summary>
        public const int ERROR_DS_GC_NOT_AVAILABLE = 8217;

        /// <summary>
        /// <para>// MessageId: ERROR_SHARED_POLICY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The policy object is shared and can only be modified at the root.</para>
        /// </summary>
        public const int ERROR_SHARED_POLICY = 8218;

        /// <summary>
        /// <para>// MessageId: ERROR_POLICY_OBJECT_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The policy object does not exist.</para>
        /// </summary>
        public const int ERROR_POLICY_OBJECT_NOT_FOUND = 8219;

        /// <summary>
        /// <para>// MessageId: ERROR_POLICY_ONLY_IN_DS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The requested policy information is only in the directory service.</para>
        /// </summary>
        public const int ERROR_POLICY_ONLY_IN_DS = 8220;

        /// <summary>
        /// <para>// MessageId: ERROR_PROMOTION_ACTIVE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A domain controller promotion is currently active.</para>
        /// </summary>
        public const int ERROR_PROMOTION_ACTIVE = 8221;

        /// <summary>
        /// <para>// MessageId: ERROR_NO_PROMOTION_ACTIVE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A domain controller promotion is not currently active</para>
        /// </summary>
        public const int ERROR_NO_PROMOTION_ACTIVE = 8222;

        /// <summary>
        /// <para>// 8223 unused</para>
        /// <para>//</para>
        /// <para>// MessageId: ERROR_DS_OPERATIONS_ERROR</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An operations error occurred.</para>
        /// </summary>
        public const int ERROR_DS_OPERATIONS_ERROR = 8224;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_PROTOCOL_ERROR</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A protocol error occurred.</para>
        /// </summary>
        public const int ERROR_DS_PROTOCOL_ERROR = 8225;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_TIMELIMIT_EXCEEDED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The time limit for this request was exceeded.</para>
        /// </summary>
        public const int ERROR_DS_TIMELIMIT_EXCEEDED = 8226;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_SIZELIMIT_EXCEEDED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The size limit for this request was exceeded.</para>
        /// </summary>
        public const int ERROR_DS_SIZELIMIT_EXCEEDED = 8227;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_ADMIN_LIMIT_EXCEEDED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The administrative limit for this request was exceeded.</para>
        /// </summary>
        public const int ERROR_DS_ADMIN_LIMIT_EXCEEDED = 8228;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_COMPARE_FALSE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The compare response was false.</para>
        /// </summary>
        public const int ERROR_DS_COMPARE_FALSE = 8229;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_COMPARE_TRUE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The compare response was true.</para>
        /// </summary>
        public const int ERROR_DS_COMPARE_TRUE = 8230;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_AUTH_METHOD_NOT_SUPPORTED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The requested authentication method is not supported by the server.</para>
        /// </summary>
        public const int ERROR_DS_AUTH_METHOD_NOT_SUPPORTED = 8231;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_STRONG_AUTH_REQUIRED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A more secure authentication method is required for this server.</para>
        /// </summary>
        public const int ERROR_DS_STRONG_AUTH_REQUIRED = 8232;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_INAPPROPRIATE_AUTH</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Inappropriate authentication.</para>
        /// </summary>
        public const int ERROR_DS_INAPPROPRIATE_AUTH = 8233;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_AUTH_UNKNOWN</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The authentication mechanism is unknown.</para>
        /// </summary>
        public const int ERROR_DS_AUTH_UNKNOWN = 8234;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_REFERRAL</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A referral was returned from the server.</para>
        /// </summary>
        public const int ERROR_DS_REFERRAL = 8235;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_UNAVAILABLE_CRIT_EXTENSION</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The server does not support the requested critical extension.</para>
        /// </summary>
        public const int ERROR_DS_UNAVAILABLE_CRIT_EXTENSION = 8236;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_CONFIDENTIALITY_REQUIRED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  This request requires a secure connection.</para>
        /// </summary>
        public const int ERROR_DS_CONFIDENTIALITY_REQUIRED = 8237;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_INAPPROPRIATE_MATCHING</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Inappropriate matching.</para>
        /// </summary>
        public const int ERROR_DS_INAPPROPRIATE_MATCHING = 8238;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_CONSTRAINT_VIOLATION</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A constraint violation occurred.</para>
        /// </summary>
        public const int ERROR_DS_CONSTRAINT_VIOLATION = 8239;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_NO_SUCH_OBJECT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  There is no such object on the server.</para>
        /// </summary>
        public const int ERROR_DS_NO_SUCH_OBJECT = 8240;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_ALIAS_PROBLEM</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  There is an alias problem.</para>
        /// </summary>
        public const int ERROR_DS_ALIAS_PROBLEM = 8241;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_INVALID_DN_SYNTAX</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An invalid dn syntax has been specified.</para>
        /// </summary>
        public const int ERROR_DS_INVALID_DN_SYNTAX = 8242;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_IS_LEAF</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The object is a leaf object.</para>
        /// </summary>
        public const int ERROR_DS_IS_LEAF = 8243;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_ALIAS_DEREF_PROBLEM</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  There is an alias dereferencing problem.</para>
        /// </summary>
        public const int ERROR_DS_ALIAS_DEREF_PROBLEM = 8244;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_UNWILLING_TO_PERFORM</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The server is unwilling to process the request.</para>
        /// </summary>
        public const int ERROR_DS_UNWILLING_TO_PERFORM = 8245;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_LOOP_DETECT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A loop has been detected.</para>
        /// </summary>
        public const int ERROR_DS_LOOP_DETECT = 8246;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_NAMING_VIOLATION</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  There is a naming violation.</para>
        /// </summary>
        public const int ERROR_DS_NAMING_VIOLATION = 8247;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_OBJECT_RESULTS_TOO_LARGE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The result set is too large.</para>
        /// </summary>
        public const int ERROR_DS_OBJECT_RESULTS_TOO_LARGE = 8248;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_AFFECTS_MULTIPLE_DSAS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The operation affects multiple DSAs</para>
        /// </summary>
        public const int ERROR_DS_AFFECTS_MULTIPLE_DSAS = 8249;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_SERVER_DOWN</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The server is not operational.</para>
        /// </summary>
        public const int ERROR_DS_SERVER_DOWN = 8250;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_LOCAL_ERROR</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A local error has occurred.</para>
        /// </summary>
        public const int ERROR_DS_LOCAL_ERROR = 8251;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_ENCODING_ERROR</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An encoding error has occurred.</para>
        /// </summary>
        public const int ERROR_DS_ENCODING_ERROR = 8252;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_DECODING_ERROR</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A decoding error has occurred.</para>
        /// </summary>
        public const int ERROR_DS_DECODING_ERROR = 8253;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_FILTER_UNKNOWN</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The search filter cannot be recognized.</para>
        /// </summary>
        public const int ERROR_DS_FILTER_UNKNOWN = 8254;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_PARAM_ERROR</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  One or more parameters are illegal.</para>
        /// </summary>
        public const int ERROR_DS_PARAM_ERROR = 8255;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_NOT_SUPPORTED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified method is not supported.</para>
        /// </summary>
        public const int ERROR_DS_NOT_SUPPORTED = 8256;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_NO_RESULTS_RETURNED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  No results were returned.</para>
        /// </summary>
        public const int ERROR_DS_NO_RESULTS_RETURNED = 8257;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_CONTROL_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified control is not supported by the server.</para>
        /// </summary>
        public const int ERROR_DS_CONTROL_NOT_FOUND = 8258;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_CLIENT_LOOP</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A referral loop was detected by the client.</para>
        /// </summary>
        public const int ERROR_DS_CLIENT_LOOP = 8259;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_REFERRAL_LIMIT_EXCEEDED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The preset referral limit was exceeded.</para>
        /// </summary>
        public const int ERROR_DS_REFERRAL_LIMIT_EXCEEDED = 8260;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_SORT_CONTROL_MISSING</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The search requires a SORT control.</para>
        /// </summary>
        public const int ERROR_DS_SORT_CONTROL_MISSING = 8261;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_OFFSET_RANGE_ERROR</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The search results exceed the offset range specified.</para>
        /// </summary>
        public const int ERROR_DS_OFFSET_RANGE_ERROR = 8262;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_ROOT_MUST_BE_NC</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The root object must be the head of a naming context. The root object cannot have an instantiated  parent.</para>
        /// </summary>
        public const int ERROR_DS_ROOT_MUST_BE_NC = 8301;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_ADD_REPLICA_INHIBITED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The add replica operation cannot be performed. The naming context must be writeable in order to  create the replica.</para>
        /// </summary>
        public const int ERROR_DS_ADD_REPLICA_INHIBITED = 8302;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_ATT_NOT_DEF_IN_SCHEMA</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A reference to an attribute that is not defined in the schema occurred.</para>
        /// </summary>
        public const int ERROR_DS_ATT_NOT_DEF_IN_SCHEMA = 8303;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_MAX_OBJ_SIZE_EXCEEDED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The maximum size of an object has been exceeded.</para>
        /// </summary>
        public const int ERROR_DS_MAX_OBJ_SIZE_EXCEEDED = 8304;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_OBJ_STRING_NAME_EXISTS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An attempt was made to add an object to the directory with a name that is already in use.</para>
        /// </summary>
        public const int ERROR_DS_OBJ_STRING_NAME_EXISTS = 8305;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_NO_RDN_DEFINED_IN_SCHEMA</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An attempt was made to add an object of a class that does not have an RDN defined in the schema.</para>
        /// </summary>
        public const int ERROR_DS_NO_RDN_DEFINED_IN_SCHEMA = 8306;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_RDN_DOESNT_MATCH_SCHEMA</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An attempt was made to add an object using an RDN that is not the RDN defined in the schema.</para>
        /// </summary>
        public const int ERROR_DS_RDN_DOESNT_MATCH_SCHEMA = 8307;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_NO_REQUESTED_ATTS_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  None of the requested attributes were found on the objects.</para>
        /// </summary>
        public const int ERROR_DS_NO_REQUESTED_ATTS_FOUND = 8308;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_USER_BUFFER_TO_SMALL</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The user buffer is too small.</para>
        /// </summary>
        public const int ERROR_DS_USER_BUFFER_TO_SMALL = 8309;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_ATT_IS_NOT_ON_OBJ</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The attribute specified in the operation is not present on the object.</para>
        /// </summary>
        public const int ERROR_DS_ATT_IS_NOT_ON_OBJ = 8310;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_ILLEGAL_MOD_OPERATION</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Illegal modify operation. Some aspect of the modification is not permitted.</para>
        /// </summary>
        public const int ERROR_DS_ILLEGAL_MOD_OPERATION = 8311;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_OBJ_TOO_LARGE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified object is too large.</para>
        /// </summary>
        public const int ERROR_DS_OBJ_TOO_LARGE = 8312;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_BAD_INSTANCE_TYPE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified instance type is not valid.</para>
        /// </summary>
        public const int ERROR_DS_BAD_INSTANCE_TYPE = 8313;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_MASTERDSA_REQUIRED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The operation must be performed at a master DSA.</para>
        /// </summary>
        public const int ERROR_DS_MASTERDSA_REQUIRED = 8314;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_OBJECT_CLASS_REQUIRED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The object class attribute must be specified.</para>
        /// </summary>
        public const int ERROR_DS_OBJECT_CLASS_REQUIRED = 8315;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_MISSING_REQUIRED_ATT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A required attribute is missing.</para>
        /// </summary>
        public const int ERROR_DS_MISSING_REQUIRED_ATT = 8316;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_ATT_NOT_DEF_FOR_CLASS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An attempt was made to modify an object to include an attribute that is not legal for its class.</para>
        /// </summary>
        public const int ERROR_DS_ATT_NOT_DEF_FOR_CLASS = 8317;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_ATT_ALREADY_EXISTS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified attribute is already present on the object.</para>
        /// </summary>
        public const int ERROR_DS_ATT_ALREADY_EXISTS = 8318;

        /// <summary>
        /// <para>// 8319 unused</para>
        /// <para>//</para>
        /// <para>// MessageId: ERROR_DS_CANT_ADD_ATT_VALUES</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified attribute is not present, or has no values.</para>
        /// </summary>
        public const int ERROR_DS_CANT_ADD_ATT_VALUES = 8320;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_SINGLE_VALUE_CONSTRAINT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Multiple values were specified for an attribute that can have only one value.</para>
        /// </summary>
        public const int ERROR_DS_SINGLE_VALUE_CONSTRAINT = 8321;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_RANGE_CONSTRAINT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A value for the attribute was not in the acceptable range of values.</para>
        /// </summary>
        public const int ERROR_DS_RANGE_CONSTRAINT = 8322;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_ATT_VAL_ALREADY_EXISTS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified value already exists.</para>
        /// </summary>
        public const int ERROR_DS_ATT_VAL_ALREADY_EXISTS = 8323;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_CANT_REM_MISSING_ATT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The attribute cannot be removed because it is not present on the object.</para>
        /// </summary>
        public const int ERROR_DS_CANT_REM_MISSING_ATT = 8324;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_CANT_REM_MISSING_ATT_VAL</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The attribute value cannot be removed because it is not present on the object.</para>
        /// </summary>
        public const int ERROR_DS_CANT_REM_MISSING_ATT_VAL = 8325;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_ROOT_CANT_BE_SUBREF</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified root object cannot be a subref.</para>
        /// </summary>
        public const int ERROR_DS_ROOT_CANT_BE_SUBREF = 8326;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_NO_CHAINING</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Chaining is not permitted.</para>
        /// </summary>
        public const int ERROR_DS_NO_CHAINING = 8327;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_NO_CHAINED_EVAL</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Chained evaluation is not permitted.</para>
        /// </summary>
        public const int ERROR_DS_NO_CHAINED_EVAL = 8328;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_NO_PARENT_OBJECT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The operation could not be performed because the object's parent is either uninstantiated or  deleted.</para>
        /// </summary>
        public const int ERROR_DS_NO_PARENT_OBJECT = 8329;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_PARENT_IS_AN_ALIAS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Having a parent that is an alias is not permitted. Aliases are leaf objects.</para>
        /// </summary>
        public const int ERROR_DS_PARENT_IS_AN_ALIAS = 8330;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_CANT_MIX_MASTER_AND_REPS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The object and parent must be of the same type, either both masters or both replicas.</para>
        /// </summary>
        public const int ERROR_DS_CANT_MIX_MASTER_AND_REPS = 8331;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_CHILDREN_EXIST</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The operation cannot be performed because child objects exist. This operation can only be  performed on a leaf object.</para>
        /// </summary>
        public const int ERROR_DS_CHILDREN_EXIST = 8332;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_OBJ_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Directory object not found.</para>
        /// </summary>
        public const int ERROR_DS_OBJ_NOT_FOUND = 8333;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_ALIASED_OBJ_MISSING</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The aliased object is missing.</para>
        /// </summary>
        public const int ERROR_DS_ALIASED_OBJ_MISSING = 8334;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_BAD_NAME_SYNTAX</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The object name has bad syntax.</para>
        /// </summary>
        public const int ERROR_DS_BAD_NAME_SYNTAX = 8335;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_ALIAS_POINTS_TO_ALIAS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  It is not permitted for an alias to refer to another alias.</para>
        /// </summary>
        public const int ERROR_DS_ALIAS_POINTS_TO_ALIAS = 8336;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_CANT_DEREF_ALIAS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The alias cannot be dereferenced.</para>
        /// </summary>
        public const int ERROR_DS_CANT_DEREF_ALIAS = 8337;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_OUT_OF_SCOPE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The operation is out of scope.</para>
        /// </summary>
        public const int ERROR_DS_OUT_OF_SCOPE = 8338;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_OBJECT_BEING_REMOVED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The operation cannot continue because the object is in the process of being removed.</para>
        /// </summary>
        public const int ERROR_DS_OBJECT_BEING_REMOVED = 8339;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_CANT_DELETE_DSA_OBJ</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The DSA object cannot be deleted.</para>
        /// </summary>
        public const int ERROR_DS_CANT_DELETE_DSA_OBJ = 8340;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_GENERIC_ERROR</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A directory service error has occurred.</para>
        /// </summary>
        public const int ERROR_DS_GENERIC_ERROR = 8341;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_DSA_MUST_BE_INT_MASTER</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The operation can only be performed on an internal master DSA object.</para>
        /// </summary>
        public const int ERROR_DS_DSA_MUST_BE_INT_MASTER = 8342;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_CLASS_NOT_DSA</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The object must be of class DSA.</para>
        /// </summary>
        public const int ERROR_DS_CLASS_NOT_DSA = 8343;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_INSUFF_ACCESS_RIGHTS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Insufficient access rights to perform the operation.</para>
        /// </summary>
        public const int ERROR_DS_INSUFF_ACCESS_RIGHTS = 8344;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_ILLEGAL_SUPERIOR</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The object cannot be added because the parent is not on the list of possible superiors.</para>
        /// </summary>
        public const int ERROR_DS_ILLEGAL_SUPERIOR = 8345;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_ATTRIBUTE_OWNED_BY_SAM</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Access to the attribute is not permitted because the attribute is owned by the Security Accounts  Manager (SAM).</para>
        /// </summary>
        public const int ERROR_DS_ATTRIBUTE_OWNED_BY_SAM = 8346;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_NAME_TOO_MANY_PARTS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The name has too many parts.</para>
        /// </summary>
        public const int ERROR_DS_NAME_TOO_MANY_PARTS = 8347;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_NAME_TOO_LONG</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The name is too long.</para>
        /// </summary>
        public const int ERROR_DS_NAME_TOO_LONG = 8348;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_NAME_VALUE_TOO_LONG</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The name value is too long.</para>
        /// </summary>
        public const int ERROR_DS_NAME_VALUE_TOO_LONG = 8349;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_NAME_UNPARSEABLE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The directory service encountered an error parsing a name.</para>
        /// </summary>
        public const int ERROR_DS_NAME_UNPARSEABLE = 8350;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_NAME_TYPE_UNKNOWN</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The directory service cannot get the attribute type for a name.</para>
        /// </summary>
        public const int ERROR_DS_NAME_TYPE_UNKNOWN = 8351;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_NOT_AN_OBJECT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The name does not identify an object; the name identifies a phantom.</para>
        /// </summary>
        public const int ERROR_DS_NOT_AN_OBJECT = 8352;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_SEC_DESC_TOO_SHORT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The security descriptor is too short.</para>
        /// </summary>
        public const int ERROR_DS_SEC_DESC_TOO_SHORT = 8353;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_SEC_DESC_INVALID</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The security descriptor is invalid.</para>
        /// </summary>
        public const int ERROR_DS_SEC_DESC_INVALID = 8354;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_NO_DELETED_NAME</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Failed to create name for deleted object.</para>
        /// </summary>
        public const int ERROR_DS_NO_DELETED_NAME = 8355;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_SUBREF_MUST_HAVE_PARENT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The parent of a new subref must exist.</para>
        /// </summary>
        public const int ERROR_DS_SUBREF_MUST_HAVE_PARENT = 8356;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_NCNAME_MUST_BE_NC</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The object must be a naming context.</para>
        /// </summary>
        public const int ERROR_DS_NCNAME_MUST_BE_NC = 8357;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_CANT_ADD_SYSTEM_ONLY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  It is not permitted to add an attribute which is owned by the system.</para>
        /// </summary>
        public const int ERROR_DS_CANT_ADD_SYSTEM_ONLY = 8358;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_CLASS_MUST_BE_CONCRETE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The class of the object must be structural; you cannot instantiate an abstract class.</para>
        /// </summary>
        public const int ERROR_DS_CLASS_MUST_BE_CONCRETE = 8359;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_INVALID_DMD</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The schema object could not be found.</para>
        /// </summary>
        public const int ERROR_DS_INVALID_DMD = 8360;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_OBJ_GUID_EXISTS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A local object with this GUID (dead or alive) already exists.</para>
        /// </summary>
        public const int ERROR_DS_OBJ_GUID_EXISTS = 8361;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_NOT_ON_BACKLINK</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The operation cannot be performed on a back link.</para>
        /// </summary>
        public const int ERROR_DS_NOT_ON_BACKLINK = 8362;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_NO_CROSSREF_FOR_NC</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The cross reference for the specified naming context could not be found.</para>
        /// </summary>
        public const int ERROR_DS_NO_CROSSREF_FOR_NC = 8363;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_SHUTTING_DOWN</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The operation could not be performed because the directory service is shutting down.</para>
        /// </summary>
        public const int ERROR_DS_SHUTTING_DOWN = 8364;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_UNKNOWN_OPERATION</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The directory service request is invalid.</para>
        /// </summary>
        public const int ERROR_DS_UNKNOWN_OPERATION = 8365;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_INVALID_ROLE_OWNER</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The role owner attribute could not be read.</para>
        /// </summary>
        public const int ERROR_DS_INVALID_ROLE_OWNER = 8366;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_COULDNT_CONTACT_FSMO</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The requested FSMO operation failed. The current FSMO holder could not be contacted.</para>
        /// </summary>
        public const int ERROR_DS_COULDNT_CONTACT_FSMO = 8367;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_CROSS_NC_DN_RENAME</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Modification of a DN across a naming context is not permitted.</para>
        /// </summary>
        public const int ERROR_DS_CROSS_NC_DN_RENAME = 8368;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_CANT_MOD_SYSTEM_ONLY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The attribute cannot be modified because it is owned by the system.</para>
        /// </summary>
        public const int ERROR_DS_CANT_MOD_SYSTEM_ONLY = 8369;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_REPLICATOR_ONLY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Only the replicator can perform this function.</para>
        /// </summary>
        public const int ERROR_DS_REPLICATOR_ONLY = 8370;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_OBJ_CLASS_NOT_DEFINED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified class is not defined.</para>
        /// </summary>
        public const int ERROR_DS_OBJ_CLASS_NOT_DEFINED = 8371;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_OBJ_CLASS_NOT_SUBCLASS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified class is not a subclass.</para>
        /// </summary>
        public const int ERROR_DS_OBJ_CLASS_NOT_SUBCLASS = 8372;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_NAME_REFERENCE_INVALID</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The name reference is invalid.</para>
        /// </summary>
        public const int ERROR_DS_NAME_REFERENCE_INVALID = 8373;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_CROSS_REF_EXISTS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A cross reference already exists.</para>
        /// </summary>
        public const int ERROR_DS_CROSS_REF_EXISTS = 8374;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_CANT_DEL_MASTER_CROSSREF</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  It is not permitted to delete a master cross reference.</para>
        /// </summary>
        public const int ERROR_DS_CANT_DEL_MASTER_CROSSREF = 8375;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_SUBTREE_NOTIFY_NOT_NC_HEAD</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Subtree notifications are only supported on NC heads.</para>
        /// </summary>
        public const int ERROR_DS_SUBTREE_NOTIFY_NOT_NC_HEAD = 8376;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_NOTIFY_FILTER_TOO_COMPLEX</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Notification filter is too complex.</para>
        /// </summary>
        public const int ERROR_DS_NOTIFY_FILTER_TOO_COMPLEX = 8377;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_DUP_RDN</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Schema update failed: duplicate RDN.</para>
        /// </summary>
        public const int ERROR_DS_DUP_RDN = 8378;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_DUP_OID</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Schema update failed: duplicate OID.</para>
        /// </summary>
        public const int ERROR_DS_DUP_OID = 8379;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_DUP_MAPI_ID</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Schema update failed: duplicate MAPI identifier.</para>
        /// </summary>
        public const int ERROR_DS_DUP_MAPI_ID = 8380;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_DUP_SCHEMA_ID_GUID</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Schema update failed: duplicate schema-id GUID.</para>
        /// </summary>
        public const int ERROR_DS_DUP_SCHEMA_ID_GUID = 8381;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_DUP_LDAP_DISPLAY_NAME</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Schema update failed: duplicate LDAP display name.</para>
        /// </summary>
        public const int ERROR_DS_DUP_LDAP_DISPLAY_NAME = 8382;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_SEMANTIC_ATT_TEST</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Schema update failed: range-lower less than range upper.</para>
        /// </summary>
        public const int ERROR_DS_SEMANTIC_ATT_TEST = 8383;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_SYNTAX_MISMATCH</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Schema update failed: syntax mismatch.</para>
        /// </summary>
        public const int ERROR_DS_SYNTAX_MISMATCH = 8384;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_EXISTS_IN_MUST_HAVE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Schema deletion failed: attribute is used in must-contain.</para>
        /// </summary>
        public const int ERROR_DS_EXISTS_IN_MUST_HAVE = 8385;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_EXISTS_IN_MAY_HAVE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Schema deletion failed: attribute is used in may-contain.</para>
        /// </summary>
        public const int ERROR_DS_EXISTS_IN_MAY_HAVE = 8386;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_NONEXISTENT_MAY_HAVE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Schema update failed: attribute in may-contain does not exist.</para>
        /// </summary>
        public const int ERROR_DS_NONEXISTENT_MAY_HAVE = 8387;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_NONEXISTENT_MUST_HAVE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Schema update failed: attribute in must-contain does not exist.</para>
        /// </summary>
        public const int ERROR_DS_NONEXISTENT_MUST_HAVE = 8388;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_AUX_CLS_TEST_FAIL</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Schema update failed: class in aux-class list does not exist or is not an auxiliary class.</para>
        /// </summary>
        public const int ERROR_DS_AUX_CLS_TEST_FAIL = 8389;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_NONEXISTENT_POSS_SUP</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Schema update failed: class in poss-superiors does not exist.</para>
        /// </summary>
        public const int ERROR_DS_NONEXISTENT_POSS_SUP = 8390;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_SUB_CLS_TEST_FAIL</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Schema update failed: class in subclassof list does not exist or does not satisfy hierarchy rules.</para>
        /// </summary>
        public const int ERROR_DS_SUB_CLS_TEST_FAIL = 8391;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_BAD_RDN_ATT_ID_SYNTAX</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Schema update failed: Rdn-Att-Id has wrong syntax.</para>
        /// </summary>
        public const int ERROR_DS_BAD_RDN_ATT_ID_SYNTAX = 8392;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_EXISTS_IN_AUX_CLS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Schema deletion failed: class is used as auxiliary class.</para>
        /// </summary>
        public const int ERROR_DS_EXISTS_IN_AUX_CLS = 8393;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_EXISTS_IN_SUB_CLS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Schema deletion failed: class is used as sub class.</para>
        /// </summary>
        public const int ERROR_DS_EXISTS_IN_SUB_CLS = 8394;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_EXISTS_IN_POSS_SUP</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Schema deletion failed: class is used as poss superior.</para>
        /// </summary>
        public const int ERROR_DS_EXISTS_IN_POSS_SUP = 8395;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_RECALCSCHEMA_FAILED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Schema update failed in recalculating validation cache.</para>
        /// </summary>
        public const int ERROR_DS_RECALCSCHEMA_FAILED = 8396;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_TREE_DELETE_NOT_FINISHED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The tree deletion is not finished.  The request must be made again to continue deleting the tree.</para>
        /// </summary>
        public const int ERROR_DS_TREE_DELETE_NOT_FINISHED = 8397;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_CANT_DELETE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The requested delete operation could not be performed.</para>
        /// </summary>
        public const int ERROR_DS_CANT_DELETE = 8398;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_ATT_SCHEMA_REQ_ID</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Cannot read the governs class identifier for the schema record.</para>
        /// </summary>
        public const int ERROR_DS_ATT_SCHEMA_REQ_ID = 8399;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_BAD_ATT_SCHEMA_SYNTAX</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The attribute schema has bad syntax.</para>
        /// </summary>
        public const int ERROR_DS_BAD_ATT_SCHEMA_SYNTAX = 8400;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_CANT_CACHE_ATT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The attribute could not be cached.</para>
        /// </summary>
        public const int ERROR_DS_CANT_CACHE_ATT = 8401;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_CANT_CACHE_CLASS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The class could not be cached.</para>
        /// </summary>
        public const int ERROR_DS_CANT_CACHE_CLASS = 8402;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_CANT_REMOVE_ATT_CACHE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The attribute could not be removed from the cache.</para>
        /// </summary>
        public const int ERROR_DS_CANT_REMOVE_ATT_CACHE = 8403;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_CANT_REMOVE_CLASS_CACHE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The class could not be removed from the cache.</para>
        /// </summary>
        public const int ERROR_DS_CANT_REMOVE_CLASS_CACHE = 8404;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_CANT_RETRIEVE_DN</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The distinguished name attribute could not be read.</para>
        /// </summary>
        public const int ERROR_DS_CANT_RETRIEVE_DN = 8405;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_MISSING_SUPREF</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  No superior reference has been configured for the directory service. The directory service is  therefore unable to issue referrals to objects outside this forest.</para>
        /// </summary>
        public const int ERROR_DS_MISSING_SUPREF = 8406;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_CANT_RETRIEVE_INSTANCE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The instance type attribute could not be retrieved.</para>
        /// </summary>
        public const int ERROR_DS_CANT_RETRIEVE_INSTANCE = 8407;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_CODE_INCONSISTENCY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An internal error has occurred.</para>
        /// </summary>
        public const int ERROR_DS_CODE_INCONSISTENCY = 8408;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_DATABASE_ERROR</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A database error has occurred.</para>
        /// </summary>
        public const int ERROR_DS_DATABASE_ERROR = 8409;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_GOVERNSID_MISSING</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The attribute GOVERNSID is missing.</para>
        /// </summary>
        public const int ERROR_DS_GOVERNSID_MISSING = 8410;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_MISSING_EXPECTED_ATT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An expected attribute is missing.</para>
        /// </summary>
        public const int ERROR_DS_MISSING_EXPECTED_ATT = 8411;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_NCNAME_MISSING_CR_REF</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified naming context is missing a cross reference.</para>
        /// </summary>
        public const int ERROR_DS_NCNAME_MISSING_CR_REF = 8412;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_SECURITY_CHECKING_ERROR</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A security checking error has occurred.</para>
        /// </summary>
        public const int ERROR_DS_SECURITY_CHECKING_ERROR = 8413;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_SCHEMA_NOT_LOADED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The schema is not loaded.</para>
        /// </summary>
        public const int ERROR_DS_SCHEMA_NOT_LOADED = 8414;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_SCHEMA_ALLOC_FAILED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Schema allocation failed. Please check if the machine is running low on memory.</para>
        /// </summary>
        public const int ERROR_DS_SCHEMA_ALLOC_FAILED = 8415;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_ATT_SCHEMA_REQ_SYNTAX</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Failed to obtain the required syntax for the attribute schema.</para>
        /// </summary>
        public const int ERROR_DS_ATT_SCHEMA_REQ_SYNTAX = 8416;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_GCVERIFY_ERROR</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The global catalog verification failed. The global catalog is not available or does not support  the operation. Some part of the directory is currently not available.</para>
        /// </summary>
        public const int ERROR_DS_GCVERIFY_ERROR = 8417;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_DRA_SCHEMA_MISMATCH</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The replication operation failed because of a schema mismatch between the servers involved.</para>
        /// </summary>
        public const int ERROR_DS_DRA_SCHEMA_MISMATCH = 8418;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_CANT_FIND_DSA_OBJ</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The DSA object could not be found.</para>
        /// </summary>
        public const int ERROR_DS_CANT_FIND_DSA_OBJ = 8419;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_CANT_FIND_EXPECTED_NC</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The naming context could not be found.</para>
        /// </summary>
        public const int ERROR_DS_CANT_FIND_EXPECTED_NC = 8420;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_CANT_FIND_NC_IN_CACHE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The naming context could not be found in the cache.</para>
        /// </summary>
        public const int ERROR_DS_CANT_FIND_NC_IN_CACHE = 8421;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_CANT_RETRIEVE_CHILD</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The child object could not be retrieved.</para>
        /// </summary>
        public const int ERROR_DS_CANT_RETRIEVE_CHILD = 8422;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_SECURITY_ILLEGAL_MODIFY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The modification was not permitted for security reasons.</para>
        /// </summary>
        public const int ERROR_DS_SECURITY_ILLEGAL_MODIFY = 8423;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_CANT_REPLACE_HIDDEN_REC</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The operation cannot replace the hidden record.</para>
        /// </summary>
        public const int ERROR_DS_CANT_REPLACE_HIDDEN_REC = 8424;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_BAD_HIERARCHY_FILE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The hierarchy file is invalid.</para>
        /// </summary>
        public const int ERROR_DS_BAD_HIERARCHY_FILE = 8425;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_BUILD_HIERARCHY_TABLE_FAILED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The attempt to build the hierarchy table failed.</para>
        /// </summary>
        public const int ERROR_DS_BUILD_HIERARCHY_TABLE_FAILED = 8426;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_CONFIG_PARAM_MISSING</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The directory configuration parameter is missing from the registry.</para>
        /// </summary>
        public const int ERROR_DS_CONFIG_PARAM_MISSING = 8427;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_COUNTING_AB_INDICES_FAILED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The attempt to count the address book indices failed.</para>
        /// </summary>
        public const int ERROR_DS_COUNTING_AB_INDICES_FAILED = 8428;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_HIERARCHY_TABLE_MALLOC_FAILED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The allocation of the hierarchy table failed.</para>
        /// </summary>
        public const int ERROR_DS_HIERARCHY_TABLE_MALLOC_FAILED = 8429;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_INTERNAL_FAILURE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The directory service encountered an internal failure.</para>
        /// </summary>
        public const int ERROR_DS_INTERNAL_FAILURE = 8430;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_UNKNOWN_ERROR</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The directory service encountered an unknown failure.</para>
        /// </summary>
        public const int ERROR_DS_UNKNOWN_ERROR = 8431;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_ROOT_REQUIRES_CLASS_TOP</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A root object requires a class of 'top'.</para>
        /// </summary>
        public const int ERROR_DS_ROOT_REQUIRES_CLASS_TOP = 8432;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_REFUSING_FSMO_ROLES</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  This directory server is shutting down, and cannot take ownership of new floating single-master  operation roles.</para>
        /// </summary>
        public const int ERROR_DS_REFUSING_FSMO_ROLES = 8433;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_MISSING_FSMO_SETTINGS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The directory service is missing mandatory configuration information, and is unable to determine  the ownership of floating single-master operation roles.</para>
        /// </summary>
        public const int ERROR_DS_MISSING_FSMO_SETTINGS = 8434;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_UNABLE_TO_SURRENDER_ROLES</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The directory service was unable to transfer ownership of one or more floating single-master  operation roles to other servers.</para>
        /// </summary>
        public const int ERROR_DS_UNABLE_TO_SURRENDER_ROLES = 8435;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_DRA_GENERIC</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The replication operation failed.</para>
        /// </summary>
        public const int ERROR_DS_DRA_GENERIC = 8436;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_DRA_INVALID_PARAMETER</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An invalid parameter was specified for this replication operation.</para>
        /// </summary>
        public const int ERROR_DS_DRA_INVALID_PARAMETER = 8437;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_DRA_BUSY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The directory service is too busy to complete the replication operation at this time.</para>
        /// </summary>
        public const int ERROR_DS_DRA_BUSY = 8438;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_DRA_BAD_DN</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The distinguished name specified for this replication operation is invalid.</para>
        /// </summary>
        public const int ERROR_DS_DRA_BAD_DN = 8439;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_DRA_BAD_NC</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The naming context specified for this replication operation is invalid.</para>
        /// </summary>
        public const int ERROR_DS_DRA_BAD_NC = 8440;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_DRA_DN_EXISTS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The distinguished name specified for this replication operation already exists.</para>
        /// </summary>
        public const int ERROR_DS_DRA_DN_EXISTS = 8441;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_DRA_INTERNAL_ERROR</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The replication system encountered an internal error.</para>
        /// </summary>
        public const int ERROR_DS_DRA_INTERNAL_ERROR = 8442;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_DRA_INCONSISTENT_DIT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The replication operation encountered a database inconsistency.</para>
        /// </summary>
        public const int ERROR_DS_DRA_INCONSISTENT_DIT = 8443;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_DRA_CONNECTION_FAILED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The server specified for this replication operation could not be contacted.</para>
        /// </summary>
        public const int ERROR_DS_DRA_CONNECTION_FAILED = 8444;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_DRA_BAD_INSTANCE_TYPE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The replication operation encountered an object with an invalid instance type.</para>
        /// </summary>
        public const int ERROR_DS_DRA_BAD_INSTANCE_TYPE = 8445;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_DRA_OUT_OF_MEM</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The replication operation failed to allocate memory.</para>
        /// </summary>
        public const int ERROR_DS_DRA_OUT_OF_MEM = 8446;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_DRA_MAIL_PROBLEM</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The replication operation encountered an error with the mail system.</para>
        /// </summary>
        public const int ERROR_DS_DRA_MAIL_PROBLEM = 8447;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_DRA_REF_ALREADY_EXISTS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The replication reference information for the target server already exists.</para>
        /// </summary>
        public const int ERROR_DS_DRA_REF_ALREADY_EXISTS = 8448;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_DRA_REF_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The replication reference information for the target server does not exist.</para>
        /// </summary>
        public const int ERROR_DS_DRA_REF_NOT_FOUND = 8449;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_DRA_OBJ_IS_REP_SOURCE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The naming context cannot be removed because it is replicated to another server.</para>
        /// </summary>
        public const int ERROR_DS_DRA_OBJ_IS_REP_SOURCE = 8450;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_DRA_DB_ERROR</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The replication operation encountered a database error.</para>
        /// </summary>
        public const int ERROR_DS_DRA_DB_ERROR = 8451;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_DRA_NO_REPLICA</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The naming context is in the process of being removed or is not replicated from the specified  server.</para>
        /// </summary>
        public const int ERROR_DS_DRA_NO_REPLICA = 8452;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_DRA_ACCESS_DENIED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Replication access was denied.</para>
        /// </summary>
        public const int ERROR_DS_DRA_ACCESS_DENIED = 8453;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_DRA_NOT_SUPPORTED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The requested operation is not supported by this version of the directory service.</para>
        /// </summary>
        public const int ERROR_DS_DRA_NOT_SUPPORTED = 8454;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_DRA_RPC_CANCELLED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The replication remote procedure call was cancelled.</para>
        /// </summary>
        public const int ERROR_DS_DRA_RPC_CANCELLED = 8455;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_DRA_SOURCE_DISABLED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The source server is currently rejecting replication requests.</para>
        /// </summary>
        public const int ERROR_DS_DRA_SOURCE_DISABLED = 8456;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_DRA_SINK_DISABLED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The destination server is currently rejecting replication requests.</para>
        /// </summary>
        public const int ERROR_DS_DRA_SINK_DISABLED = 8457;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_DRA_NAME_COLLISION</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The replication operation failed due to a collision of object names.</para>
        /// </summary>
        public const int ERROR_DS_DRA_NAME_COLLISION = 8458;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_DRA_SOURCE_REINSTALLED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The replication source has been reinstalled.</para>
        /// </summary>
        public const int ERROR_DS_DRA_SOURCE_REINSTALLED = 8459;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_DRA_MISSING_PARENT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The replication operation failed because a required parent object is missing.</para>
        /// </summary>
        public const int ERROR_DS_DRA_MISSING_PARENT = 8460;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_DRA_PREEMPTED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The replication operation was preempted.</para>
        /// </summary>
        public const int ERROR_DS_DRA_PREEMPTED = 8461;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_DRA_ABANDON_SYNC</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The replication synchronization attempt was abandoned because of a lack of updates.</para>
        /// </summary>
        public const int ERROR_DS_DRA_ABANDON_SYNC = 8462;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_DRA_SHUTDOWN</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The replication operation was terminated because the system is shutting down.</para>
        /// </summary>
        public const int ERROR_DS_DRA_SHUTDOWN = 8463;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_DRA_INCOMPATIBLE_PARTIAL_SET</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Synchronization attempt failed because the destination DC is currently waiting to synchronize new  partial attributes from source. This condition is normal if a recent schema change modified the  partial attribute set. The destination partial attribute set is not a subset of source partial  attribute set.</para>
        /// </summary>
        public const int ERROR_DS_DRA_INCOMPATIBLE_PARTIAL_SET = 8464;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_DRA_SOURCE_IS_PARTIAL_REPLICA</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The replication synchronization attempt failed because a master replica attempted to sync from a  partial replica.</para>
        /// </summary>
        public const int ERROR_DS_DRA_SOURCE_IS_PARTIAL_REPLICA = 8465;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_DRA_EXTN_CONNECTION_FAILED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The server specified for this replication operation was contacted, but that server was unable to  contact an additional server needed to complete the operation.</para>
        /// </summary>
        public const int ERROR_DS_DRA_EXTN_CONNECTION_FAILED = 8466;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_INSTALL_SCHEMA_MISMATCH</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The version of the Active Directory schema of the source forest is not compatible with the version  of Active Directory on this computer.</para>
        /// </summary>
        public const int ERROR_DS_INSTALL_SCHEMA_MISMATCH = 8467;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_DUP_LINK_ID</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Schema update failed: An attribute with the same link identifier already exists.</para>
        /// </summary>
        public const int ERROR_DS_DUP_LINK_ID = 8468;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_NAME_ERROR_RESOLVING</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Name translation: Generic processing error.</para>
        /// </summary>
        public const int ERROR_DS_NAME_ERROR_RESOLVING = 8469;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_NAME_ERROR_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Name translation: Could not find the name or insufficient right to see name.</para>
        /// </summary>
        public const int ERROR_DS_NAME_ERROR_NOT_FOUND = 8470;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_NAME_ERROR_NOT_UNIQUE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Name translation: Input name mapped to more than one output name.</para>
        /// </summary>
        public const int ERROR_DS_NAME_ERROR_NOT_UNIQUE = 8471;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_NAME_ERROR_NO_MAPPING</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Name translation: Input name found, but not the associated output format.</para>
        /// </summary>
        public const int ERROR_DS_NAME_ERROR_NO_MAPPING = 8472;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_NAME_ERROR_DOMAIN_ONLY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Name translation: Unable to resolve completely, only the domain was found.</para>
        /// </summary>
        public const int ERROR_DS_NAME_ERROR_DOMAIN_ONLY = 8473;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_NAME_ERROR_NO_SYNTACTICAL_MAPPING</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Name translation: Unable to perform purely syntactical mapping at the client without going out to  the wire.</para>
        /// </summary>
        public const int ERROR_DS_NAME_ERROR_NO_SYNTACTICAL_MAPPING = 8474;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_CONSTRUCTED_ATT_MOD</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Modification of a constructed attribute is not allowed.</para>
        /// </summary>
        public const int ERROR_DS_CONSTRUCTED_ATT_MOD = 8475;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_WRONG_OM_OBJ_CLASS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The OM-Object-Class specified is incorrect for an attribute with the specified syntax.</para>
        /// </summary>
        public const int ERROR_DS_WRONG_OM_OBJ_CLASS = 8476;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_DRA_REPL_PENDING</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The replication request has been posted; waiting for reply.</para>
        /// </summary>
        public const int ERROR_DS_DRA_REPL_PENDING = 8477;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_DS_REQUIRED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The requested operation requires a directory service, and none was available.</para>
        /// </summary>
        public const int ERROR_DS_DS_REQUIRED = 8478;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_INVALID_LDAP_DISPLAY_NAME</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The LDAP display name of the class or attribute contains non-ASCII characters.</para>
        /// </summary>
        public const int ERROR_DS_INVALID_LDAP_DISPLAY_NAME = 8479;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_NON_BASE_SEARCH</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The requested search operation is only supported for base searches.</para>
        /// </summary>
        public const int ERROR_DS_NON_BASE_SEARCH = 8480;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_CANT_RETRIEVE_ATTS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The search failed to retrieve attributes from the database.</para>
        /// </summary>
        public const int ERROR_DS_CANT_RETRIEVE_ATTS = 8481;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_BACKLINK_WITHOUT_LINK</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The schema update operation tried to add a backward link attribute that has no corresponding  forward link.</para>
        /// </summary>
        public const int ERROR_DS_BACKLINK_WITHOUT_LINK = 8482;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_EPOCH_MISMATCH</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Source and destination of a cross-domain move do not agree on the object's epoch number.  Either  source or destination does not have the latest version of the object.</para>
        /// </summary>
        public const int ERROR_DS_EPOCH_MISMATCH = 8483;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_SRC_NAME_MISMATCH</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Source and destination of a cross-domain move do not agree on the object's current name.  Either  source or destination does not have the latest version of the object.</para>
        /// </summary>
        public const int ERROR_DS_SRC_NAME_MISMATCH = 8484;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_SRC_AND_DST_NC_IDENTICAL</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Source and destination for the cross-domain move operation are identical.  Caller should use local  move operation instead of cross-domain move operation.</para>
        /// </summary>
        public const int ERROR_DS_SRC_AND_DST_NC_IDENTICAL = 8485;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_DST_NC_MISMATCH</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Source and destination for a cross-domain move are not in agreement on the naming contexts in the  forest.  Either source or destination does not have the latest version of the Partitions container.</para>
        /// </summary>
        public const int ERROR_DS_DST_NC_MISMATCH = 8486;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_NOT_AUTHORITIVE_FOR_DST_NC</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Destination of a cross-domain move is not authoritative for the destination naming context.</para>
        /// </summary>
        public const int ERROR_DS_NOT_AUTHORITIVE_FOR_DST_NC = 8487;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_SRC_GUID_MISMATCH</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Source and destination of a cross-domain move do not agree on the identity of the source object.   Either source or destination does not have the latest version of the source object.</para>
        /// </summary>
        public const int ERROR_DS_SRC_GUID_MISMATCH = 8488;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_CANT_MOVE_DELETED_OBJECT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Object being moved across-domains is already known to be deleted by the destination server.  The  source server does not have the latest version of the source object.</para>
        /// </summary>
        public const int ERROR_DS_CANT_MOVE_DELETED_OBJECT = 8489;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_PDC_OPERATION_IN_PROGRESS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Another operation which requires exclusive access to the PDC FSMO is already in progress.</para>
        /// </summary>
        public const int ERROR_DS_PDC_OPERATION_IN_PROGRESS = 8490;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_CROSS_DOMAIN_CLEANUP_REQD</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A cross-domain move operation failed such that two versions of the moved object exist - one each  in the source and destination domains.  The destination object needs to be removed to restore the  system to a consistent state.</para>
        /// </summary>
        public const int ERROR_DS_CROSS_DOMAIN_CLEANUP_REQD = 8491;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_ILLEGAL_XDOM_MOVE_OPERATION</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  This object may not be moved across domain boundaries either because cross-domain moves for this  class are disallowed, or the object has some special characteristics, e.g.: trust account or  restricted RID, which prevent its move.</para>
        /// </summary>
        public const int ERROR_DS_ILLEGAL_XDOM_MOVE_OPERATION = 8492;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_CANT_WITH_ACCT_GROUP_MEMBERSHPS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Can't move objects with memberships across domain boundaries as once moved, this would violate the  membership conditions of the account group.  Remove the object from any account group memberships and  retry.</para>
        /// </summary>
        public const int ERROR_DS_CANT_WITH_ACCT_GROUP_MEMBERSHPS = 8493;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_NC_MUST_HAVE_NC_PARENT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A naming context head must be the immediate child of another naming context head, not of an  interior node.</para>
        /// </summary>
        public const int ERROR_DS_NC_MUST_HAVE_NC_PARENT = 8494;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_CR_IMPOSSIBLE_TO_VALIDATE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The directory cannot validate the proposed naming context name because it does not hold a replica  of the naming context above the proposed naming context.  Please ensure that the domain naming master  role is held by a server that is configured as a global catalog server, and that the server is up to  date with its replication partners. (Applies only to Windows 2000 Domain Naming masters)</para>
        /// </summary>
        public const int ERROR_DS_CR_IMPOSSIBLE_TO_VALIDATE = 8495;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_DST_DOMAIN_NOT_NATIVE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Destination domain must be in native mode.</para>
        /// </summary>
        public const int ERROR_DS_DST_DOMAIN_NOT_NATIVE = 8496;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_MISSING_INFRASTRUCTURE_CONTAINER</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The operation can not be performed because the server does not have an infrastructure container in  the domain of interest.</para>
        /// </summary>
        public const int ERROR_DS_MISSING_INFRASTRUCTURE_CONTAINER = 8497;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_CANT_MOVE_ACCOUNT_GROUP</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Cross-domain move of non-empty account groups is not allowed.</para>
        /// </summary>
        public const int ERROR_DS_CANT_MOVE_ACCOUNT_GROUP = 8498;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_CANT_MOVE_RESOURCE_GROUP</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Cross-domain move of non-empty resource groups is not allowed.</para>
        /// </summary>
        public const int ERROR_DS_CANT_MOVE_RESOURCE_GROUP = 8499;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_INVALID_SEARCH_FLAG</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The search flags for the attribute are invalid. The ANR bit is valid only on attributes of Unicode  or Teletex strings.</para>
        /// </summary>
        public const int ERROR_DS_INVALID_SEARCH_FLAG = 8500;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_NO_TREE_DELETE_ABOVE_NC</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Tree deletions starting at an object which has an NC head as a descendant are not allowed.</para>
        /// </summary>
        public const int ERROR_DS_NO_TREE_DELETE_ABOVE_NC = 8501;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_COULDNT_LOCK_TREE_FOR_DELETE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The directory service failed to lock a tree in preparation for a tree deletion because the tree  was in use.</para>
        /// </summary>
        public const int ERROR_DS_COULDNT_LOCK_TREE_FOR_DELETE = 8502;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_COULDNT_IDENTIFY_OBJECTS_FOR_TREE_DELETE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The directory service failed to identify the list of objects to delete while attempting a tree  deletion.</para>
        /// </summary>
        public const int ERROR_DS_COULDNT_IDENTIFY_OBJECTS_FOR_TREE_DELETE = 8503;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_SAM_INIT_FAILURE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Security Accounts Manager initialization failed because of the following error: %1.</para>
        /// <para>//  Error Status: 0x%2. Click OK to shut down the system and reboot into Directory Services Restore  Mode. Check the event log for detailed information.</para>
        /// </summary>
        public const int ERROR_DS_SAM_INIT_FAILURE = 8504;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_SENSITIVE_GROUP_VIOLATION</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Only an administrator can modify the membership list of an administrative group.</para>
        /// </summary>
        public const int ERROR_DS_SENSITIVE_GROUP_VIOLATION = 8505;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_CANT_MOD_PRIMARYGROUPID</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Cannot change the primary group ID of a domain controller account.</para>
        /// </summary>
        public const int ERROR_DS_CANT_MOD_PRIMARYGROUPID = 8506;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_ILLEGAL_BASE_SCHEMA_MOD</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An attempt is made to modify the base schema.</para>
        /// </summary>
        public const int ERROR_DS_ILLEGAL_BASE_SCHEMA_MOD = 8507;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_NONSAFE_SCHEMA_CHANGE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Adding a new mandatory attribute to an existing class, deleting a mandatory attribute from an  existing class, or adding an optional attribute to the special class Top that is not a backlink  attribute (directly or through inheritance, for example, by adding or deleting an auxiliary class) is  not allowed.</para>
        /// </summary>
        public const int ERROR_DS_NONSAFE_SCHEMA_CHANGE = 8508;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_SCHEMA_UPDATE_DISALLOWED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Schema update is not allowed on this DC because the DC is not the schema FSMO Role Owner.</para>
        /// </summary>
        public const int ERROR_DS_SCHEMA_UPDATE_DISALLOWED = 8509;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_CANT_CREATE_UNDER_SCHEMA</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An object of this class cannot be created under the schema container. You can only create  attribute-schema and class-schema objects under the schema container.</para>
        /// </summary>
        public const int ERROR_DS_CANT_CREATE_UNDER_SCHEMA = 8510;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_INSTALL_NO_SRC_SCH_VERSION</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The replica/child install failed to get the objectVersion attribute on the schema container on the  source DC. Either the attribute is missing on the schema container or the credentials supplied do not  have permission to read it.</para>
        /// </summary>
        public const int ERROR_DS_INSTALL_NO_SRC_SCH_VERSION = 8511;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_INSTALL_NO_SCH_VERSION_IN_INIFILE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The replica/child install failed to read the objectVersion attribute in the SCHEMA section of the  file schema.ini in the system32 directory.</para>
        /// </summary>
        public const int ERROR_DS_INSTALL_NO_SCH_VERSION_IN_INIFILE = 8512;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_INVALID_GROUP_TYPE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified group type is invalid.</para>
        /// </summary>
        public const int ERROR_DS_INVALID_GROUP_TYPE = 8513;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_NO_NEST_GLOBALGROUP_IN_MIXEDDOMAIN</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  You cannot nest global groups in a mixed domain if the group is security-enabled.</para>
        /// </summary>
        public const int ERROR_DS_NO_NEST_GLOBALGROUP_IN_MIXEDDOMAIN = 8514;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_NO_NEST_LOCALGROUP_IN_MIXEDDOMAIN</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  You cannot nest local groups in a mixed domain if the group is security-enabled.</para>
        /// </summary>
        public const int ERROR_DS_NO_NEST_LOCALGROUP_IN_MIXEDDOMAIN = 8515;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_GLOBAL_CANT_HAVE_LOCAL_MEMBER</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A global group cannot have a local group as a member.</para>
        /// </summary>
        public const int ERROR_DS_GLOBAL_CANT_HAVE_LOCAL_MEMBER = 8516;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_GLOBAL_CANT_HAVE_UNIVERSAL_MEMBER</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A global group cannot have a universal group as a member.</para>
        /// </summary>
        public const int ERROR_DS_GLOBAL_CANT_HAVE_UNIVERSAL_MEMBER = 8517;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_UNIVERSAL_CANT_HAVE_LOCAL_MEMBER</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A universal group cannot have a local group as a member.</para>
        /// </summary>
        public const int ERROR_DS_UNIVERSAL_CANT_HAVE_LOCAL_MEMBER = 8518;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_GLOBAL_CANT_HAVE_CROSSDOMAIN_MEMBER</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A global group cannot have a cross-domain member.</para>
        /// </summary>
        public const int ERROR_DS_GLOBAL_CANT_HAVE_CROSSDOMAIN_MEMBER = 8519;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_LOCAL_CANT_HAVE_CROSSDOMAIN_LOCAL_MEMBER</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A local group cannot have another cross domain local group as a member.</para>
        /// </summary>
        public const int ERROR_DS_LOCAL_CANT_HAVE_CROSSDOMAIN_LOCAL_MEMBER = 8520;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_HAVE_PRIMARY_MEMBERS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A group with primary members cannot change to a security-disabled group.</para>
        /// </summary>
        public const int ERROR_DS_HAVE_PRIMARY_MEMBERS = 8521;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_STRING_SD_CONVERSION_FAILED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The schema cache load failed to convert the string default SD on a class-schema object.</para>
        /// </summary>
        public const int ERROR_DS_STRING_SD_CONVERSION_FAILED = 8522;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_NAMING_MASTER_GC</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Only DSAs configured to be Global Catalog servers should be allowed to hold the Domain Naming  Master FSMO role. (Applies only to Windows 2000 servers)</para>
        /// </summary>
        public const int ERROR_DS_NAMING_MASTER_GC = 8523;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_DNS_LOOKUP_FAILURE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The DSA operation is unable to proceed because of a DNS lookup failure.</para>
        /// </summary>
        public const int ERROR_DS_DNS_LOOKUP_FAILURE = 8524;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_COULDNT_UPDATE_SPNS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  While processing a change to the DNS Host Name for an object, the Service Principal Name values  could not be kept in sync.</para>
        /// </summary>
        public const int ERROR_DS_COULDNT_UPDATE_SPNS = 8525;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_CANT_RETRIEVE_SD</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The Security Descriptor attribute could not be read.</para>
        /// </summary>
        public const int ERROR_DS_CANT_RETRIEVE_SD = 8526;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_KEY_NOT_UNIQUE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The object requested was not found, but an object with that key was found.</para>
        /// </summary>
        public const int ERROR_DS_KEY_NOT_UNIQUE = 8527;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_WRONG_LINKED_ATT_SYNTAX</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The syntax of the linked attribute being added is incorrect. Forward links can only have syntax  2.5.5.1, 2.5.5.7, and 2.5.5.14, and backlinks can only have syntax 2.5.5.1</para>
        /// </summary>
        public const int ERROR_DS_WRONG_LINKED_ATT_SYNTAX = 8528;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_SAM_NEED_BOOTKEY_PASSWORD</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Security Account Manager needs to get the boot password.</para>
        /// </summary>
        public const int ERROR_DS_SAM_NEED_BOOTKEY_PASSWORD = 8529;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_SAM_NEED_BOOTKEY_FLOPPY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Security Account Manager needs to get the boot key from floppy disk.</para>
        /// </summary>
        public const int ERROR_DS_SAM_NEED_BOOTKEY_FLOPPY = 8530;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_CANT_START</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Directory Service cannot start.</para>
        /// </summary>
        public const int ERROR_DS_CANT_START = 8531;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_INIT_FAILURE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Directory Services could not start.</para>
        /// </summary>
        public const int ERROR_DS_INIT_FAILURE = 8532;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_NO_PKT_PRIVACY_ON_CONNECTION</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The connection between client and server requires packet privacy or better.</para>
        /// </summary>
        public const int ERROR_DS_NO_PKT_PRIVACY_ON_CONNECTION = 8533;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_SOURCE_DOMAIN_IN_FOREST</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The source domain may not be in the same forest as destination.</para>
        /// </summary>
        public const int ERROR_DS_SOURCE_DOMAIN_IN_FOREST = 8534;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_DESTINATION_DOMAIN_NOT_IN_FOREST</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The destination domain must be in the forest.</para>
        /// </summary>
        public const int ERROR_DS_DESTINATION_DOMAIN_NOT_IN_FOREST = 8535;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_DESTINATION_AUDITING_NOT_ENABLED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The operation requires that destination domain auditing be enabled.</para>
        /// </summary>
        public const int ERROR_DS_DESTINATION_AUDITING_NOT_ENABLED = 8536;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_CANT_FIND_DC_FOR_SRC_DOMAIN</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The operation couldn't locate a DC for the source domain.</para>
        /// </summary>
        public const int ERROR_DS_CANT_FIND_DC_FOR_SRC_DOMAIN = 8537;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_SRC_OBJ_NOT_GROUP_OR_USER</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The source object must be a group or user.</para>
        /// </summary>
        public const int ERROR_DS_SRC_OBJ_NOT_GROUP_OR_USER = 8538;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_SRC_SID_EXISTS_IN_FOREST</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The source object's SID already exists in destination forest.</para>
        /// </summary>
        public const int ERROR_DS_SRC_SID_EXISTS_IN_FOREST = 8539;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_SRC_AND_DST_OBJECT_CLASS_MISMATCH</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The source and destination object must be of the same type.</para>
        /// </summary>
        public const int ERROR_DS_SRC_AND_DST_OBJECT_CLASS_MISMATCH = 8540;

        /// <summary>
        /// <para>// MessageId: ERROR_SAM_INIT_FAILURE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Security Accounts Manager initialization failed because of the following error: %1.</para>
        /// <para>//  Error Status: 0x%2. Click OK to shut down the system and reboot into Safe Mode. Check the event  log for detailed information.</para>
        /// </summary>
        public const int ERROR_SAM_INIT_FAILURE = 8541;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_DRA_SCHEMA_INFO_SHIP</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Schema information could not be included in the replication request.</para>
        /// </summary>
        public const int ERROR_DS_DRA_SCHEMA_INFO_SHIP = 8542;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_DRA_SCHEMA_CONFLICT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The replication operation could not be completed due to a schema incompatibility.</para>
        /// </summary>
        public const int ERROR_DS_DRA_SCHEMA_CONFLICT = 8543;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_DRA_EARLIER_SCHEMA_CONFLICT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The replication operation could not be completed due to a previous schema incompatibility.</para>
        /// </summary>
        public const int ERROR_DS_DRA_EARLIER_SCHEMA_CONFLICT = 8544;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_DRA_OBJ_NC_MISMATCH</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The replication update could not be applied because either the source or the destination has not  yet received information regarding a recent cross-domain move operation.</para>
        /// </summary>
        public const int ERROR_DS_DRA_OBJ_NC_MISMATCH = 8545;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_NC_STILL_HAS_DSAS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The requested domain could not be deleted because there exist domain controllers that still host  this domain.</para>
        /// </summary>
        public const int ERROR_DS_NC_STILL_HAS_DSAS = 8546;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_GC_REQUIRED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The requested operation can be performed only on a global catalog server.</para>
        /// </summary>
        public const int ERROR_DS_GC_REQUIRED = 8547;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_LOCAL_MEMBER_OF_LOCAL_ONLY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A local group can only be a member of other local groups in the same domain.</para>
        /// </summary>
        public const int ERROR_DS_LOCAL_MEMBER_OF_LOCAL_ONLY = 8548;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_NO_FPO_IN_UNIVERSAL_GROUPS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Foreign security principals cannot be members of universal groups.</para>
        /// </summary>
        public const int ERROR_DS_NO_FPO_IN_UNIVERSAL_GROUPS = 8549;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_CANT_ADD_TO_GC</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The attribute is not allowed to be replicated to the GC because of security reasons.</para>
        /// </summary>
        public const int ERROR_DS_CANT_ADD_TO_GC = 8550;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_NO_CHECKPOINT_WITH_PDC</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The checkpoint with the PDC could not be taken because there too many modifications being  processed currently.</para>
        /// </summary>
        public const int ERROR_DS_NO_CHECKPOINT_WITH_PDC = 8551;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_SOURCE_AUDITING_NOT_ENABLED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The operation requires that source domain auditing be enabled.</para>
        /// </summary>
        public const int ERROR_DS_SOURCE_AUDITING_NOT_ENABLED = 8552;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_CANT_CREATE_IN_NONDOMAIN_NC</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Security principal objects can only be created inside domain naming contexts.</para>
        /// </summary>
        public const int ERROR_DS_CANT_CREATE_IN_NONDOMAIN_NC = 8553;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_INVALID_NAME_FOR_SPN</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A Service Principal Name (SPN) could not be constructed because the provided hostname is not in  the necessary format.</para>
        /// </summary>
        public const int ERROR_DS_INVALID_NAME_FOR_SPN = 8554;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_FILTER_USES_CONTRUCTED_ATTRS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A Filter was passed that uses constructed attributes.</para>
        /// </summary>
        public const int ERROR_DS_FILTER_USES_CONTRUCTED_ATTRS = 8555;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_UNICODEPWD_NOT_IN_QUOTES</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The unicodePwd attribute value must be enclosed in double quotes.</para>
        /// </summary>
        public const int ERROR_DS_UNICODEPWD_NOT_IN_QUOTES = 8556;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_MACHINE_ACCOUNT_QUOTA_EXCEEDED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Your computer could not be joined to the domain. You have exceeded the maximum number of computer  accounts you are allowed to create in this domain. Contact your system administrator to have this  limit reset or increased.</para>
        /// </summary>
        public const int ERROR_DS_MACHINE_ACCOUNT_QUOTA_EXCEEDED = 8557;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_MUST_BE_RUN_ON_DST_DC</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  For security reasons, the operation must be run on the destination DC.</para>
        /// </summary>
        public const int ERROR_DS_MUST_BE_RUN_ON_DST_DC = 8558;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_SRC_DC_MUST_BE_SP4_OR_GREATER</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  For security reasons, the source DC must be NT4SP4 or greater.</para>
        /// </summary>
        public const int ERROR_DS_SRC_DC_MUST_BE_SP4_OR_GREATER = 8559;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_CANT_TREE_DELETE_CRITICAL_OBJ</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Critical Directory Service System objects cannot be deleted during tree delete operations.  The  tree delete may have been partially performed.</para>
        /// </summary>
        public const int ERROR_DS_CANT_TREE_DELETE_CRITICAL_OBJ = 8560;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_INIT_FAILURE_CONSOLE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Directory Services could not start because of the following error: %1.</para>
        /// <para>//  Error Status: 0x%2. Please click OK to shutdown the system. You can use the recovery console to  diagnose the system further.</para>
        /// </summary>
        public const int ERROR_DS_INIT_FAILURE_CONSOLE = 8561;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_SAM_INIT_FAILURE_CONSOLE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Security Accounts Manager initialization failed because of the following error: %1.</para>
        /// <para>//  Error Status: 0x%2. Please click OK to shutdown the system. You can use the recovery console to  diagnose the system further.</para>
        /// </summary>
        public const int ERROR_DS_SAM_INIT_FAILURE_CONSOLE = 8562;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_FOREST_VERSION_TOO_HIGH</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The version of the operating system installed is incompatible with the current forest functional  level. You must upgrade to a new version of the operating system before this server can become a  domain controller in this forest.</para>
        /// </summary>
        public const int ERROR_DS_FOREST_VERSION_TOO_HIGH = 8563;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_DOMAIN_VERSION_TOO_HIGH</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The version of the operating system installed is incompatible with the current domain functional  level. You must upgrade to a new version of the operating system before this server can become a  domain controller in this domain.</para>
        /// </summary>
        public const int ERROR_DS_DOMAIN_VERSION_TOO_HIGH = 8564;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_FOREST_VERSION_TOO_LOW</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The version of the operating system installed on this server no longer supports the current forest  functional level. You must raise the forest functional level before this server can become a domain  controller in this forest.</para>
        /// </summary>
        public const int ERROR_DS_FOREST_VERSION_TOO_LOW = 8565;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_DOMAIN_VERSION_TOO_LOW</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The version of the operating system installed on this server no longer supports the current domain  functional level. You must raise the domain functional level before this server can become a domain  controller in this domain.</para>
        /// </summary>
        public const int ERROR_DS_DOMAIN_VERSION_TOO_LOW = 8566;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_INCOMPATIBLE_VERSION</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The version of the operating system installed on this server is incompatible with the functional  level of the domain or forest.</para>
        /// </summary>
        public const int ERROR_DS_INCOMPATIBLE_VERSION = 8567;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_LOW_DSA_VERSION</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The functional level of the domain (or forest) cannot be raised to the requested value, because  there exist one or more domain controllers in the domain (or forest) that are at a lower incompatible  functional level.</para>
        /// </summary>
        public const int ERROR_DS_LOW_DSA_VERSION = 8568;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_NO_BEHAVIOR_VERSION_IN_MIXEDDOMAIN</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The forest functional level cannot be raised to the requested value since one or more domains are  still in mixed domain mode. All domains in the forest must be in native mode, for you to raise the  forest functional level.</para>
        /// </summary>
        public const int ERROR_DS_NO_BEHAVIOR_VERSION_IN_MIXEDDOMAIN = 8569;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_NOT_SUPPORTED_SORT_ORDER</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The sort order requested is not supported.</para>
        /// </summary>
        public const int ERROR_DS_NOT_SUPPORTED_SORT_ORDER = 8570;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_NAME_NOT_UNIQUE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The requested name already exists as a unique identifier.</para>
        /// </summary>
        public const int ERROR_DS_NAME_NOT_UNIQUE = 8571;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_MACHINE_ACCOUNT_CREATED_PRENT4</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The machine account was created pre-NT4.  The account needs to be recreated.</para>
        /// </summary>
        public const int ERROR_DS_MACHINE_ACCOUNT_CREATED_PRENT4 = 8572;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_OUT_OF_VERSION_STORE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The database is out of version store.</para>
        /// </summary>
        public const int ERROR_DS_OUT_OF_VERSION_STORE = 8573;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_INCOMPATIBLE_CONTROLS_USED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Unable to continue operation because multiple conflicting controls were used.</para>
        /// </summary>
        public const int ERROR_DS_INCOMPATIBLE_CONTROLS_USED = 8574;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_NO_REF_DOMAIN</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Unable to find a valid security descriptor reference domain for this partition.</para>
        /// </summary>
        public const int ERROR_DS_NO_REF_DOMAIN = 8575;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_RESERVED_LINK_ID</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Schema update failed: The link identifier is reserved.</para>
        /// </summary>
        public const int ERROR_DS_RESERVED_LINK_ID = 8576;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_LINK_ID_NOT_AVAILABLE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Schema update failed: There are no link identifiers available.</para>
        /// </summary>
        public const int ERROR_DS_LINK_ID_NOT_AVAILABLE = 8577;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_AG_CANT_HAVE_UNIVERSAL_MEMBER</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An account group can not have a universal group as a member.</para>
        /// </summary>
        public const int ERROR_DS_AG_CANT_HAVE_UNIVERSAL_MEMBER = 8578;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_MODIFYDN_DISALLOWED_BY_INSTANCE_TYPE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Rename or move operations on naming context heads or read-only objects are not allowed.</para>
        /// </summary>
        public const int ERROR_DS_MODIFYDN_DISALLOWED_BY_INSTANCE_TYPE = 8579;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_NO_OBJECT_MOVE_IN_SCHEMA_NC</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Move operations on objects in the schema naming context are not allowed.</para>
        /// </summary>
        public const int ERROR_DS_NO_OBJECT_MOVE_IN_SCHEMA_NC = 8580;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_MODIFYDN_DISALLOWED_BY_FLAG</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A system flag has been set on the object and does not allow the object to be moved or renamed.</para>
        /// </summary>
        public const int ERROR_DS_MODIFYDN_DISALLOWED_BY_FLAG = 8581;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_MODIFYDN_WRONG_GRANDPARENT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  This object is not allowed to change its grandparent container. Moves are not forbidden on this  object, but are restricted to sibling containers.</para>
        /// </summary>
        public const int ERROR_DS_MODIFYDN_WRONG_GRANDPARENT = 8582;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_NAME_ERROR_TRUST_REFERRAL</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Unable to resolve completely, a referral to another forest is generated.</para>
        /// </summary>
        public const int ERROR_DS_NAME_ERROR_TRUST_REFERRAL = 8583;

        /// <summary>
        /// <para>// MessageId: ERROR_NOT_SUPPORTED_ON_STANDARD_SERVER</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The requested action is not supported on standard server.</para>
        /// </summary>
        public const int ERROR_NOT_SUPPORTED_ON_STANDARD_SERVER = 8584;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_CANT_ACCESS_REMOTE_PART_OF_AD</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Could not access a partition of the Active Directory located on a remote server.  Make sure at  least one server is running for the partition in question.</para>
        /// </summary>
        public const int ERROR_DS_CANT_ACCESS_REMOTE_PART_OF_AD = 8585;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_CR_IMPOSSIBLE_TO_VALIDATE_V2</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The directory cannot validate the proposed naming context (or partition) name because it does not  hold a replica nor can it contact a replica of the naming context above the proposed naming context.   Please ensure that the parent naming context is properly registered in DNS, and at least one replica  of this naming context is reachable by the Domain Naming master.</para>
        /// </summary>
        public const int ERROR_DS_CR_IMPOSSIBLE_TO_VALIDATE_V2 = 8586;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_THREAD_LIMIT_EXCEEDED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The thread limit for this request was exceeded.</para>
        /// </summary>
        public const int ERROR_DS_THREAD_LIMIT_EXCEEDED = 8587;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_NOT_CLOSEST</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The Global catalog server is not in the closest site.</para>
        /// </summary>
        public const int ERROR_DS_NOT_CLOSEST = 8588;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_CANT_DERIVE_SPN_WITHOUT_SERVER_REF</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The DS cannot derive a service principal name (SPN) with which to mutually authenticate the target  server because the corresponding server object in the local DS database has no serverReference  attribute.</para>
        /// </summary>
        public const int ERROR_DS_CANT_DERIVE_SPN_WITHOUT_SERVER_REF = 8589;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_SINGLE_USER_MODE_FAILED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The Directory Service failed to enter single user mode.</para>
        /// </summary>
        public const int ERROR_DS_SINGLE_USER_MODE_FAILED = 8590;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_NTDSCRIPT_SYNTAX_ERROR</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The Directory Service cannot parse the script because of a syntax error.</para>
        /// </summary>
        public const int ERROR_DS_NTDSCRIPT_SYNTAX_ERROR = 8591;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_NTDSCRIPT_PROCESS_ERROR</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The Directory Service cannot process the script because of an error.</para>
        /// </summary>
        public const int ERROR_DS_NTDSCRIPT_PROCESS_ERROR = 8592;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_DIFFERENT_REPL_EPOCHS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The directory service cannot perform the requested operation because the servers</para>
        /// <para>//  involved are of different replication epochs (which is usually related to a</para>
        /// <para>//  domain rename that is in progress).</para>
        /// </summary>
        public const int ERROR_DS_DIFFERENT_REPL_EPOCHS = 8593;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_DRS_EXTENSIONS_CHANGED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The directory service binding must be renegotiated due to a change in the server</para>
        /// <para>//  extensions information.</para>
        /// </summary>
        public const int ERROR_DS_DRS_EXTENSIONS_CHANGED = 8594;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_REPLICA_SET_CHANGE_NOT_ALLOWED_ON_DISABLED_CR</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Operation not allowed on a disabled cross ref.</para>
        /// </summary>
        public const int ERROR_DS_REPLICA_SET_CHANGE_NOT_ALLOWED_ON_DISABLED_CR = 8595;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_NO_MSDS_INTID</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Schema update failed: No values for msDS-IntId are available.</para>
        /// </summary>
        public const int ERROR_DS_NO_MSDS_INTID = 8596;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_DUP_MSDS_INTID</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Schema update failed: Duplicate msDS-INtId. Retry the operation.</para>
        /// </summary>
        public const int ERROR_DS_DUP_MSDS_INTID = 8597;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_EXISTS_IN_RDNATTID</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Schema deletion failed: attribute is used in rDNAttID.</para>
        /// </summary>
        public const int ERROR_DS_EXISTS_IN_RDNATTID = 8598;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_AUTHORIZATION_FAILED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The directory service failed to authorize the request.</para>
        /// </summary>
        public const int ERROR_DS_AUTHORIZATION_FAILED = 8599;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_INVALID_SCRIPT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The Directory Service cannot process the script because it is invalid.</para>
        /// </summary>
        public const int ERROR_DS_INVALID_SCRIPT = 8600;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_REMOTE_CROSSREF_OP_FAILED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The remote create cross reference operation failed on the Domain Naming Master FSMO.  The  operation's error is in the extended data.</para>
        /// </summary>
        public const int ERROR_DS_REMOTE_CROSSREF_OP_FAILED = 8601;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_CROSS_REF_BUSY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A cross reference is in use locally with the same name.</para>
        /// </summary>
        public const int ERROR_DS_CROSS_REF_BUSY = 8602;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_CANT_DERIVE_SPN_FOR_DELETED_DOMAIN</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The DS cannot derive a service principal name (SPN) with which to mutually authenticate the target  server because the server's domain has been deleted from the forest.</para>
        /// </summary>
        public const int ERROR_DS_CANT_DERIVE_SPN_FOR_DELETED_DOMAIN = 8603;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_CANT_DEMOTE_WITH_WRITEABLE_NC</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Writeable NCs prevent this DC from demoting.</para>
        /// </summary>
        public const int ERROR_DS_CANT_DEMOTE_WITH_WRITEABLE_NC = 8604;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_DUPLICATE_ID_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The requested object has a non-unique identifier and cannot be retrieved.</para>
        /// </summary>
        public const int ERROR_DS_DUPLICATE_ID_FOUND = 8605;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_INSUFFICIENT_ATTR_TO_CREATE_OBJECT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Insufficient attributes were given to create an object.  This object may not exist because it may  have been deleted and already garbage collected.</para>
        /// </summary>
        public const int ERROR_DS_INSUFFICIENT_ATTR_TO_CREATE_OBJECT = 8606;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_GROUP_CONVERSION_ERROR</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The group cannot be converted due to attribute restrictions on the requested group type.</para>
        /// </summary>
        public const int ERROR_DS_GROUP_CONVERSION_ERROR = 8607;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_CANT_MOVE_APP_BASIC_GROUP</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Cross-domain move of non-empty basic application groups is not allowed.</para>
        /// </summary>
        public const int ERROR_DS_CANT_MOVE_APP_BASIC_GROUP = 8608;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_CANT_MOVE_APP_QUERY_GROUP</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Cross-domain move of non-empty query based application groups is not allowed.</para>
        /// </summary>
        public const int ERROR_DS_CANT_MOVE_APP_QUERY_GROUP = 8609;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_ROLE_NOT_VERIFIED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The FSMO role ownership could not be verified because its directory partition has not replicated  successfully with atleast one replication partner.</para>
        /// </summary>
        public const int ERROR_DS_ROLE_NOT_VERIFIED = 8610;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_WKO_CONTAINER_CANNOT_BE_SPECIAL</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The target container for a redirection of a well known object container cannot already be a  special container.</para>
        /// </summary>
        public const int ERROR_DS_WKO_CONTAINER_CANNOT_BE_SPECIAL = 8611;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_DOMAIN_RENAME_IN_PROGRESS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The Directory Service cannot perform the requested operation because a domain rename operation is  in progress.</para>
        /// </summary>
        public const int ERROR_DS_DOMAIN_RENAME_IN_PROGRESS = 8612;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_EXISTING_AD_CHILD_NC</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The Active Directory detected an Active Directory child partition below the</para>
        /// <para>//  requested new partition name.  The Active Directory's partition heiarchy must</para>
        /// <para>//  be created in a top down method.</para>
        /// </summary>
        public const int ERROR_DS_EXISTING_AD_CHILD_NC = 8613;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_REPL_LIFETIME_EXCEEDED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The Active Directory cannot replicate with this server because the time since the last replication  with this server has exceeded the tombstone lifetime.</para>
        /// </summary>
        public const int ERROR_DS_REPL_LIFETIME_EXCEEDED = 8614;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_DISALLOWED_IN_SYSTEM_CONTAINER</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The requested operation is not allowed on an object under the system container.</para>
        /// </summary>
        public const int ERROR_DS_DISALLOWED_IN_SYSTEM_CONTAINER = 8615;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_LDAP_SEND_QUEUE_FULL</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The LDAP servers network send queue has filled up because the client is not</para>
        /// <para>//  processing the results of it's requests fast enough.  No more requests will</para>
        /// <para>//  be processed until the client catches up.  If the client does not catch up</para>
        /// <para>//  then it will be disconnected.</para>
        /// </summary>
        public const int ERROR_DS_LDAP_SEND_QUEUE_FULL = 8616;

        /// <summary>
        /// <para>// MessageId: ERROR_DS_DRA_OUT_SCHEDULE_WINDOW</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The scheduled replication did not take place because the system was too busy to execute the  request within the schedule window.  The replication queue is overloaded. Consider reducing the number  of partners or decreasing the scheduled replication frequency.</para>
        /// </summary>
        public const int ERROR_DS_DRA_OUT_SCHEDULE_WINDOW = 8617;

        ///////////////////////////////////////////////////
        //                                                /
        //     End of Active Directory Error Codes        /
        //                                                /
        //                  8000 to  8999                 /
        ///////////////////////////////////////////////////


        ///////////////////////////////////////////////////
        //                                               //
        //                  DNS Error Codes              //
        //                                               //
        //                   9000 to 9999                //
        ///////////////////////////////////////////////////

        // =============================
        // Facility DNS Error Messages
        // =============================

        //  DNS response codes.

        /// <summary>
        /// 
        /// </summary>
        public const int DNS_ERROR_RESPONSE_CODES_BASE = 9000;

        /// <summary>
        /// 
        /// </summary>
        public const int DNS_ERROR_RCODE_NO_ERROR = NO_ERROR;

        /// <summary>
        /// 
        /// </summary>
        public const int DNS_ERROR_MASK = 0x00002328; // 9000 or DNS_ERROR_RESPONSE_CODES_BASE

        /// <summary>
        /// <para>// DNS_ERROR_RCODE_FORMAT_ERROR          0x00002329</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_RCODE_FORMAT_ERROR</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  DNS server unable to interpret format.</para>
        /// </summary>
        public const int DNS_ERROR_RCODE_FORMAT_ERROR = 9001;

        /// <summary>
        /// <para>// DNS_ERROR_RCODE_SERVER_FAILURE        0x0000232a</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_RCODE_SERVER_FAILURE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  DNS server failure.</para>
        /// </summary>
        public const int DNS_ERROR_RCODE_SERVER_FAILURE = 9002;

        /// <summary>
        /// <para>// DNS_ERROR_RCODE_NAME_ERROR            0x0000232b</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_RCODE_NAME_ERROR</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  DNS name does not exist.</para>
        /// </summary>
        public const int DNS_ERROR_RCODE_NAME_ERROR = 9003;

        /// <summary>
        /// <para>// DNS_ERROR_RCODE_NOT_IMPLEMENTED       0x0000232c</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_RCODE_NOT_IMPLEMENTED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  DNS request not supported by name server.</para>
        /// </summary>
        public const int DNS_ERROR_RCODE_NOT_IMPLEMENTED = 9004;

        /// <summary>
        /// <para>// DNS_ERROR_RCODE_REFUSED               0x0000232d</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_RCODE_REFUSED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  DNS operation refused.</para>
        /// </summary>
        public const int DNS_ERROR_RCODE_REFUSED = 9005;

        /// <summary>
        /// <para>// DNS_ERROR_RCODE_YXDOMAIN              0x0000232e</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_RCODE_YXDOMAIN</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  DNS name that ought not exist, does exist.</para>
        /// </summary>
        public const int DNS_ERROR_RCODE_YXDOMAIN = 9006;

        /// <summary>
        /// <para>// DNS_ERROR_RCODE_YXRRSET               0x0000232f</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_RCODE_YXRRSET</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  DNS RR set that ought not exist, does exist.</para>
        /// </summary>
        public const int DNS_ERROR_RCODE_YXRRSET = 9007;

        /// <summary>
        /// <para>// DNS_ERROR_RCODE_NXRRSET               0x00002330</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_RCODE_NXRRSET</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  DNS RR set that ought to exist, does not exist.</para>
        /// </summary>
        public const int DNS_ERROR_RCODE_NXRRSET = 9008;

        /// <summary>
        /// <para>// DNS_ERROR_RCODE_NOTAUTH               0x00002331</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_RCODE_NOTAUTH</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  DNS server not authoritative for zone.</para>
        /// </summary>
        public const int DNS_ERROR_RCODE_NOTAUTH = 9009;

        /// <summary>
        /// <para>// DNS_ERROR_RCODE_NOTZONE               0x00002332</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_RCODE_NOTZONE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  DNS name in update or prereq is not in zone.</para>
        /// </summary>
        public const int DNS_ERROR_RCODE_NOTZONE = 9010;

        /// <summary>
        /// <para>// DNS_ERROR_RCODE_BADSIG                0x00002338</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_RCODE_BADSIG</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  DNS signature failed to verify.</para>
        /// </summary>
        public const int DNS_ERROR_RCODE_BADSIG = 9016;

        /// <summary>
        /// <para>// DNS_ERROR_RCODE_BADKEY                0x00002339</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_RCODE_BADKEY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  DNS bad key.</para>
        /// </summary>
        public const int DNS_ERROR_RCODE_BADKEY = 9017;

        /// <summary>
        /// <para>// DNS_ERROR_RCODE_BADTIME               0x0000233a</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_RCODE_BADTIME</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  DNS signature validity expired.</para>
        /// </summary>
        public const int DNS_ERROR_RCODE_BADTIME = 9018;

        /// <summary>
        /// 
        /// </summary>
        public const int DNS_ERROR_RCODE_LAST = DNS_ERROR_RCODE_BADTIME;


        /// <summary>
        /// <para>//  Packet format</para>
        /// </summary>

        public const int DNS_ERROR_PACKET_FMT_BASE = 9500;

        /// <summary>
        /// <para>// DNS_INFO_NO_RECORDS                   0x0000251d</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_INFO_NO_RECORDS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  No records found for given DNS query.</para>
        /// </summary>
        public const int DNS_INFO_NO_RECORDS = 9501;

        /// <summary>
        /// <para>// DNS_ERROR_BAD_PACKET                  0x0000251e</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_BAD_PACKET</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Bad DNS packet.</para>
        /// </summary>
        public const int DNS_ERROR_BAD_PACKET = 9502;

        /// <summary>
        /// <para>// DNS_ERROR_NO_PACKET                   0x0000251f</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_NO_PACKET</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  No DNS packet.</para>
        /// </summary>
        public const int DNS_ERROR_NO_PACKET = 9503;

        /// <summary>
        /// <para>// DNS_ERROR_RCODE                       0x00002520</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_RCODE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  DNS error, check rcode.</para>
        /// </summary>
        public const int DNS_ERROR_RCODE = 9504;

        /// <summary>
        /// <para>// DNS_ERROR_UNSECURE_PACKET             0x00002521</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_UNSECURE_PACKET</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Unsecured DNS packet.</para>
        /// </summary>
        public const int DNS_ERROR_UNSECURE_PACKET = 9505;

        /// <summary>
        /// 
        /// </summary>
        public const int DNS_STATUS_PACKET_UNSECURE = DNS_ERROR_UNSECURE_PACKET;


        //  General API errors

        /// <summary>
        /// 
        /// </summary>
        public const int DNS_ERROR_NO_MEMORY = ERROR_OUTOFMEMORY;

        /// <summary>
        /// 
        /// </summary>
        public const int DNS_ERROR_INVALID_NAME = ERROR_INVALID_NAME;

        /// <summary>
        /// 
        /// </summary>
        public const int DNS_ERROR_INVALID_DATA = ERROR_INVALID_DATA;

        /// <summary>
        /// 
        /// </summary>
        public const int DNS_ERROR_GENERAL_API_BASE = 9550;

        /// <summary>
        /// <para>// DNS_ERROR_INVALID_TYPE                0x0000254f</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_INVALID_TYPE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Invalid DNS type.</para>
        /// </summary>
        public const int DNS_ERROR_INVALID_TYPE = 9551;

        /// <summary>
        /// <para>// DNS_ERROR_INVALID_IP_ADDRESS          0x00002550</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_INVALID_IP_ADDRESS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Invalid IP address.</para>
        /// </summary>
        public const int DNS_ERROR_INVALID_IP_ADDRESS = 9552;

        /// <summary>
        /// <para>// DNS_ERROR_INVALID_PROPERTY            0x00002551</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_INVALID_PROPERTY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Invalid property.</para>
        /// </summary>
        public const int DNS_ERROR_INVALID_PROPERTY = 9553;

        /// <summary>
        /// <para>// DNS_ERROR_TRY_AGAIN_LATER             0x00002552</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_TRY_AGAIN_LATER</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Try DNS operation again later.</para>
        /// </summary>
        public const int DNS_ERROR_TRY_AGAIN_LATER = 9554;

        /// <summary>
        /// <para>// DNS_ERROR_NOT_UNIQUE                  0x00002553</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_NOT_UNIQUE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Record for given name and type is not unique.</para>
        /// </summary>
        public const int DNS_ERROR_NOT_UNIQUE = 9555;

        /// <summary>
        /// <para>// DNS_ERROR_NON_RFC_NAME                0x00002554</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_NON_RFC_NAME</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  DNS name does not comply with RFC specifications.</para>
        /// </summary>
        public const int DNS_ERROR_NON_RFC_NAME = 9556;

        /// <summary>
        /// <para>// DNS_STATUS_FQDN                       0x00002555</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_STATUS_FQDN</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  DNS name is a fully-qualified DNS name.</para>
        /// </summary>
        public const int DNS_STATUS_FQDN = 9557;

        /// <summary>
        /// <para>// DNS_STATUS_DOTTED_NAME                0x00002556</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_STATUS_DOTTED_NAME</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  DNS name is dotted (multi-label).</para>
        /// </summary>
        public const int DNS_STATUS_DOTTED_NAME = 9558;

        /// <summary>
        /// <para>// DNS_STATUS_SINGLE_PART_NAME           0x00002557</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_STATUS_SINGLE_PART_NAME</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  DNS name is a single-part name.</para>
        /// </summary>
        public const int DNS_STATUS_SINGLE_PART_NAME = 9559;

        /// <summary>
        /// <para>// DNS_ERROR_INVALID_NAME_CHAR           0x00002558</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_INVALID_NAME_CHAR</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  DNS name contains an invalid character.</para>
        /// </summary>
        public const int DNS_ERROR_INVALID_NAME_CHAR = 9560;

        /// <summary>
        /// <para>// DNS_ERROR_NUMERIC_NAME                0x00002559</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_NUMERIC_NAME</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  DNS name is entirely numeric.</para>
        /// </summary>
        public const int DNS_ERROR_NUMERIC_NAME = 9561;

        /// <summary>
        /// <para>// DNS_ERROR_NOT_ALLOWED_ON_ROOT_SERVER  0x0000255A</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_NOT_ALLOWED_ON_ROOT_SERVER</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The operation requested is not permitted on a DNS root server.</para>
        /// </summary>
        public const int DNS_ERROR_NOT_ALLOWED_ON_ROOT_SERVER = 9562;

        /// <summary>
        /// <para>// DNS_ERROR_NOT_ALLOWED_UNDER_DELEGATION  0x0000255B</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_NOT_ALLOWED_UNDER_DELEGATION</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The record could not be created because this part of the DNS namespace has</para>
        /// <para>//  been delegated to another server.</para>
        /// </summary>
        public const int DNS_ERROR_NOT_ALLOWED_UNDER_DELEGATION = 9563;

        /// <summary>
        /// <para>// DNS_ERROR_CANNOT_FIND_ROOT_HINTS  0x0000255C</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_CANNOT_FIND_ROOT_HINTS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The DNS server could not find a set of root hints.</para>
        /// </summary>
        public const int DNS_ERROR_CANNOT_FIND_ROOT_HINTS = 9564;

        /// <summary>
        /// <para>// DNS_ERROR_INCONSISTENT_ROOT_HINTS  0x0000255D</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_INCONSISTENT_ROOT_HINTS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The DNS server found root hints but they were not consistent across</para>
        /// <para>//  all adapters.</para>
        /// </summary>
        public const int DNS_ERROR_INCONSISTENT_ROOT_HINTS = 9565;


        /// <summary>
        /// <para>//  Zone errors</para>
        /// </summary>

        public const int DNS_ERROR_ZONE_BASE = 9600;

        /// <summary>
        /// <para>// DNS_ERROR_ZONE_DOES_NOT_EXIST         0x00002581</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_ZONE_DOES_NOT_EXIST</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  DNS zone does not exist.</para>
        /// </summary>
        public const int DNS_ERROR_ZONE_DOES_NOT_EXIST = 9601;

        /// <summary>
        /// <para>// DNS_ERROR_NO_ZONE_INFO                0x00002582</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_NO_ZONE_INFO</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  DNS zone information not available.</para>
        /// </summary>
        public const int DNS_ERROR_NO_ZONE_INFO = 9602;

        /// <summary>
        /// <para>// DNS_ERROR_INVALID_ZONE_OPERATION      0x00002583</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_INVALID_ZONE_OPERATION</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Invalid operation for DNS zone.</para>
        /// </summary>
        public const int DNS_ERROR_INVALID_ZONE_OPERATION = 9603;

        /// <summary>
        /// <para>// DNS_ERROR_ZONE_CONFIGURATION_ERROR    0x00002584</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_ZONE_CONFIGURATION_ERROR</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Invalid DNS zone configuration.</para>
        /// </summary>
        public const int DNS_ERROR_ZONE_CONFIGURATION_ERROR = 9604;

        /// <summary>
        /// <para>// DNS_ERROR_ZONE_HAS_NO_SOA_RECORD      0x00002585</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_ZONE_HAS_NO_SOA_RECORD</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  DNS zone has no start of authority (SOA) record.</para>
        /// </summary>
        public const int DNS_ERROR_ZONE_HAS_NO_SOA_RECORD = 9605;

        /// <summary>
        /// <para>// DNS_ERROR_ZONE_HAS_NO_NS_RECORDS      0x00002586</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_ZONE_HAS_NO_NS_RECORDS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  DNS zone has no Name Server (NS) record.</para>
        /// </summary>
        public const int DNS_ERROR_ZONE_HAS_NO_NS_RECORDS = 9606;

        /// <summary>
        /// <para>// DNS_ERROR_ZONE_LOCKED                 0x00002587</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_ZONE_LOCKED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  DNS zone is locked.</para>
        /// </summary>
        public const int DNS_ERROR_ZONE_LOCKED = 9607;

        /// <summary>
        /// <para>// DNS_ERROR_ZONE_CREATION_FAILED        0x00002588</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_ZONE_CREATION_FAILED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  DNS zone creation failed.</para>
        /// </summary>
        public const int DNS_ERROR_ZONE_CREATION_FAILED = 9608;

        /// <summary>
        /// <para>// DNS_ERROR_ZONE_ALREADY_EXISTS         0x00002589</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_ZONE_ALREADY_EXISTS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  DNS zone already exists.</para>
        /// </summary>
        public const int DNS_ERROR_ZONE_ALREADY_EXISTS = 9609;

        /// <summary>
        /// <para>// DNS_ERROR_AUTOZONE_ALREADY_EXISTS     0x0000258a</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_AUTOZONE_ALREADY_EXISTS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  DNS automatic zone already exists.</para>
        /// </summary>
        public const int DNS_ERROR_AUTOZONE_ALREADY_EXISTS = 9610;

        /// <summary>
        /// <para>// DNS_ERROR_INVALID_ZONE_TYPE           0x0000258b</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_INVALID_ZONE_TYPE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Invalid DNS zone type.</para>
        /// </summary>
        public const int DNS_ERROR_INVALID_ZONE_TYPE = 9611;

        /// <summary>
        /// <para>// DNS_ERROR_SECONDARY_REQUIRES_MASTER_IP 0x0000258c</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_SECONDARY_REQUIRES_MASTER_IP</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Secondary DNS zone requires master IP address.</para>
        /// </summary>
        public const int DNS_ERROR_SECONDARY_REQUIRES_MASTER_IP = 9612;

        /// <summary>
        /// <para>// DNS_ERROR_ZONE_NOT_SECONDARY          0x0000258d</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_ZONE_NOT_SECONDARY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  DNS zone not secondary.</para>
        /// </summary>
        public const int DNS_ERROR_ZONE_NOT_SECONDARY = 9613;

        /// <summary>
        /// <para>// DNS_ERROR_NEED_SECONDARY_ADDRESSES    0x0000258e</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_NEED_SECONDARY_ADDRESSES</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Need secondary IP address.</para>
        /// </summary>
        public const int DNS_ERROR_NEED_SECONDARY_ADDRESSES = 9614;

        /// <summary>
        /// <para>// DNS_ERROR_WINS_INIT_FAILED            0x0000258f</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_WINS_INIT_FAILED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  WINS initialization failed.</para>
        /// </summary>
        public const int DNS_ERROR_WINS_INIT_FAILED = 9615;

        /// <summary>
        /// <para>// DNS_ERROR_NEED_WINS_SERVERS           0x00002590</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_NEED_WINS_SERVERS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Need WINS servers.</para>
        /// </summary>
        public const int DNS_ERROR_NEED_WINS_SERVERS = 9616;

        /// <summary>
        /// <para>// DNS_ERROR_NBSTAT_INIT_FAILED          0x00002591</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_NBSTAT_INIT_FAILED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  NBTSTAT initialization call failed.</para>
        /// </summary>
        public const int DNS_ERROR_NBSTAT_INIT_FAILED = 9617;

        /// <summary>
        /// <para>// DNS_ERROR_SOA_DELETE_INVALID          0x00002592</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_SOA_DELETE_INVALID</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Invalid delete of start of authority (SOA)</para>
        /// </summary>
        public const int DNS_ERROR_SOA_DELETE_INVALID = 9618;

        /// <summary>
        /// <para>// DNS_ERROR_FORWARDER_ALREADY_EXISTS    0x00002593</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_FORWARDER_ALREADY_EXISTS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A conditional forwarding zone already exists for that name.</para>
        /// </summary>
        public const int DNS_ERROR_FORWARDER_ALREADY_EXISTS = 9619;

        /// <summary>
        /// <para>// DNS_ERROR_ZONE_REQUIRES_MASTER_IP     0x00002594</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_ZONE_REQUIRES_MASTER_IP</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  This zone must be configured with one or more master DNS server IP addresses.</para>
        /// </summary>
        public const int DNS_ERROR_ZONE_REQUIRES_MASTER_IP = 9620;

        /// <summary>
        /// <para>// DNS_ERROR_ZONE_IS_SHUTDOWN            0x00002595</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_ZONE_IS_SHUTDOWN</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The operation cannot be performed because this zone is shutdown.</para>
        /// </summary>
        public const int DNS_ERROR_ZONE_IS_SHUTDOWN = 9621;


        /// <summary>
        /// <para>//  Datafile errors</para>
        /// </summary>

        public const int DNS_ERROR_DATAFILE_BASE = 9650;

        /// <summary>
        /// <para>// DNS                                   0x000025b3</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_PRIMARY_REQUIRES_DATAFILE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Primary DNS zone requires datafile.</para>
        /// </summary>
        public const int DNS_ERROR_PRIMARY_REQUIRES_DATAFILE = 9651;

        /// <summary>
        /// <para>// DNS                                   0x000025b4</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_INVALID_DATAFILE_NAME</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Invalid datafile name for DNS zone.</para>
        /// </summary>
        public const int DNS_ERROR_INVALID_DATAFILE_NAME = 9652;

        /// <summary>
        /// <para>// DNS                                   0x000025b5</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_DATAFILE_OPEN_FAILURE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Failed to open datafile for DNS zone.</para>
        /// </summary>
        public const int DNS_ERROR_DATAFILE_OPEN_FAILURE = 9653;

        /// <summary>
        /// <para>// DNS                                   0x000025b6</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_FILE_WRITEBACK_FAILED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Failed to write datafile for DNS zone.</para>
        /// </summary>
        public const int DNS_ERROR_FILE_WRITEBACK_FAILED = 9654;

        /// <summary>
        /// <para>// DNS                                   0x000025b7</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_DATAFILE_PARSING</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Failure while reading datafile for DNS zone.</para>
        /// </summary>
        public const int DNS_ERROR_DATAFILE_PARSING = 9655;


        /// <summary>
        /// <para>//  Database errors</para>
        /// </summary>

        public const int DNS_ERROR_DATABASE_BASE = 9700;

        /// <summary>
        /// <para>// DNS_ERROR_RECORD_DOES_NOT_EXIST       0x000025e5</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_RECORD_DOES_NOT_EXIST</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  DNS record does not exist.</para>
        /// </summary>
        public const int DNS_ERROR_RECORD_DOES_NOT_EXIST = 9701;

        /// <summary>
        /// <para>// DNS_ERROR_RECORD_FORMAT               0x000025e6</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_RECORD_FORMAT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  DNS record format error.</para>
        /// </summary>
        public const int DNS_ERROR_RECORD_FORMAT = 9702;

        /// <summary>
        /// <para>// DNS_ERROR_NODE_CREATION_FAILED        0x000025e7</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_NODE_CREATION_FAILED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Node creation failure in DNS.</para>
        /// </summary>
        public const int DNS_ERROR_NODE_CREATION_FAILED = 9703;

        /// <summary>
        /// <para>// DNS_ERROR_UNKNOWN_RECORD_TYPE         0x000025e8</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_UNKNOWN_RECORD_TYPE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Unknown DNS record type.</para>
        /// </summary>
        public const int DNS_ERROR_UNKNOWN_RECORD_TYPE = 9704;

        /// <summary>
        /// <para>// DNS_ERROR_RECORD_TIMED_OUT            0x000025e9</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_RECORD_TIMED_OUT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  DNS record timed out.</para>
        /// </summary>
        public const int DNS_ERROR_RECORD_TIMED_OUT = 9705;

        /// <summary>
        /// <para>// DNS_ERROR_NAME_NOT_IN_ZONE            0x000025ea</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_NAME_NOT_IN_ZONE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Name not in DNS zone.</para>
        /// </summary>
        public const int DNS_ERROR_NAME_NOT_IN_ZONE = 9706;

        /// <summary>
        /// <para>// DNS_ERROR_CNAME_LOOP                  0x000025eb</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_CNAME_LOOP</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  CNAME loop detected.</para>
        /// </summary>
        public const int DNS_ERROR_CNAME_LOOP = 9707;

        /// <summary>
        /// <para>// DNS_ERROR_NODE_IS_CNAME               0x000025ec</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_NODE_IS_CNAME</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Node is a CNAME DNS record.</para>
        /// </summary>
        public const int DNS_ERROR_NODE_IS_CNAME = 9708;

        /// <summary>
        /// <para>// DNS_ERROR_CNAME_COLLISION             0x000025ed</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_CNAME_COLLISION</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A CNAME record already exists for given name.</para>
        /// </summary>
        public const int DNS_ERROR_CNAME_COLLISION = 9709;

        /// <summary>
        /// <para>// DNS_ERROR_RECORD_ONLY_AT_ZONE_ROOT    0x000025ee</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_RECORD_ONLY_AT_ZONE_ROOT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Record only at DNS zone root.</para>
        /// </summary>
        public const int DNS_ERROR_RECORD_ONLY_AT_ZONE_ROOT = 9710;

        /// <summary>
        /// <para>// DNS_ERROR_RECORD_ALREADY_EXISTS       0x000025ef</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_RECORD_ALREADY_EXISTS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  DNS record already exists.</para>
        /// </summary>
        public const int DNS_ERROR_RECORD_ALREADY_EXISTS = 9711;

        /// <summary>
        /// <para>// DNS_ERROR_SECONDARY_DATA              0x000025f0</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_SECONDARY_DATA</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Secondary DNS zone data error.</para>
        /// </summary>
        public const int DNS_ERROR_SECONDARY_DATA = 9712;

        /// <summary>
        /// <para>// DNS_ERROR_NO_CREATE_CACHE_DATA        0x000025f1</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_NO_CREATE_CACHE_DATA</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Could not create DNS cache data.</para>
        /// </summary>
        public const int DNS_ERROR_NO_CREATE_CACHE_DATA = 9713;

        /// <summary>
        /// <para>// DNS_ERROR_NAME_DOES_NOT_EXIST         0x000025f2</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_NAME_DOES_NOT_EXIST</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  DNS name does not exist.</para>
        /// </summary>
        public const int DNS_ERROR_NAME_DOES_NOT_EXIST = 9714;

        /// <summary>
        /// <para>// DNS_WARNING_PTR_CREATE_FAILED         0x000025f3</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_WARNING_PTR_CREATE_FAILED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Could not create pointer (PTR) record.</para>
        /// </summary>
        public const int DNS_WARNING_PTR_CREATE_FAILED = 9715;

        /// <summary>
        /// <para>// DNS_WARNING_DOMAIN_UNDELETED          0x000025f4</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_WARNING_DOMAIN_UNDELETED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  DNS domain was undeleted.</para>
        /// </summary>
        public const int DNS_WARNING_DOMAIN_UNDELETED = 9716;

        /// <summary>
        /// <para>// DNS_ERROR_DS_UNAVAILABLE              0x000025f5</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_DS_UNAVAILABLE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The directory service is unavailable.</para>
        /// </summary>
        public const int DNS_ERROR_DS_UNAVAILABLE = 9717;

        /// <summary>
        /// <para>// DNS_ERROR_DS_ZONE_ALREADY_EXISTS      0x000025f6</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_DS_ZONE_ALREADY_EXISTS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  DNS zone already exists in the directory service.</para>
        /// </summary>
        public const int DNS_ERROR_DS_ZONE_ALREADY_EXISTS = 9718;

        /// <summary>
        /// <para>// DNS_ERROR_NO_BOOTFILE_IF_DS_ZONE      0x000025f7</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_NO_BOOTFILE_IF_DS_ZONE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  DNS server not creating or reading the boot file for the directory service integrated DNS zone.</para>
        /// </summary>
        public const int DNS_ERROR_NO_BOOTFILE_IF_DS_ZONE = 9719;


        /// <summary>
        /// <para>//  Operation errors</para>
        /// </summary>

        public const int DNS_ERROR_OPERATION_BASE = 9750;

        /// <summary>
        /// <para>// DNS_INFO_AXFR_COMPLETE                0x00002617</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_INFO_AXFR_COMPLETE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  DNS AXFR (zone transfer) complete.</para>
        /// </summary>
        public const int DNS_INFO_AXFR_COMPLETE = 9751;

        /// <summary>
        /// <para>// DNS_ERROR_AXFR                        0x00002618</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_AXFR</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  DNS zone transfer failed.</para>
        /// </summary>
        public const int DNS_ERROR_AXFR = 9752;

        /// <summary>
        /// <para>// DNS_INFO_ADDED_LOCAL_WINS             0x00002619</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_INFO_ADDED_LOCAL_WINS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Added local WINS server.</para>
        /// </summary>
        public const int DNS_INFO_ADDED_LOCAL_WINS = 9753;


        /// <summary>
        /// <para>//  Secure update</para>
        /// </summary>

        public const int DNS_ERROR_SECURE_BASE = 9800;

        /// <summary>
        /// <para>// DNS_STATUS_CONTINUE_NEEDED            0x00002649</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_STATUS_CONTINUE_NEEDED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Secure update call needs to continue update request.</para>
        /// </summary>
        public const int DNS_STATUS_CONTINUE_NEEDED = 9801;


        /// <summary>
        /// <para>//  Setup errors</para>
        /// </summary>

        public const int DNS_ERROR_SETUP_BASE = 9850;

        /// <summary>
        /// <para>// DNS_ERROR_NO_TCPIP                    0x0000267b</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_NO_TCPIP</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  TCP/IP network protocol not installed.</para>
        /// </summary>
        public const int DNS_ERROR_NO_TCPIP = 9851;

        /// <summary>
        /// <para>// DNS_ERROR_NO_DNS_SERVERS              0x0000267c</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_NO_DNS_SERVERS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  No DNS servers configured for local system.</para>
        /// </summary>
        public const int DNS_ERROR_NO_DNS_SERVERS = 9852;


        /// <summary>
        /// <para>//  Directory partition (DP) errors</para>
        /// </summary>

        public const int DNS_ERROR_DP_BASE = 9900;

        /// <summary>
        /// <para>// DNS_ERROR_DP_DOES_NOT_EXIST           0x000026ad</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_DP_DOES_NOT_EXIST</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified directory partition does not exist.</para>
        /// </summary>
        public const int DNS_ERROR_DP_DOES_NOT_EXIST = 9901;

        /// <summary>
        /// <para>// DNS_ERROR_DP_ALREADY_EXISTS           0x000026ae</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_DP_ALREADY_EXISTS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified directory partition already exists.</para>
        /// </summary>
        public const int DNS_ERROR_DP_ALREADY_EXISTS = 9902;

        /// <summary>
        /// <para>// DNS_ERROR_DP_NOT_ENLISTED             0x000026af</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_DP_NOT_ENLISTED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  This DNS server is not enlisted in the specified directory partition.</para>
        /// </summary>
        public const int DNS_ERROR_DP_NOT_ENLISTED = 9903;

        /// <summary>
        /// <para>// DNS_ERROR_DP_ALREADY_ENLISTED         0x000026b0</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_DP_ALREADY_ENLISTED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  This DNS server is already enlisted in the specified directory partition.</para>
        /// </summary>
        public const int DNS_ERROR_DP_ALREADY_ENLISTED = 9904;

        /// <summary>
        /// <para>// DNS_ERROR_DP_NOT_AVAILABLE            0x000026b1</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_DP_NOT_AVAILABLE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The directory partition is not available at this time. Please wait</para>
        /// <para>//  a few minutes and try again.</para>
        /// </summary>
        public const int DNS_ERROR_DP_NOT_AVAILABLE = 9905;

        /// <summary>
        /// <para>// DNS_ERROR_DP_FSMO_ERROR               0x000026b2</para>
        /// <para>//</para>
        /// <para>// MessageId: DNS_ERROR_DP_FSMO_ERROR</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The application directory partition operation failed. The domain controller</para>
        /// <para>//  holding the domain naming master role is down or unable to service the</para>
        /// <para>//  request or is not running Windows Server 2003.</para>
        /// </summary>
        public const int DNS_ERROR_DP_FSMO_ERROR = 9906;

        ///////////////////////////////////////////////////
        //                                               //
        //             End of DNS Error Codes            //
        //                                               //
        //                  9000 to 9999                 //
        ///////////////////////////////////////////////////


        ///////////////////////////////////////////////////
        //                                               //
        //               WinSock Error Codes             //
        //                                               //
        //                 10000 to 11999                //
        ///////////////////////////////////////////////////

        /// <summary>
        /// <para>// WinSock error codes are also defined in WinSock.h</para>
        /// <para>// and WinSock2.h, hence the IFDEF</para>
        /// </summary>
        public const int WSABASEERR = 10000;

        /// <summary>
        /// <para>// MessageId: WSAEINTR</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A blocking operation was interrupted by a call to WSACancelBlockingCall.</para>
        /// </summary>
        public const int WSAEINTR = 10004;

        /// <summary>
        /// <para>// MessageId: WSAEBADF</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The file handle supplied is not valid.</para>
        /// </summary>
        public const int WSAEBADF = 10009;

        /// <summary>
        /// <para>// MessageId: WSAEACCES</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An attempt was made to access a socket in a way forbidden by its access permissions.</para>
        /// </summary>
        public const int WSAEACCES = 10013;

        /// <summary>
        /// <para>// MessageId: WSAEFAULT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The system detected an invalid pointer address in attempting to use a pointer argument in a call.</para>
        /// </summary>
        public const int WSAEFAULT = 10014;

        /// <summary>
        /// <para>// MessageId: WSAEINVAL</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An invalid argument was supplied.</para>
        /// </summary>
        public const int WSAEINVAL = 10022;

        /// <summary>
        /// <para>// MessageId: WSAEMFILE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Too many open sockets.</para>
        /// </summary>
        public const int WSAEMFILE = 10024;

        /// <summary>
        /// <para>// MessageId: WSAEWOULDBLOCK</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A non-blocking socket operation could not be completed immediately.</para>
        /// </summary>
        public const int WSAEWOULDBLOCK = 10035;

        /// <summary>
        /// <para>// MessageId: WSAEINPROGRESS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A blocking operation is currently executing.</para>
        /// </summary>
        public const int WSAEINPROGRESS = 10036;

        /// <summary>
        /// <para>// MessageId: WSAEALREADY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An operation was attempted on a non-blocking socket that already had an operation in progress.</para>
        /// </summary>
        public const int WSAEALREADY = 10037;

        /// <summary>
        /// <para>// MessageId: WSAENOTSOCK</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An operation was attempted on something that is not a socket.</para>
        /// </summary>
        public const int WSAENOTSOCK = 10038;

        /// <summary>
        /// <para>// MessageId: WSAEDESTADDRREQ</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A required address was omitted from an operation on a socket.</para>
        /// </summary>
        public const int WSAEDESTADDRREQ = 10039;

        /// <summary>
        /// <para>// MessageId: WSAEMSGSIZE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A message sent on a datagram socket was larger than the internal message buffer or some other  network limit, or the buffer used to receive a datagram into was smaller than the datagram itself.</para>
        /// </summary>
        public const int WSAEMSGSIZE = 10040;

        /// <summary>
        /// <para>// MessageId: WSAEPROTOTYPE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A protocol was specified in the socket function call that does not support the semantics of the  socket type requested.</para>
        /// </summary>
        public const int WSAEPROTOTYPE = 10041;

        /// <summary>
        /// <para>// MessageId: WSAENOPROTOOPT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An unknown, invalid, or unsupported option or level was specified in a getsockopt or setsockopt  call.</para>
        /// </summary>
        public const int WSAENOPROTOOPT = 10042;

        /// <summary>
        /// <para>// MessageId: WSAEPROTONOSUPPORT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The requested protocol has not been configured into the system, or no implementation for it  exists.</para>
        /// </summary>
        public const int WSAEPROTONOSUPPORT = 10043;

        /// <summary>
        /// <para>// MessageId: WSAESOCKTNOSUPPORT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The support for the specified socket type does not exist in this address family.</para>
        /// </summary>
        public const int WSAESOCKTNOSUPPORT = 10044;

        /// <summary>
        /// <para>// MessageId: WSAEOPNOTSUPP</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The attempted operation is not supported for the type of object referenced.</para>
        /// </summary>
        public const int WSAEOPNOTSUPP = 10045;

        /// <summary>
        /// <para>// MessageId: WSAEPFNOSUPPORT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The protocol family has not been configured into the system or no implementation for it exists.</para>
        /// </summary>
        public const int WSAEPFNOSUPPORT = 10046;

        /// <summary>
        /// <para>// MessageId: WSAEAFNOSUPPORT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An address incompatible with the requested protocol was used.</para>
        /// </summary>
        public const int WSAEAFNOSUPPORT = 10047;

        /// <summary>
        /// <para>// MessageId: WSAEADDRINUSE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Only one usage of each socket address (protocol/network address/port) is normally permitted.</para>
        /// </summary>
        public const int WSAEADDRINUSE = 10048;

        /// <summary>
        /// <para>// MessageId: WSAEADDRNOTAVAIL</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The requested address is not valid in its context.</para>
        /// </summary>
        public const int WSAEADDRNOTAVAIL = 10049;

        /// <summary>
        /// <para>// MessageId: WSAENETDOWN</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A socket operation encountered a dead network.</para>
        /// </summary>
        public const int WSAENETDOWN = 10050;

        /// <summary>
        /// <para>// MessageId: WSAENETUNREACH</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A socket operation was attempted to an unreachable network.</para>
        /// </summary>
        public const int WSAENETUNREACH = 10051;

        /// <summary>
        /// <para>// MessageId: WSAENETRESET</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The connection has been broken due to keep-alive activity detecting a failure while the operation  was in progress.</para>
        /// </summary>
        public const int WSAENETRESET = 10052;

        /// <summary>
        /// <para>// MessageId: WSAECONNABORTED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An established connection was aborted by the software in your host machine.</para>
        /// </summary>
        public const int WSAECONNABORTED = 10053;

        /// <summary>
        /// <para>// MessageId: WSAECONNRESET</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An existing connection was forcibly closed by the remote host.</para>
        /// </summary>
        public const int WSAECONNRESET = 10054;

        /// <summary>
        /// <para>// MessageId: WSAENOBUFS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An operation on a socket could not be performed because the system lacked sufficient buffer space  or because a queue was full.</para>
        /// </summary>
        public const int WSAENOBUFS = 10055;

        /// <summary>
        /// <para>// MessageId: WSAEISCONN</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A connect request was made on an already connected socket.</para>
        /// </summary>
        public const int WSAEISCONN = 10056;

        /// <summary>
        /// <para>// MessageId: WSAENOTCONN</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A request to send or receive data was disallowed because the socket is not connected and (when  sending on a datagram socket using a sendto call) no address was supplied.</para>
        /// </summary>
        public const int WSAENOTCONN = 10057;

        /// <summary>
        /// <para>// MessageId: WSAESHUTDOWN</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A request to send or receive data was disallowed because the socket had already been shut down in  that direction with a previous shutdown call.</para>
        /// </summary>
        public const int WSAESHUTDOWN = 10058;

        /// <summary>
        /// <para>// MessageId: WSAETOOMANYREFS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Too many references to some kernel object.</para>
        /// </summary>
        public const int WSAETOOMANYREFS = 10059;

        /// <summary>
        /// <para>// MessageId: WSAETIMEDOUT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A connection attempt failed because the connected party did not properly respond after a period of  time, or established connection failed because connected host has failed to respond.</para>
        /// </summary>
        public const int WSAETIMEDOUT = 10060;

        /// <summary>
        /// <para>// MessageId: WSAECONNREFUSED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  No connection could be made because the target machine actively refused it.</para>
        /// </summary>
        public const int WSAECONNREFUSED = 10061;

        /// <summary>
        /// <para>// MessageId: WSAELOOP</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Cannot translate name.</para>
        /// </summary>
        public const int WSAELOOP = 10062;

        /// <summary>
        /// <para>// MessageId: WSAENAMETOOLONG</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Name component or name was too long.</para>
        /// </summary>
        public const int WSAENAMETOOLONG = 10063;

        /// <summary>
        /// <para>// MessageId: WSAEHOSTDOWN</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A socket operation failed because the destination host was down.</para>
        /// </summary>
        public const int WSAEHOSTDOWN = 10064;

        /// <summary>
        /// <para>// MessageId: WSAEHOSTUNREACH</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A socket operation was attempted to an unreachable host.</para>
        /// </summary>
        public const int WSAEHOSTUNREACH = 10065;

        /// <summary>
        /// <para>// MessageId: WSAENOTEMPTY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Cannot remove a directory that is not empty.</para>
        /// </summary>
        public const int WSAENOTEMPTY = 10066;

        /// <summary>
        /// <para>// MessageId: WSAEPROCLIM</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A Windows Sockets implementation may have a limit on the number of applications that may use it  simultaneously.</para>
        /// </summary>
        public const int WSAEPROCLIM = 10067;

        /// <summary>
        /// <para>// MessageId: WSAEUSERS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Ran out of quota.</para>
        /// </summary>
        public const int WSAEUSERS = 10068;

        /// <summary>
        /// <para>// MessageId: WSAEDQUOT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Ran out of disk quota.</para>
        /// </summary>
        public const int WSAEDQUOT = 10069;

        /// <summary>
        /// <para>// MessageId: WSAESTALE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  File handle reference is no longer available.</para>
        /// </summary>
        public const int WSAESTALE = 10070;

        /// <summary>
        /// <para>// MessageId: WSAEREMOTE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Item is not available locally.</para>
        /// </summary>
        public const int WSAEREMOTE = 10071;

        /// <summary>
        /// <para>// MessageId: WSASYSNOTREADY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  WSAStartup cannot function at this time because the underlying system it uses to provide network  services is currently unavailable.</para>
        /// </summary>
        public const int WSASYSNOTREADY = 10091;

        /// <summary>
        /// <para>// MessageId: WSAVERNOTSUPPORTED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The Windows Sockets version requested is not supported.</para>
        /// </summary>
        public const int WSAVERNOTSUPPORTED = 10092;

        /// <summary>
        /// <para>// MessageId: WSANOTINITIALISED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Either the application has not called WSAStartup, or WSAStartup failed.</para>
        /// </summary>
        public const int WSANOTINITIALISED = 10093;

        /// <summary>
        /// <para>// MessageId: WSAEDISCON</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Returned by WSARecv or WSARecvFrom to indicate the remote party has initiated a graceful shutdown  sequence.</para>
        /// </summary>
        public const int WSAEDISCON = 10101;

        /// <summary>
        /// <para>// MessageId: WSAENOMORE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  No more results can be returned by WSALookupServiceNext.</para>
        /// </summary>
        public const int WSAENOMORE = 10102;

        /// <summary>
        /// <para>// MessageId: WSAECANCELLED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A call to WSALookupServiceEnd was made while this call was still processing. The call has been  canceled.</para>
        /// </summary>
        public const int WSAECANCELLED = 10103;

        /// <summary>
        /// <para>// MessageId: WSAEINVALIDPROCTABLE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The procedure call table is invalid.</para>
        /// </summary>
        public const int WSAEINVALIDPROCTABLE = 10104;

        /// <summary>
        /// <para>// MessageId: WSAEINVALIDPROVIDER</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The requested service provider is invalid.</para>
        /// </summary>
        public const int WSAEINVALIDPROVIDER = 10105;

        /// <summary>
        /// <para>// MessageId: WSAEPROVIDERFAILEDINIT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The requested service provider could not be loaded or initialized.</para>
        /// </summary>
        public const int WSAEPROVIDERFAILEDINIT = 10106;

        /// <summary>
        /// <para>// MessageId: WSASYSCALLFAILURE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A system call that should never fail has failed.</para>
        /// </summary>
        public const int WSASYSCALLFAILURE = 10107;

        /// <summary>
        /// <para>// MessageId: WSASERVICE_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  No such service is known. The service cannot be found in the specified name space.</para>
        /// </summary>
        public const int WSASERVICE_NOT_FOUND = 10108;

        /// <summary>
        /// <para>// MessageId: WSATYPE_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified class was not found.</para>
        /// </summary>
        public const int WSATYPE_NOT_FOUND = 10109;

        /// <summary>
        /// <para>// MessageId: WSA_E_NO_MORE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  No more results can be returned by WSALookupServiceNext.</para>
        /// </summary>
        public const int WSA_E_NO_MORE = 10110;

        /// <summary>
        /// <para>// MessageId: WSA_E_CANCELLED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A call to WSALookupServiceEnd was made while this call was still processing. The call has been  canceled.</para>
        /// </summary>
        public const int WSA_E_CANCELLED = 10111;

        /// <summary>
        /// <para>// MessageId: WSAEREFUSED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A database query failed because it was actively refused.</para>
        /// </summary>
        public const int WSAEREFUSED = 10112;

        /// <summary>
        /// <para>// MessageId: WSAHOST_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  No such host is known.</para>
        /// </summary>
        public const int WSAHOST_NOT_FOUND = 11001;

        /// <summary>
        /// <para>// MessageId: WSATRY_AGAIN</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  This is usually a temporary error during hostname resolution and means that the local server did  not receive a response from an authoritative server.</para>
        /// </summary>
        public const int WSATRY_AGAIN = 11002;

        /// <summary>
        /// <para>// MessageId: WSANO_RECOVERY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A non-recoverable error occurred during a database lookup.</para>
        /// </summary>
        public const int WSANO_RECOVERY = 11003;

        /// <summary>
        /// <para>// MessageId: WSANO_DATA</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The requested name is valid, but no data of the requested type was found.</para>
        /// </summary>
        public const int WSANO_DATA = 11004;

        /// <summary>
        /// <para>// MessageId: WSA_QOS_RECEIVERS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  At least one reserve has arrived.</para>
        /// </summary>
        public const int WSA_QOS_RECEIVERS = 11005;

        /// <summary>
        /// <para>// MessageId: WSA_QOS_SENDERS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  At least one path has arrived.</para>
        /// </summary>
        public const int WSA_QOS_SENDERS = 11006;

        /// <summary>
        /// <para>// MessageId: WSA_QOS_NO_SENDERS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  There are no senders.</para>
        /// </summary>
        public const int WSA_QOS_NO_SENDERS = 11007;

        /// <summary>
        /// <para>// MessageId: WSA_QOS_NO_RECEIVERS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  There are no receivers.</para>
        /// </summary>
        public const int WSA_QOS_NO_RECEIVERS = 11008;

        /// <summary>
        /// <para>// MessageId: WSA_QOS_REQUEST_CONFIRMED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Reserve has been confirmed.</para>
        /// </summary>
        public const int WSA_QOS_REQUEST_CONFIRMED = 11009;

        /// <summary>
        /// <para>// MessageId: WSA_QOS_ADMISSION_FAILURE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Error due to lack of resources.</para>
        /// </summary>
        public const int WSA_QOS_ADMISSION_FAILURE = 11010;

        /// <summary>
        /// <para>// MessageId: WSA_QOS_POLICY_FAILURE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Rejected for administrative reasons - bad credentials.</para>
        /// </summary>
        public const int WSA_QOS_POLICY_FAILURE = 11011;

        /// <summary>
        /// <para>// MessageId: WSA_QOS_BAD_STYLE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Unknown or conflicting style.</para>
        /// </summary>
        public const int WSA_QOS_BAD_STYLE = 11012;

        /// <summary>
        /// <para>// MessageId: WSA_QOS_BAD_OBJECT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Problem with some part of the filterspec or providerspecific buffer in general.</para>
        /// </summary>
        public const int WSA_QOS_BAD_OBJECT = 11013;

        /// <summary>
        /// <para>// MessageId: WSA_QOS_TRAFFIC_CTRL_ERROR</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Problem with some part of the flowspec.</para>
        /// </summary>
        public const int WSA_QOS_TRAFFIC_CTRL_ERROR = 11014;

        /// <summary>
        /// <para>// MessageId: WSA_QOS_GENERIC_ERROR</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  General QOS error.</para>
        /// </summary>
        public const int WSA_QOS_GENERIC_ERROR = 11015;

        /// <summary>
        /// <para>// MessageId: WSA_QOS_ESERVICETYPE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An invalid or unrecognized service type was found in the flowspec.</para>
        /// </summary>
        public const int WSA_QOS_ESERVICETYPE = 11016;

        /// <summary>
        /// <para>// MessageId: WSA_QOS_EFLOWSPEC</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An invalid or inconsistent flowspec was found in the QOS structure.</para>
        /// </summary>
        public const int WSA_QOS_EFLOWSPEC = 11017;

        /// <summary>
        /// <para>// MessageId: WSA_QOS_EPROVSPECBUF</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Invalid QOS provider-specific buffer.</para>
        /// </summary>
        public const int WSA_QOS_EPROVSPECBUF = 11018;

        /// <summary>
        /// <para>// MessageId: WSA_QOS_EFILTERSTYLE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An invalid QOS filter style was used.</para>
        /// </summary>
        public const int WSA_QOS_EFILTERSTYLE = 11019;

        /// <summary>
        /// <para>// MessageId: WSA_QOS_EFILTERTYPE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An invalid QOS filter type was used.</para>
        /// </summary>
        public const int WSA_QOS_EFILTERTYPE = 11020;

        /// <summary>
        /// <para>// MessageId: WSA_QOS_EFILTERCOUNT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An incorrect number of QOS FILTERSPECs were specified in the FLOWDESCRIPTOR.</para>
        /// </summary>
        public const int WSA_QOS_EFILTERCOUNT = 11021;

        /// <summary>
        /// <para>// MessageId: WSA_QOS_EOBJLENGTH</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An object with an invalid ObjectLength field was specified in the QOS provider-specific buffer.</para>
        /// </summary>
        public const int WSA_QOS_EOBJLENGTH = 11022;

        /// <summary>
        /// <para>// MessageId: WSA_QOS_EFLOWCOUNT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An incorrect number of flow descriptors was specified in the QOS structure.</para>
        /// </summary>
        public const int WSA_QOS_EFLOWCOUNT = 11023;

        /// <summary>
        /// <para>// MessageId: WSA_QOS_EUNKOWNPSOBJ</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An unrecognized object was found in the QOS provider-specific buffer.</para>
        /// </summary>
        public const int WSA_QOS_EUNKOWNPSOBJ = 11024;

        /// <summary>
        /// <para>// MessageId: WSA_QOS_EPOLICYOBJ</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An invalid policy object was found in the QOS provider-specific buffer.</para>
        /// </summary>
        public const int WSA_QOS_EPOLICYOBJ = 11025;

        /// <summary>
        /// <para>// MessageId: WSA_QOS_EFLOWDESC</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An invalid QOS flow descriptor was found in the flow descriptor list.</para>
        /// </summary>
        public const int WSA_QOS_EFLOWDESC = 11026;

        /// <summary>
        /// <para>// MessageId: WSA_QOS_EPSFLOWSPEC</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An invalid or inconsistent flowspec was found in the QOS provider specific buffer.</para>
        /// </summary>
        public const int WSA_QOS_EPSFLOWSPEC = 11027;

        /// <summary>
        /// <para>// MessageId: WSA_QOS_EPSFILTERSPEC</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An invalid FILTERSPEC was found in the QOS provider-specific buffer.</para>
        /// </summary>
        public const int WSA_QOS_EPSFILTERSPEC = 11028;

        /// <summary>
        /// <para>// MessageId: WSA_QOS_ESDMODEOBJ</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An invalid shape discard mode object was found in the QOS provider specific buffer.</para>
        /// </summary>
        public const int WSA_QOS_ESDMODEOBJ = 11029;

        /// <summary>
        /// <para>// MessageId: WSA_QOS_ESHAPERATEOBJ</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An invalid shaping rate object was found in the QOS provider-specific buffer.</para>
        /// </summary>
        public const int WSA_QOS_ESHAPERATEOBJ = 11030;

        /// <summary>
        /// <para>// MessageId: WSA_QOS_RESERVED_PETYPE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A reserved policy element was found in the QOS provider-specific buffer.</para>
        /// </summary>
        public const int WSA_QOS_RESERVED_PETYPE = 11031;

        ///////////////////////////////////////////////////
        //                                               //
        //           End of WinSock Error Codes          //
        //                                               //
        //                 10000 to 11999                //
        ///////////////////////////////////////////////////



        ///////////////////////////////////////////////////
        //                                               //
        //             Side By Side Error Codes          //
        //                                               //
        //                 14000 to 14999                //
        ///////////////////////////////////////////////////

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_SECTION_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The requested section was not present in the activation context.</para>
        /// </summary>
        public const int ERROR_SXS_SECTION_NOT_FOUND = 14000;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_CANT_GEN_ACTCTX</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  This application has failed to start because the application configuration is incorrect.  Reinstalling the application may fix this problem.</para>
        /// </summary>
        public const int ERROR_SXS_CANT_GEN_ACTCTX = 14001;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_INVALID_ACTCTXDATA_FORMAT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The application binding data format is invalid.</para>
        /// </summary>
        public const int ERROR_SXS_INVALID_ACTCTXDATA_FORMAT = 14002;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_ASSEMBLY_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The referenced assembly is not installed on your system.</para>
        /// </summary>
        public const int ERROR_SXS_ASSEMBLY_NOT_FOUND = 14003;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_MANIFEST_FORMAT_ERROR</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The manifest file does not begin with the required tag and format information.</para>
        /// </summary>
        public const int ERROR_SXS_MANIFEST_FORMAT_ERROR = 14004;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_MANIFEST_PARSE_ERROR</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The manifest file contains one or more syntax errors.</para>
        /// </summary>
        public const int ERROR_SXS_MANIFEST_PARSE_ERROR = 14005;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_ACTIVATION_CONTEXT_DISABLED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The application attempted to activate a disabled activation context.</para>
        /// </summary>
        public const int ERROR_SXS_ACTIVATION_CONTEXT_DISABLED = 14006;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_KEY_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The requested lookup key was not found in any active activation context.</para>
        /// </summary>
        public const int ERROR_SXS_KEY_NOT_FOUND = 14007;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_VERSION_CONFLICT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A component version required by the application conflicts with another component version already  active.</para>
        /// </summary>
        public const int ERROR_SXS_VERSION_CONFLICT = 14008;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_WRONG_SECTION_TYPE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The type requested activation context section does not match the query API used.</para>
        /// </summary>
        public const int ERROR_SXS_WRONG_SECTION_TYPE = 14009;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_THREAD_QUERIES_DISABLED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Lack of system resources has required isolated activation to be disabled for the current thread of  execution.</para>
        /// </summary>
        public const int ERROR_SXS_THREAD_QUERIES_DISABLED = 14010;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_PROCESS_DEFAULT_ALREADY_SET</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An attempt to set the process default activation context failed because the process default  activation context was already set.</para>
        /// </summary>
        public const int ERROR_SXS_PROCESS_DEFAULT_ALREADY_SET = 14011;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_UNKNOWN_ENCODING_GROUP</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The encoding group identifier specified is not recognized.</para>
        /// </summary>
        public const int ERROR_SXS_UNKNOWN_ENCODING_GROUP = 14012;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_UNKNOWN_ENCODING</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The encoding requested is not recognized.</para>
        /// </summary>
        public const int ERROR_SXS_UNKNOWN_ENCODING = 14013;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_INVALID_XML_NAMESPACE_URI</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The manifest contains a reference to an invalid URI.</para>
        /// </summary>
        public const int ERROR_SXS_INVALID_XML_NAMESPACE_URI = 14014;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_ROOT_MANIFEST_DEPENDENCY_NOT_INSTALLED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The application manifest contains a reference to a dependent assembly which is not installed</para>
        /// </summary>
        public const int ERROR_SXS_ROOT_MANIFEST_DEPENDENCY_NOT_INSTALLED = 14015;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_LEAF_MANIFEST_DEPENDENCY_NOT_INSTALLED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The manifest for an assembly used by the application has a reference to a dependent assembly which  is not installed</para>
        /// </summary>
        public const int ERROR_SXS_LEAF_MANIFEST_DEPENDENCY_NOT_INSTALLED = 14016;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_INVALID_ASSEMBLY_IDENTITY_ATTRIBUTE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The manifest contains an attribute for the assembly identity which is not valid.</para>
        /// </summary>
        public const int ERROR_SXS_INVALID_ASSEMBLY_IDENTITY_ATTRIBUTE = 14017;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_MANIFEST_MISSING_REQUIRED_DEFAULT_NAMESPACE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The manifest is missing the required default namespace specification on the assembly element.</para>
        /// </summary>
        public const int ERROR_SXS_MANIFEST_MISSING_REQUIRED_DEFAULT_NAMESPACE = 14018;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_MANIFEST_INVALID_REQUIRED_DEFAULT_NAMESPACE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The manifest has a default namespace specified on the assembly element but its value is not  "urn:schemas-microsoft-com:asm.v1".</para>
        /// </summary>
        public const int ERROR_SXS_MANIFEST_INVALID_REQUIRED_DEFAULT_NAMESPACE = 14019;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_PRIVATE_MANIFEST_CROSS_PATH_WITH_REPARSE_POINT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The private manifest probed has crossed reparse-point-associated path</para>
        /// </summary>
        public const int ERROR_SXS_PRIVATE_MANIFEST_CROSS_PATH_WITH_REPARSE_POINT = 14020;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_DUPLICATE_DLL_NAME</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Two or more components referenced directly or indirectly by the application manifest have files by  the same name.</para>
        /// </summary>
        public const int ERROR_SXS_DUPLICATE_DLL_NAME = 14021;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_DUPLICATE_WINDOWCLASS_NAME</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Two or more components referenced directly or indirectly by the application manifest have window  classes with the same name.</para>
        /// </summary>
        public const int ERROR_SXS_DUPLICATE_WINDOWCLASS_NAME = 14022;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_DUPLICATE_CLSID</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Two or more components referenced directly or indirectly by the application manifest have the same  COM server CLSIDs.</para>
        /// </summary>
        public const int ERROR_SXS_DUPLICATE_CLSID = 14023;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_DUPLICATE_IID</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Two or more components referenced directly or indirectly by the application manifest have proxies  for the same COM interface IIDs.</para>
        /// </summary>
        public const int ERROR_SXS_DUPLICATE_IID = 14024;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_DUPLICATE_TLBID</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Two or more components referenced directly or indirectly by the application manifest have the same  COM type library TLBIDs.</para>
        /// </summary>
        public const int ERROR_SXS_DUPLICATE_TLBID = 14025;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_DUPLICATE_PROGID</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Two or more components referenced directly or indirectly by the application manifest have the same  COM ProgIDs.</para>
        /// </summary>
        public const int ERROR_SXS_DUPLICATE_PROGID = 14026;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_DUPLICATE_ASSEMBLY_NAME</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Two or more components referenced directly or indirectly by the application manifest are different  versions of the same component which is not permitted.</para>
        /// </summary>
        public const int ERROR_SXS_DUPLICATE_ASSEMBLY_NAME = 14027;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_FILE_HASH_MISMATCH</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  A component's file does not match the verification information present in the</para>
        /// <para>//  component manifest.</para>
        /// </summary>
        public const int ERROR_SXS_FILE_HASH_MISMATCH = 14028;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_POLICY_PARSE_ERROR</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The policy manifest contains one or more syntax errors.</para>
        /// </summary>
        public const int ERROR_SXS_POLICY_PARSE_ERROR = 14029;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_XML_E_MISSINGQUOTE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Manifest Parse Error : A string literal was expected, but no opening quote character was found.</para>
        /// </summary>
        public const int ERROR_SXS_XML_E_MISSINGQUOTE = 14030;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_XML_E_COMMENTSYNTAX</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Manifest Parse Error : Incorrect syntax was used in a comment.</para>
        /// </summary>
        public const int ERROR_SXS_XML_E_COMMENTSYNTAX = 14031;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_XML_E_BADSTARTNAMECHAR</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Manifest Parse Error : A name was started with an invalid character.</para>
        /// </summary>
        public const int ERROR_SXS_XML_E_BADSTARTNAMECHAR = 14032;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_XML_E_BADNAMECHAR</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Manifest Parse Error : A name contained an invalid character.</para>
        /// </summary>
        public const int ERROR_SXS_XML_E_BADNAMECHAR = 14033;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_XML_E_BADCHARINSTRING</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Manifest Parse Error : A string literal contained an invalid character.</para>
        /// </summary>
        public const int ERROR_SXS_XML_E_BADCHARINSTRING = 14034;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_XML_E_XMLDECLSYNTAX</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Manifest Parse Error : Invalid syntax for an xml declaration.</para>
        /// </summary>
        public const int ERROR_SXS_XML_E_XMLDECLSYNTAX = 14035;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_XML_E_BADCHARDATA</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Manifest Parse Error : An Invalid character was found in text content.</para>
        /// </summary>
        public const int ERROR_SXS_XML_E_BADCHARDATA = 14036;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_XML_E_MISSINGWHITESPACE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Manifest Parse Error : Required white space was missing.</para>
        /// </summary>
        public const int ERROR_SXS_XML_E_MISSINGWHITESPACE = 14037;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_XML_E_EXPECTINGTAGEND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Manifest Parse Error : The character '>' was expected.</para>
        /// </summary>
        public const int ERROR_SXS_XML_E_EXPECTINGTAGEND = 14038;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_XML_E_MISSINGSEMICOLON</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Manifest Parse Error : A semi colon character was expected.</para>
        /// </summary>
        public const int ERROR_SXS_XML_E_MISSINGSEMICOLON = 14039;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_XML_E_UNBALANCEDPAREN</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Manifest Parse Error : Unbalanced parentheses.</para>
        /// </summary>
        public const int ERROR_SXS_XML_E_UNBALANCEDPAREN = 14040;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_XML_E_INTERNALERROR</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Manifest Parse Error : Internal error.</para>
        /// </summary>
        public const int ERROR_SXS_XML_E_INTERNALERROR = 14041;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_XML_E_UNEXPECTED_WHITESPACE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Manifest Parse Error : Whitespace is not allowed at this location.</para>
        /// </summary>
        public const int ERROR_SXS_XML_E_UNEXPECTED_WHITESPACE = 14042;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_XML_E_INCOMPLETE_ENCODING</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Manifest Parse Error : End of file reached in invalid state for current encoding.</para>
        /// </summary>
        public const int ERROR_SXS_XML_E_INCOMPLETE_ENCODING = 14043;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_XML_E_MISSING_PAREN</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Manifest Parse Error : Missing parenthesis.</para>
        /// </summary>
        public const int ERROR_SXS_XML_E_MISSING_PAREN = 14044;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_XML_E_EXPECTINGCLOSEQUOTE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Manifest Parse Error : A single or double closing quote character (\' or \") is missing.</para>
        /// </summary>
        public const int ERROR_SXS_XML_E_EXPECTINGCLOSEQUOTE = 14045;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_XML_E_MULTIPLE_COLONS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Manifest Parse Error : Multiple colons are not allowed in a name.</para>
        /// </summary>
        public const int ERROR_SXS_XML_E_MULTIPLE_COLONS = 14046;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_XML_E_INVALID_DECIMAL</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Manifest Parse Error : Invalid character for decimal digit.</para>
        /// </summary>
        public const int ERROR_SXS_XML_E_INVALID_DECIMAL = 14047;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_XML_E_INVALID_HEXIDECIMAL</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Manifest Parse Error : Invalid character for hexidecimal digit.</para>
        /// </summary>
        public const int ERROR_SXS_XML_E_INVALID_HEXIDECIMAL = 14048;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_XML_E_INVALID_UNICODE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Manifest Parse Error : Invalid unicode character value for this platform.</para>
        /// </summary>
        public const int ERROR_SXS_XML_E_INVALID_UNICODE = 14049;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_XML_E_WHITESPACEORQUESTIONMARK</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Manifest Parse Error : Expecting whitespace or '?'.</para>
        /// </summary>
        public const int ERROR_SXS_XML_E_WHITESPACEORQUESTIONMARK = 14050;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_XML_E_UNEXPECTEDENDTAG</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Manifest Parse Error : End tag was not expected at this location.</para>
        /// </summary>
        public const int ERROR_SXS_XML_E_UNEXPECTEDENDTAG = 14051;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_XML_E_UNCLOSEDTAG</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Manifest Parse Error : The following tags were not closed: %1.</para>
        /// </summary>
        public const int ERROR_SXS_XML_E_UNCLOSEDTAG = 14052;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_XML_E_DUPLICATEATTRIBUTE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Manifest Parse Error : Duplicate attribute.</para>
        /// </summary>
        public const int ERROR_SXS_XML_E_DUPLICATEATTRIBUTE = 14053;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_XML_E_MULTIPLEROOTS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Manifest Parse Error : Only one top level element is allowed in an XML document.</para>
        /// </summary>
        public const int ERROR_SXS_XML_E_MULTIPLEROOTS = 14054;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_XML_E_INVALIDATROOTLEVEL</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Manifest Parse Error : Invalid at the top level of the document.</para>
        /// </summary>
        public const int ERROR_SXS_XML_E_INVALIDATROOTLEVEL = 14055;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_XML_E_BADXMLDECL</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Manifest Parse Error : Invalid xml declaration.</para>
        /// </summary>
        public const int ERROR_SXS_XML_E_BADXMLDECL = 14056;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_XML_E_MISSINGROOT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Manifest Parse Error : XML document must have a top level element.</para>
        /// </summary>
        public const int ERROR_SXS_XML_E_MISSINGROOT = 14057;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_XML_E_UNEXPECTEDEOF</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Manifest Parse Error : Unexpected end of file.</para>
        /// </summary>
        public const int ERROR_SXS_XML_E_UNEXPECTEDEOF = 14058;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_XML_E_BADPEREFINSUBSET</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Manifest Parse Error : Parameter entities cannot be used inside markup declarations in an internal  subset.</para>
        /// </summary>
        public const int ERROR_SXS_XML_E_BADPEREFINSUBSET = 14059;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_XML_E_UNCLOSEDSTARTTAG</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Manifest Parse Error : Element was not closed.</para>
        /// </summary>
        public const int ERROR_SXS_XML_E_UNCLOSEDSTARTTAG = 14060;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_XML_E_UNCLOSEDENDTAG</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Manifest Parse Error : End element was missing the character '>'.</para>
        /// </summary>
        public const int ERROR_SXS_XML_E_UNCLOSEDENDTAG = 14061;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_XML_E_UNCLOSEDSTRING</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Manifest Parse Error : A string literal was not closed.</para>
        /// </summary>
        public const int ERROR_SXS_XML_E_UNCLOSEDSTRING = 14062;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_XML_E_UNCLOSEDCOMMENT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Manifest Parse Error : A comment was not closed.</para>
        /// </summary>
        public const int ERROR_SXS_XML_E_UNCLOSEDCOMMENT = 14063;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_XML_E_UNCLOSEDDECL</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Manifest Parse Error : A declaration was not closed.</para>
        /// </summary>
        public const int ERROR_SXS_XML_E_UNCLOSEDDECL = 14064;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_XML_E_UNCLOSEDCDATA</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Manifest Parse Error : A CDATA section was not closed.</para>
        /// </summary>
        public const int ERROR_SXS_XML_E_UNCLOSEDCDATA = 14065;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_XML_E_RESERVEDNAMESPACE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Manifest Parse Error : The namespace prefix is not allowed to start with the reserved string  "xml".</para>
        /// </summary>
        public const int ERROR_SXS_XML_E_RESERVEDNAMESPACE = 14066;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_XML_E_INVALIDENCODING</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Manifest Parse Error : System does not support the specified encoding.</para>
        /// </summary>
        public const int ERROR_SXS_XML_E_INVALIDENCODING = 14067;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_XML_E_INVALIDSWITCH</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Manifest Parse Error : Switch from current encoding to specified encoding not supported.</para>
        /// </summary>
        public const int ERROR_SXS_XML_E_INVALIDSWITCH = 14068;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_XML_E_BADXMLCASE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Manifest Parse Error : The name 'xml' is reserved and must be lower case.</para>
        /// </summary>
        public const int ERROR_SXS_XML_E_BADXMLCASE = 14069;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_XML_E_INVALID_STANDALONE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Manifest Parse Error : The standalone attribute must have the value 'yes' or 'no'.</para>
        /// </summary>
        public const int ERROR_SXS_XML_E_INVALID_STANDALONE = 14070;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_XML_E_UNEXPECTED_STANDALONE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Manifest Parse Error : The standalone attribute cannot be used in external entities.</para>
        /// </summary>
        public const int ERROR_SXS_XML_E_UNEXPECTED_STANDALONE = 14071;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_XML_E_INVALID_VERSION</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Manifest Parse Error : Invalid version number.</para>
        /// </summary>
        public const int ERROR_SXS_XML_E_INVALID_VERSION = 14072;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_XML_E_MISSINGEQUALS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Manifest Parse Error : Missing equals sign between attribute and attribute value.</para>
        /// </summary>
        public const int ERROR_SXS_XML_E_MISSINGEQUALS = 14073;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_PROTECTION_RECOVERY_FAILED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Assembly Protection Error : Unable to recover the specified assembly.</para>
        /// </summary>
        public const int ERROR_SXS_PROTECTION_RECOVERY_FAILED = 14074;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_PROTECTION_PUBLIC_KEY_TOO_SHORT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Assembly Protection Error : The public key for an assembly was too short to be allowed.</para>
        /// </summary>
        public const int ERROR_SXS_PROTECTION_PUBLIC_KEY_TOO_SHORT = 14075;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_PROTECTION_CATALOG_NOT_VALID</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Assembly Protection Error : The catalog for an assembly is not valid, or does not match the  assembly's manifest.</para>
        /// </summary>
        public const int ERROR_SXS_PROTECTION_CATALOG_NOT_VALID = 14076;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_UNTRANSLATABLE_HRESULT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  An HRESULT could not be translated to a corresponding Win32 error code.</para>
        /// </summary>
        public const int ERROR_SXS_UNTRANSLATABLE_HRESULT = 14077;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_PROTECTION_CATALOG_FILE_MISSING</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Assembly Protection Error : The catalog for an assembly is missing.</para>
        /// </summary>
        public const int ERROR_SXS_PROTECTION_CATALOG_FILE_MISSING = 14078;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_MISSING_ASSEMBLY_IDENTITY_ATTRIBUTE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The supplied assembly identity is missing one or more attributes which must be present in this  context.</para>
        /// </summary>
        public const int ERROR_SXS_MISSING_ASSEMBLY_IDENTITY_ATTRIBUTE = 14079;

        /// <summary>
        /// <para>// MessageId: ERROR_SXS_INVALID_ASSEMBLY_IDENTITY_ATTRIBUTE_NAME</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The supplied assembly identity has one or more attribute names that contain characters not  permitted in XML names.</para>
        /// </summary>
        public const int ERROR_SXS_INVALID_ASSEMBLY_IDENTITY_ATTRIBUTE_NAME = 14080;


        ///////////////////////////////////////////////////
        //                                               //
        //           End of Side By Side Error Codes     //
        //                                               //
        //                 14000 to 14999                //
        ///////////////////////////////////////////////////



        ///////////////////////////////////////////////////
        //                                               //
        //           Start of IPSec Error codes          //
        //                                               //
        //                 13000 to 13999                //
        ///////////////////////////////////////////////////


        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_QM_POLICY_EXISTS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified quick mode policy already exists.</para>
        /// </summary>
        public const int ERROR_IPSEC_QM_POLICY_EXISTS = 13000;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_QM_POLICY_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified quick mode policy was not found.</para>
        /// </summary>
        public const int ERROR_IPSEC_QM_POLICY_NOT_FOUND = 13001;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_QM_POLICY_IN_USE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified quick mode policy is being used.</para>
        /// </summary>
        public const int ERROR_IPSEC_QM_POLICY_IN_USE = 13002;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_MM_POLICY_EXISTS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified main mode policy already exists.</para>
        /// </summary>
        public const int ERROR_IPSEC_MM_POLICY_EXISTS = 13003;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_MM_POLICY_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified main mode policy was not found</para>
        /// </summary>
        public const int ERROR_IPSEC_MM_POLICY_NOT_FOUND = 13004;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_MM_POLICY_IN_USE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified main mode policy is being used.</para>
        /// </summary>
        public const int ERROR_IPSEC_MM_POLICY_IN_USE = 13005;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_MM_FILTER_EXISTS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified main mode filter already exists.</para>
        /// </summary>
        public const int ERROR_IPSEC_MM_FILTER_EXISTS = 13006;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_MM_FILTER_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified main mode filter was not found.</para>
        /// </summary>
        public const int ERROR_IPSEC_MM_FILTER_NOT_FOUND = 13007;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_TRANSPORT_FILTER_EXISTS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified transport mode filter already exists.</para>
        /// </summary>
        public const int ERROR_IPSEC_TRANSPORT_FILTER_EXISTS = 13008;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_TRANSPORT_FILTER_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified transport mode filter does not exist.</para>
        /// </summary>
        public const int ERROR_IPSEC_TRANSPORT_FILTER_NOT_FOUND = 13009;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_MM_AUTH_EXISTS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified main mode authentication list exists.</para>
        /// </summary>
        public const int ERROR_IPSEC_MM_AUTH_EXISTS = 13010;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_MM_AUTH_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified main mode authentication list was not found.</para>
        /// </summary>
        public const int ERROR_IPSEC_MM_AUTH_NOT_FOUND = 13011;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_MM_AUTH_IN_USE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified quick mode policy is being used.</para>
        /// </summary>
        public const int ERROR_IPSEC_MM_AUTH_IN_USE = 13012;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_DEFAULT_MM_POLICY_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified main mode policy was not found.</para>
        /// </summary>
        public const int ERROR_IPSEC_DEFAULT_MM_POLICY_NOT_FOUND = 13013;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_DEFAULT_MM_AUTH_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The specified quick mode policy was not found</para>
        /// </summary>
        public const int ERROR_IPSEC_DEFAULT_MM_AUTH_NOT_FOUND = 13014;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_DEFAULT_QM_POLICY_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The manifest file contains one or more syntax errors.</para>
        /// </summary>
        public const int ERROR_IPSEC_DEFAULT_QM_POLICY_NOT_FOUND = 13015;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_TUNNEL_FILTER_EXISTS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The application attempted to activate a disabled activation context.</para>
        /// </summary>
        public const int ERROR_IPSEC_TUNNEL_FILTER_EXISTS = 13016;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_TUNNEL_FILTER_NOT_FOUND</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The requested lookup key was not found in any active activation context.</para>
        /// </summary>
        public const int ERROR_IPSEC_TUNNEL_FILTER_NOT_FOUND = 13017;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_MM_FILTER_PENDING_DELETION</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The Main Mode filter is pending deletion.</para>
        /// </summary>
        public const int ERROR_IPSEC_MM_FILTER_PENDING_DELETION = 13018;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_TRANSPORT_FILTER_PENDING_DELETION</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The transport filter is pending deletion.</para>
        /// </summary>
        public const int ERROR_IPSEC_TRANSPORT_FILTER_PENDING_DELETION = 13019;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_TUNNEL_FILTER_PENDING_DELETION</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The tunnel filter is pending deletion.</para>
        /// </summary>
        public const int ERROR_IPSEC_TUNNEL_FILTER_PENDING_DELETION = 13020;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_MM_POLICY_PENDING_DELETION</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The Main Mode policy is pending deletion.</para>
        /// </summary>
        public const int ERROR_IPSEC_MM_POLICY_PENDING_DELETION = 13021;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_MM_AUTH_PENDING_DELETION</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The Main Mode authentication bundle is pending deletion.</para>
        /// </summary>
        public const int ERROR_IPSEC_MM_AUTH_PENDING_DELETION = 13022;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_QM_POLICY_PENDING_DELETION</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The Quick Mode policy is pending deletion.</para>
        /// </summary>
        public const int ERROR_IPSEC_QM_POLICY_PENDING_DELETION = 13023;

        /// <summary>
        /// <para>// MessageId: WARNING_IPSEC_MM_POLICY_PRUNED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The Main Mode policy was successfully added, but some of the requested offers are not supported.</para>
        /// </summary>
        public const int WARNING_IPSEC_MM_POLICY_PRUNED = 13024;

        /// <summary>
        /// <para>// MessageId: WARNING_IPSEC_QM_POLICY_PRUNED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The Quick Mode policy was successfully added, but some of the requested offers are not supported.</para>
        /// </summary>
        public const int WARNING_IPSEC_QM_POLICY_PRUNED = 13025;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_NEG_STATUS_BEGIN</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  ERROR_IPSEC_IKE_NEG_STATUS_BEGIN</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_NEG_STATUS_BEGIN = 13800;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_AUTH_FAIL</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  IKE authentication credentials are unacceptable</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_AUTH_FAIL = 13801;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_ATTRIB_FAIL</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  IKE security attributes are unacceptable</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_ATTRIB_FAIL = 13802;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_NEGOTIATION_PENDING</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  IKE Negotiation in progress</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_NEGOTIATION_PENDING = 13803;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_GENERAL_PROCESSING_ERROR</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  General processing error</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_GENERAL_PROCESSING_ERROR = 13804;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_TIMED_OUT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Negotiation timed out</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_TIMED_OUT = 13805;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_NO_CERT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  IKE failed to find valid machine certificate</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_NO_CERT = 13806;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_SA_DELETED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  IKE SA deleted by peer before establishment completed</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_SA_DELETED = 13807;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_SA_REAPED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  IKE SA deleted before establishment completed</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_SA_REAPED = 13808;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_MM_ACQUIRE_DROP</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Negotiation request sat in Queue too long</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_MM_ACQUIRE_DROP = 13809;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_QM_ACQUIRE_DROP</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Negotiation request sat in Queue too long</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_QM_ACQUIRE_DROP = 13810;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_QUEUE_DROP_MM</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Negotiation request sat in Queue too long</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_QUEUE_DROP_MM = 13811;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_QUEUE_DROP_NO_MM</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Negotiation request sat in Queue too long</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_QUEUE_DROP_NO_MM = 13812;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_DROP_NO_RESPONSE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  No response from peer</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_DROP_NO_RESPONSE = 13813;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_MM_DELAY_DROP</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Negotiation took too long</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_MM_DELAY_DROP = 13814;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_QM_DELAY_DROP</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Negotiation took too long</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_QM_DELAY_DROP = 13815;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_ERROR</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Unknown error occurred</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_ERROR = 13816;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_CRL_FAILED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Certificate Revocation Check failed</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_CRL_FAILED = 13817;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_INVALID_KEY_USAGE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Invalid certificate key usage</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_INVALID_KEY_USAGE = 13818;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_INVALID_CERT_TYPE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Invalid certificate type</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_INVALID_CERT_TYPE = 13819;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_NO_PRIVATE_KEY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  No private key associated with machine certificate</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_NO_PRIVATE_KEY = 13820;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_DH_FAIL</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Failure in Diffie-Helman computation</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_DH_FAIL = 13822;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_INVALID_HEADER</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Invalid header</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_INVALID_HEADER = 13824;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_NO_POLICY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  No policy configured</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_NO_POLICY = 13825;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_INVALID_SIGNATURE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Failed to verify signature</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_INVALID_SIGNATURE = 13826;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_KERBEROS_ERROR</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Failed to authenticate using kerberos</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_KERBEROS_ERROR = 13827;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_NO_PUBLIC_KEY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Peer's certificate did not have a public key</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_NO_PUBLIC_KEY = 13828;

        /// <summary>
        /// <para>// These must stay as a unit.</para>
        /// <para>//</para>
        /// <para>// MessageId: ERROR_IPSEC_IKE_PROCESS_ERR</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Error processing error payload</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_PROCESS_ERR = 13829;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_PROCESS_ERR_SA</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Error processing SA payload</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_PROCESS_ERR_SA = 13830;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_PROCESS_ERR_PROP</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Error processing Proposal payload</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_PROCESS_ERR_PROP = 13831;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_PROCESS_ERR_TRANS</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Error processing Transform payload</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_PROCESS_ERR_TRANS = 13832;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_PROCESS_ERR_KE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Error processing KE payload</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_PROCESS_ERR_KE = 13833;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_PROCESS_ERR_ID</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Error processing ID payload</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_PROCESS_ERR_ID = 13834;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_PROCESS_ERR_CERT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Error processing Cert payload</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_PROCESS_ERR_CERT = 13835;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_PROCESS_ERR_CERT_REQ</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Error processing Certificate Request payload</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_PROCESS_ERR_CERT_REQ = 13836;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_PROCESS_ERR_HASH</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Error processing Hash payload</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_PROCESS_ERR_HASH = 13837;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_PROCESS_ERR_SIG</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Error processing Signature payload</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_PROCESS_ERR_SIG = 13838;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_PROCESS_ERR_NONCE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Error processing Nonce payload</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_PROCESS_ERR_NONCE = 13839;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_PROCESS_ERR_NOTIFY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Error processing Notify payload</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_PROCESS_ERR_NOTIFY = 13840;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_PROCESS_ERR_DELETE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Error processing Delete Payload</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_PROCESS_ERR_DELETE = 13841;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_PROCESS_ERR_VENDOR</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Error processing VendorId payload</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_PROCESS_ERR_VENDOR = 13842;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_INVALID_PAYLOAD</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Invalid payload received</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_INVALID_PAYLOAD = 13843;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_LOAD_SOFT_SA</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Soft SA loaded</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_LOAD_SOFT_SA = 13844;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_SOFT_SA_TORN_DOWN</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Soft SA torn down</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_SOFT_SA_TORN_DOWN = 13845;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_INVALID_COOKIE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Invalid cookie received.</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_INVALID_COOKIE = 13846;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_NO_PEER_CERT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Peer failed to send valid machine certificate</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_NO_PEER_CERT = 13847;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_PEER_CRL_FAILED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Certification Revocation check of peer's certificate failed</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_PEER_CRL_FAILED = 13848;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_POLICY_CHANGE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  New policy invalidated SAs formed with old policy</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_POLICY_CHANGE = 13849;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_NO_MM_POLICY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  There is no available Main Mode IKE policy.</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_NO_MM_POLICY = 13850;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_NOTCBPRIV</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Failed to enabled TCB privilege.</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_NOTCBPRIV = 13851;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_SECLOADFAIL</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Failed to load SECURITY.DLL.</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_SECLOADFAIL = 13852;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_FAILSSPINIT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Failed to obtain security function table dispatch address from SSPI.</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_FAILSSPINIT = 13853;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_FAILQUERYSSP</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Failed to query Kerberos package to obtain max token size.</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_FAILQUERYSSP = 13854;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_SRVACQFAIL</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Failed to obtain Kerberos server credentials for ISAKMP/ERROR_IPSEC_IKE service.  Kerberos  authentication will not function.  The most likely reason for this is lack of domain membership.  This  is normal if your computer is a member of a workgroup.</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_SRVACQFAIL = 13855;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_SRVQUERYCRED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Failed to determine SSPI principal name for ISAKMP/ERROR_IPSEC_IKE service  (QueryCredentialsAttributes).</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_SRVQUERYCRED = 13856;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_GETSPIFAIL</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Failed to obtain new SPI for the inbound SA from Ipsec driver.  The most common cause for this is  that the driver does not have the correct filter.  Check your policy to verify the filters.</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_GETSPIFAIL = 13857;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_INVALID_FILTER</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Given filter is invalid</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_INVALID_FILTER = 13858;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_OUT_OF_MEMORY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Memory allocation failed.</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_OUT_OF_MEMORY = 13859;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_ADD_UPDATE_KEY_FAILED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Failed to add Security Association to IPSec Driver.  The most common cause for this is if the IKE  negotiation took too long to complete.  If the problem persists, reduce the load on the faulting  machine.</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_ADD_UPDATE_KEY_FAILED = 13860;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_INVALID_POLICY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Invalid policy</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_INVALID_POLICY = 13861;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_UNKNOWN_DOI</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Invalid DOI</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_UNKNOWN_DOI = 13862;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_INVALID_SITUATION</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Invalid situation</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_INVALID_SITUATION = 13863;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_DH_FAILURE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Diffie-Hellman failure</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_DH_FAILURE = 13864;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_INVALID_GROUP</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Invalid Diffie-Hellman group</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_INVALID_GROUP = 13865;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_ENCRYPT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Error encrypting payload</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_ENCRYPT = 13866;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_DECRYPT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Error decrypting payload</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_DECRYPT = 13867;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_POLICY_MATCH</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Policy match error</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_POLICY_MATCH = 13868;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_UNSUPPORTED_ID</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Unsupported ID</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_UNSUPPORTED_ID = 13869;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_INVALID_HASH</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Hash verification failed</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_INVALID_HASH = 13870;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_INVALID_HASH_ALG</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Invalid hash algorithm</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_INVALID_HASH_ALG = 13871;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_INVALID_HASH_SIZE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Invalid hash size</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_INVALID_HASH_SIZE = 13872;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_INVALID_ENCRYPT_ALG</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Invalid encryption algorithm</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_INVALID_ENCRYPT_ALG = 13873;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_INVALID_AUTH_ALG</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Invalid authentication algorithm</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_INVALID_AUTH_ALG = 13874;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_INVALID_SIG</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Invalid certificate signature</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_INVALID_SIG = 13875;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_LOAD_FAILED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Load failed</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_LOAD_FAILED = 13876;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_RPC_DELETE</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Deleted via RPC call</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_RPC_DELETE = 13877;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_BENIGN_REINIT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Temporary state created to perform reinit. This is not a real failure.</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_BENIGN_REINIT = 13878;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_INVALID_RESPONDER_LIFETIME_NOTIFY</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  The lifetime value received in the Responder Lifetime Notify is below the Windows 2000 configured  minimum value.  Please fix the policy on the peer machine.</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_INVALID_RESPONDER_LIFETIME_NOTIFY = 13879;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_INVALID_CERT_KEYLEN</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Key length in certificate is too small for configured security requirements.</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_INVALID_CERT_KEYLEN = 13881;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_MM_LIMIT</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  Max number of established MM SAs to peer exceeded.</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_MM_LIMIT = 13882;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_NEGOTIATION_DISABLED</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  IKE received a policy that disables negotiation.</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_NEGOTIATION_DISABLED = 13883;

        /// <summary>
        /// <para>// MessageId: ERROR_IPSEC_IKE_NEG_STATUS_END</para>
        /// <para>//</para>
        /// <para>// MessageText:</para>
        /// <para>//</para>
        /// <para>//  ERROR_IPSEC_IKE_NEG_STATUS_END</para>
        /// </summary>
        public const int ERROR_IPSEC_IKE_NEG_STATUS_END = 13884;
    }
}
