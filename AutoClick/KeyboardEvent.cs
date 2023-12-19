using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AutoClick
{
    internal class KeyboardEvent
    {
        [DllImport("user32.dll")]
        public static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, uint dwExtraInfo);

        const int VK_UP = 0x26; //up key
        const int VK_DOWN = 0x28;  //down key
        const int VK_LEFT = 0x25;
        const int VK_RIGHT = 0x27;
        const uint KEYEVENTF_KEYUP = 0x0002;
        const uint KEYEVENTF_EXTENDEDKEY = 0x0001;

        public static void press(KeyGroup keyGroup)
        {
            List<byte> bytes = keyGroup.getKeyList();

            for(int i = 0; i < bytes.Count; i ++)
            {
                Console.WriteLine(bytes[i].ToString());
                keybd_event(bytes[i], 0, KEYEVENTF_EXTENDEDKEY | 0, 0);
            }
            for(int i = bytes.Count - 1; i >= 0; i --)
            {
                keybd_event(bytes[i], 0, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, 0);
            }
        }
    }
}
