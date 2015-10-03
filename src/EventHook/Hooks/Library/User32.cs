﻿
using System;
using System.Text;
using System.Runtime.InteropServices;


namespace EventHook.Client.Utility.Hooks.Library
{
 

    class User32
    {
        [DllImport("user32.dll")]
        public static extern int GetForegroundWindow();
        [DllImport("user32.dll", SetLastError = true)]
        public static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);
        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern int GetWindowTextLength(IntPtr hWnd);
        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern int GetWindowText(IntPtr hWnd, [Out] StringBuilder lpString, int nMaxCount);

        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SetClipboardViewer(IntPtr hWnd);

        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern bool ChangeClipboardChain(
            IntPtr hWndRemove,  // handle to window to remove
            IntPtr hWndNewNext  // handle to next window
            );

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr lParam);

        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern bool EnumWindows(EnumWindowsProc numFunc, IntPtr lParam);

        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr GetParent(IntPtr hWnd);

        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr GetWindow(IntPtr hwnd, int uCmd);

        [DllImport("user32.dll", EntryPoint = "GetWindowLong", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll", EntryPoint = "GetWindowLongPtr", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern int GetWindowLongPtr(IntPtr hWnd, int nIndex);

        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern bool IsWindowVisible(IntPtr hwnd);

        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern bool RegisterShellHook(IntPtr hWnd, int flags);
        /// <summary>
        /// Registers a specified Shell window to receive certain messages for events or notifications that are useful to
        /// Shell applications. The event messages received are only those sent to the Shell window associated with the
        /// specified window's desktop. Many of the messages are the same as those that can be received after calling
        /// the SetWindowsHookEx function and specifying WH_SHELL for the hook type. The difference with
        /// RegisterShellHookWindow is that the messages are received through the specified window's WindowProc
        /// and not through a call back procedure. 
        /// </summary>
        /// <param name="hWnd">[in] Handle to the window to register for Shell hook messages.</param>
        /// <returns>TRUE if the function succeeds; FALSE if the function fails. </returns>
        /// <remarks>
        /// As with normal window messages, the second parameter of the window procedure identifies the
        /// message as a "WM_SHELLHOOKMESSAGE". However, for these Shell hook messages, the
        /// message value is not a pre-defined constant like other message identifiers (IDs) such as
        /// WM_COMMAND. The value must be obtained dynamically using a call to
        /// RegisterWindowMessage(TEXT("SHELLHOOK"));. This precludes handling these messages using
        /// a traditional switch statement which requires ID values that are known at compile time.
        /// For handling Shell hook messages, the normal practice is to code an If statement in the default
        /// section of your switch statement and then handle the message if the value of the message ID
        /// is the same as the value obtained from the RegisterWindowMessage call. 
        /// 
        /// for more see MSDN
        /// </remarks>
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern bool RegisterShellHookWindow(IntPtr hWnd);

        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern uint RegisterWindowMessage(string Message);

        [DllImport("user32.dll")]
        static public extern void SetTaskmanWindow(IntPtr hwnd);


    }
}