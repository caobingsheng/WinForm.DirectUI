namespace WinForm.DirectUI.Win32
{
    //SIO定义
    public static partial class NativeMethods
    {
        /// <summary>
        /// Associate this socket with the specified handle of a companion interface. The input buffer contains the integer value corresponding to the manifest constant for the companion interface (for example, TH_NETDEV and TH_TAPI.), followed by a value that is a handle of the specified companion interface, along with any other required information. Refer to the appropriate section in Winsock Annexes for details specific to a particular companion interface. The total size is reflected in the input buffer length. No output buffer is required. The WSAENOPROTOOPT error code is indicated for service providers that do not support this IOCTL. The handle associated by this IOCTL can be retrieved using SIO_TRANSLATE_HANDLE.A companion interface might be used, for example, if a particular provider provides (1) a great deal of additional controls over the behavior of a socket and (2) the controls are provider-specific enough that they do not map to existing Windows Socket functions or ones likely to be defined in the future. It is recommend that the Component Object Model (COM) be used instead of this IOCTL to discover and track other interfaces that might be supported by a socket. This IOCTL is present for (reverse) compatibility with systems where COM is not available or cannot be used for some other reason.
        /// </summary>
        public const int SIO_ASSOCIATE_HANDLE = (IOC_IN | IOC_WS2 | 1);
        /// <summary>
        /// Indicates to the underlying message-oriented service provider that a newly arrived message should never be dropped because of a buffer queue overflow. Instead, the oldest message in the queue should be eliminated in order to accommodate the newly arrived message. No input and output buffers are required. Note that this IOCTL is only valid for sockets associated with unreliable, message-oriented protocols. The WSAENOPROTOOPT error code is indicated for service providers that do not support this IOCTL.
        /// </summary>
        public const int SIO_ENABLE_CIRCULAR_QUEUEING = (IOC_VOID | IOC_WS2 | 2);
        /// <summary>
        /// When issued, this IOCTL requests that the route to the remote address specified as a sockaddr in the input buffer be discovered. If the address already exists in the local cache, its entry is invalidated. In the case of Novell's IPX, this call initiates an IPX GetLocalTarget (GLT), which queries the network for the given remote address.
        /// </summary>
        public const int SIO_FIND_ROUTE = (IOC_OUT | IOC_WS2 | 3);
        /// <summary>
        /// Discards current contents of the sending queue associated with this socket. No input and output buffers are required. The WSAENOPROTOOPT error code is indicated for service providers that do not support this IOCTL.
        /// </summary>
        public const int SIO_FLUSH = (IOC_VOID | IOC_WS2 | 4);
        /// <summary>
        /// This IOCTL fills the output buffer with a sockaddr structure containing a suitable broadcast address for use with sendto/ WSASendTo. Not supported for IPv6 sockets (returns WSAENOPROTOOPT).
        /// </summary>
        public const int SIO_GET_BROADCAST_ADDRESS = (IOC_OUT | IOC_WS2 | 5);
        /// <summary>
        /// Retrieve a pointer to the specified extension function supported by the associated service provider. The input buffer contains a globally unique identifier (GUID) whose value identifies the extension function in question. The pointer to the desired function is returned in the output buffer. Extension function identifiers are established by service provider vendors and should be included in vendor documentation that describes extension function capabilities and semantics.The GUID values for extension functions supported by the Windows TCP/IP service provider are defined in the Mswsock.h header file. The possible value for these GUIDs are as follows:
        /// </summary>
        public const int SIO_GET_EXTENSION_FUNCTION_POINTER = (IOC_INOUT | IOC_WS2 | 6);
        /// <summary>
        /// Reserved for future use with sockets. Retrieve the QOS structure associated with the socket. The input buffer is optional. Some protocols (for example, RSVP) allow the input buffer to be used to qualify a quality of service request. The QOS structure will be copied into the output buffer. The output buffer must be sized large enough to be able to contain the full QOS structure. The WSAENOPROTOOPT error code is indicated for service providers that do not support quality of service.A sender may not call SIO_GET_QOS until the socket is connected.A receiver may call SIO_GET_QOS as soon as it is bound.
        /// </summary>
        public const int SIO_GET_QOS = (IOC_INOUT | IOC_WS2 | 7);
        /// <summary>
        /// Reserved for future use with sockets.Retrieve the QOS structure associated with the socket group to which this socket belongs. The input buffer is optional. Some protocols (for example, RSVP) allow the input buffer to be used to qualify a quality of service request. The QOS structure will be copied into the output buffer. If this socket does not belong to an appropriate socket group, the SendingFlowspec and ReceivingFlowspec members of the returned QOS structure are set to NULL. The WSAENOPROTOOPT error code is indicated for service providers that do not support quality of service.
        /// </summary>
        public const int SIO_GET_GROUP_QOS = (IOC_INOUT | IOC_WS2 | 8);
        /// <summary>
        /// Controls whether data sent by an application on the local computer (not necessarily by the same socket) in a multicast session will be received by a socket joined to the multicast destination group on the loopback interface. A value of TRUE causes multicast data sent by an application on the local computer to be delivered to a listening socket on the loopback interface. A value of FALSE prevents multicast data sent by an application on the local computer from being delivered to a listening socket on the loopback interface. By default, IP_MULTICAST_LOOPBACK is enabled.
        /// </summary>
        public const int SIO_MULTIPOINT_LOOPBACK = (IOC_IN | IOC_WS2 | 9);
        /// <summary>
        /// Specifies the scope over which multicast transmissions will occur. Scope is defined as the number of routed network segments to be covered. A scope of zero would indicate that the multicast transmission would not be placed on the wire but could be disseminated across sockets within the local host. A scope value of one (the default) indicates that the transmission will be placed on the wire, but will not cross any routers. Higher scope values determine the number of routers that can be crossed. Note that this corresponds to the time-to-live (TTL) parameter in IP multicasting. By default, scope is 1.
        /// </summary>
        public const int SIO_MULTICAST_SCOPE = (IOC_IN | IOC_WS2 | 10);
        /// <summary>
        /// Associate the specified QOS structure with the socket. No output buffer is required, the QOS structure will be obtained from the input buffer. The WSAENOPROTOOPT error code is indicated for service providers that do not support quality of service.
        /// </summary>
        public const int SIO_SET_QOS = (IOC_IN | IOC_WS2 | 11);
        /// <summary>
        /// Reserved.
        /// </summary>                                                     
        public const int SIO_SET_GROUP_QOS = (IOC_IN | IOC_WS2 | 12);
        /// <summary>
        /// To obtain a corresponding handle for socket s that is valid in the context of a companion interface (for example, TH_NETDEV and TH_TAPI). A manifest constant identifying the companion interface along with any other needed parameters are specified in the input buffer. The corresponding handle will be available in the output buffer upon completion of this function. Refer to the appropriate section in Winsock Annexes for details specific to a particular companion interface. The WSAENOPROTOOPT error code is indicated for service providers that do not support this IOCTL for the specified companion interface. This IOCTL retrieves the handle associated using SIO_TRANSLATE_HANDLE.It is recommend that the Component Object Model (COM) be used instead of this IOCTL to discover and track other interfaces that might be supported by a socket. This IOCTL is present for backward compatibility with systems where COM is not available or cannot be used for some other reason.
        /// </summary>
        public const int SIO_TRANSLATE_HANDLE = (IOC_INOUT | IOC_WS2 | 13);
        /// <summary>
        /// To obtain the address of the local interface (represented as sockaddr structure) which should be used to send to the remote address specified in the input buffer (as sockaddr). Remote multicast addresses may be submitted in the input buffer to get the address of the preferred interface for multicast transmission. In any case, the interface address returned may be used by the application in a subsequent bind() request.Note that routes are subject to change. Therefore, applications cannot rely on the information returned by SIO_ROUTING_INTERFACE_QUERY to be persistent. Applications may register for routing change notifications through the SIO_ROUTING_INTERFACE_CHANGE IOCTL which provides for notification through either overlapped I/O or a FD_ROUTING_INTERFACE_CHANGE event. The following sequence of actions can be used to guarantee that the application always has current routing interface information for a given destination:Issue SIO_ROUTING_INTERFACE_CHANGE IOCTL Issue SIO_ROUTING_INTERFACE_QUERY IOCTL Whenever SIO_ROUTING_INTERFACE_CHANGE IOCTL notifies the application of routing change (either through overlapped I/O or by signaling FD_ROUTING_INTERFACE_CHANGE event), the whole sequence of actions should be repeated.If the output buffer is not large enough to contain the interface address, SOCKET_ERROR is returned as the result of this IOCTL and WSAGetLastError returns WSAEFAULT. The required size of the output buffer will be returned in lpcbBytesReturned in this case. Note the WSAEFAULT error code is also returned if the lpvInBuffer, lpvOutBuffer, or lpcbBytesReturned parameter is not totally contained in a valid part of the user address space.If the destination address specified in the input buffer cannot be reached through any of the available interfaces, SOCKET_ERROR is returned as the result of this IOCTL and WSAGetLastError returns WSAENETUNREACH or even WSAENETDOWN if all of the network connectivity is lost.
        /// </summary>
        public const int SIO_ROUTING_INTERFACE_QUERY = (IOC_INOUT | IOC_WS2 | 20);
        /// <summary>
        /// To receive notification of a routing interface change that should be used to reach the remote address in the input buffer (specified as a sockaddr structure). No output information on the new routing interface will be provided upon completion of this IOCTL; the completion merely indicates that the routing interface for a given destination has changed and should be queried using the SIO_ROUTING_INTERFACE_QUERY IOCTL.It is assumed (although not required) that the application uses overlapped I/O to be notified of the routing interface change through completion of SIO_ROUTING_INTERFACE_CHANGE request. Alternatively, if the SIO_ROUTING_INTERFACE_CHANGE IOCTL is issued on a non-blocking socket with the lpOverlapped and lpCompletionRoutine parameters set to NULL), it will complete immediately returning and WSAEWOULDBLOCK as an error, and the application can then wait for routing change events through call to WSAEventSelect or WSAAsyncSelect with FD_ROUTING_INTERFACE_CHANGE bit set in the network event bitmask.It is recognized that routing information remains stable in most cases so that requiring the application to keep multiple outstanding IOCTLs to get notifications about all destinations that it is interested in as well as having the service provider keep track of these notification requests will use a significant amount system resources. This situation can be avoided by extending the meaning of the input parameters and relaxing the service provider requirements as follows:The application can specify a protocol family specific wildcard address (same as one used in bind call when requesting to bind to any available address) to request notifications of any routing changes. This allows the application to keep only one outstanding SIO_ROUTING_INTERFACE_CHANGE for all the sockets and destinations it has and then use SIO_ROUTING_INTERFACE_QUERY to get the actual routing information.A service provider has the option to ignore the information specified by the application in the input buffer of the SIO_ROUTING_INTERFACE_CHANGE (as though the application specified a wildcard address) and complete the SIO_ROUTING_INTERFACE_CHANGE IOCTL or signal FD_ROUTING_INTERFACE_CHANGE event in the event of any routing information change (not just the route to the destination specified in the input buffer).
        /// </summary>
        public const int SIO_ROUTING_INTERFACE_CHANGE = (IOC_IN | IOC_WS2 | 21);
        /// <summary>
        /// Obtains a list of local transport addresses of the socket's protocol family to which the application can bind. The list of addresses varies based on address family and some addresses are excluded from the list.Note  In Windows Plug-n-Play environments, addresses can be added and removed dynamically. Therefore, applications cannot rely on the information returned by SIO_ADDRESS_LIST_QUERY to be persistent. Applications may register for address change notifications through the SIO_ADDRESS_LIST_CHANGE IOCTL which provides for notification through either overlapped I/O or FD_ADDRESS_LIST_CHANGE event. The following sequence of actions can be used to guarantee that the application always has current address list information:Issue SIO_ADDRESS_LIST_CHANGE IOCTL Issue SIO_ADDRESS_LIST_QUERY IOCTL Whenever SIO_ADDRESS_LIST_CHANGE IOCTL notifies the application of address list change (either through overlapped I/O or by signaling FD_ADDRESS_LIST_CHANGE event), the whole sequence of actions should be repeated.For more detailed information, see the SIO_ADDRESS_LIST_QUERY reference. SIO_ADDRESS_LIST_QUERY is supported on Windows 2000 and later.
        /// </summary>
        public const int SIO_ADDRESS_LIST_QUERY = (IOC_OUT | IOC_WS2 | 22);
        /// <summary>
        /// To receive notification of changes in the list of local transport addresses of the socket's protocol family to which the application can bind. No output information will be provided upon completion of this IOCTL; the completion merely indicates that list of available local address has changed and should be queried again through SIO_ADDRESS_LIST_QUERY.It is assumed (although not required) that the application uses overlapped I/O to be notified of change by completion of SIO_ADDRESS_LIST_CHANGE request. Alternatively, if the SIO_ADDRESS_LIST_CHANGE IOCTL is issued on a non-blocking socket and without overlapped parameters (lpOverlapped/ lpCompletionRoutine are set to NULL), it will complete immediately with error WSAEWOULDBLOCK. The application can then wait for address list change events through a call to WSAEventSelect or WSAAsyncSelect with FD_ADDRESS_LIST_CHANGE bit set in the network event bitmask.
        /// </summary>
        public const int SIO_ADDRESS_LIST_CHANGE = (IOC_VOID | IOC_WS2 | 23);
        /// <summary>
        /// SIO_QUERY_TARGET_PNP_HANDLE
        /// </summary>
        public const int SIO_QUERY_TARGET_PNP_HANDLE = (IOC_OUT | IOC_WS2 | 24);
        /// <summary>
        /// SIO_QUERY_RSS_PROCESSOR_INFO
        /// </summary>
        public const int SIO_QUERY_RSS_PROCESSOR_INFO = (IOC_OUT | IOC_WS2 | 37);

        /// <summary>
        /// SIO_ADDRESS_LIST_SORT
        /// </summary>
        public const int SIO_ADDRESS_LIST_SORT = (IOC_INOUT | IOC_WS2 | 25);

        /// <summary>
        /// SIO_RESERVED_1
        /// </summary>
        public const int SIO_RESERVED_1 = (IOC_IN | IOC_WS2 | 26);
        /// <summary>
        /// SIO_RESERVED_2
        /// </summary>
        public const int SIO_RESERVED_2 = (IOC_IN | IOC_WS2 | 33);

        /// <summary>
        /// SIO_GET_MULTIPLE_EXTENSION_FUNCTION_POINTER
        /// </summary>
        public const int SIO_GET_MULTIPLE_EXTENSION_FUNCTION_POINTER = (IOC_INOUT | IOC_WS2 | 36);
    }
}
