using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AutoClick
{
    internal class KeyboardState
    {
        [DllImport("user32")]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        private static extern IntPtr GetWindowThreadProcessId(IntPtr hWnd, out IntPtr lpdwProcessId);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr IParam);

        [DllImport("imm32.dll")]
        private static extern IntPtr ImmGetDefaultIMEWnd(IntPtr hWnd);


        private const int WM_IME_CONTROL = 643;

        private static IntPtr getCurrentHandle()
        {
            IntPtr himc = GetForegroundWindow();

            IntPtr activeAppProcessId;
            GetWindowThreadProcessId(himc, out activeAppProcessId);

            Process currentAppProcess = Process.GetProcessById((int)activeAppProcessId);
            IntPtr hwnd = currentAppProcess.MainWindowHandle;

            return hwnd;
        }

        private static IntPtr getCurrentIME()
        {
            return ImmGetDefaultIMEWnd(getCurrentHandle());
        }

        public static bool isEnglish()
        {
            IntPtr hime = getCurrentIME();
            IntPtr status = SendMessage(hime, WM_IME_CONTROL, new IntPtr(0x5), new IntPtr(0));

            return status.ToInt32() == 0;
        }

        public static void changeIME()
        {
            KeyboardEvent.press(0x15);
        }
    }
}
