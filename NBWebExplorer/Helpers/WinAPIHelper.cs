using System;
using System.Runtime.InteropServices;

namespace NBWebExplorer
{
    internal static class WinAPIHelper
    {
        [DllImport("User32.DLL")]
        internal static extern Int32 SendMessage(IntPtr hWnd, UInt32 Msg, Int32 wParam, Int32 lParam);
        [DllImport("User32.DLL")]
        internal static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, String lpszClass, String lpszWindow);

        private const UInt32 WM_COMMAND = 0x0111;

        private static String[] handleWindowNames = new String[3]
        {
                "Shell Embedding",
                "Shell DocObject View",
                "Internet Explorer_Server"
        };

        internal static void InvokeCommandByMessage(Int32 wID, Int32 nID, WebBrowserTabPage webBrowserTabPage)
        {
            IntPtr webBrowserServerPtr = webBrowserTabPage.Browser.Handle;

            for (Int32 i = 0; i <= wID; i++)
            {
                webBrowserServerPtr = FindWindowEx(webBrowserServerPtr, IntPtr.Zero, handleWindowNames[i], null);
            }

            SendMessage(webBrowserServerPtr, WM_COMMAND, nID, (Int32)webBrowserTabPage.Parent.Handle);
        }

        internal static class Messages
        {
            // Get from shdoclc.dll

            // Internet Explorer_Server

            /// <summary>
            /// Add to Favorites. Invoked by Internet Explorer_Server.
            /// </summary>
            internal const Int32 ID_IE_CONTEXTMENU_ADDFAV = 2261;
            /// <summary>
            /// View Source. Invoked by Internet Explorer_Server.
            /// </summary>
            internal const Int32 ID_IE_CONTEXTMENU_VIEWSOURCE = 2139;

            /// <summary>
            /// Open Find Dialog. Invoked by Internet Explorer_Server.
            /// </summary>
            internal const Int32 ID_IE_EDIT_FIND = 67;

            /// <summary>
            /// Open Internet Options Dialog. Invoked by Internet Explorer_Server.
            /// </summary>
            internal const Int32 ID_IE_VIEW_OPTIONS = 2135;

            // Shell DocObject View

            /// <summary>
            /// New E-Mail. Invoked by Shell DocObject View.
            /// </summary>
            internal const Int32 ID_IE_FILE_NEWMAIL = 279;

            /// <summary>
            /// Send the Page Link to Desktop. Invoked by Shell DocObject View.
            /// </summary>
            internal const Int32 ID_IE_FILE_SENDDESKTOPSHORTCUT = 284;

            /// <summary>
            /// Open Import / Export Dialog. Invoked by Shell DocObject View.
            /// </summary>
            internal const Int32 ID_IE_FILE_IMPORTEXPORT = 374;

            /// <summary>
            /// Open About Internet Explorer Dialog. Invoked by Shell DocObject View.
            /// </summary>
            internal const Int32 ID_IE_HELP_ABOUTIE = 336;

            // Call About IE dialog:
            // Helper.Win32Interop.InvokeCommandByMessage(1, Helper.Win32Interop.Messages.ID_IE_HELP_ABOUTIE, _webBrowserTabPage);
        }
    }
}