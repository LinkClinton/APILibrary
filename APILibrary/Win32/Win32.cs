using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace APILibrary.Win32
{
    public static class Internal
    {
        const string User32 = "user32.dll";
        const string Gdi32 = "gdi32.dll";

        public delegate IntPtr WndProc(IntPtr Hwnd, uint message,
           IntPtr wParam, IntPtr lParam);

        [DllImport(User32)]
        public static extern int GetSystemMetrics(int nIndex);

        [DllImport(User32, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr DefWindowProc(IntPtr Hwnd, uint message,
            IntPtr wParam, IntPtr lParam);

        [DllImport(User32)]
        public static extern IntPtr LoadCursor(IntPtr hlnstance, uint IpCursorName);

        [DllImport(User32, CharSet = CharSet.Auto, EntryPoint = "CreateWindowExW")]
        public static extern IntPtr CreateWindowEx(uint DdwExStyle, string lpClassName, string lpWindowName,
            uint dwStyle, int x, int y, int nWidth, int nHeight, IntPtr hWndParent, IntPtr hMenu,
            IntPtr hlnstance, IntPtr lpParam);

        [DllImport(User32)]
        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport(User32)]
        public static extern bool UpdateWindow(IntPtr hWnd);

        [DllImport(User32)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X,
            int Y, int cx, int cy, uint uFlags);

        [DllImport(User32)]
        public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewlong);

        [DllImport(User32)]
        public static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport(User32)]
        public static extern bool SetLayeredWindowAttributes(IntPtr hWnd, uint crKey,
            byte bAlpha, uint dwFlags);

        [DllImport(User32, EntryPoint = "RegisterClass")]
        public static extern ushort RegisterAppinfo(ref AppInfo appinfo);

        [DllImport(User32)]
        public static extern int SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr IParam);

        [DllImport(User32)]
        public static extern bool PeekMessage(out Message message, IntPtr hwnd,
          int wMSGfilterMin, int wMsgFilterMax, int wRemoveMsg);

        [DllImport(User32)]
        public static extern bool TranslateMessage(ref Message message);

        [DllImport(User32)]
        public static extern bool DispatchMessage(ref Message message);

        [DllImport(User32)]
        public static extern void PostQuitMessage(int exitCode);

        [DllImport(User32)]
        public static extern short GetKeyState(int keyCode);


        [DllImport(Gdi32)]
        public static extern IntPtr GetStockObject(int fnObject);
    }
}
