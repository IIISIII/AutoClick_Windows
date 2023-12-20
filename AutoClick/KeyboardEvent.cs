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

        [DllImport("user32.dll")]
        public static extern short VkKeyScan(char ch);

        const uint KEYEVENTF_KEYUP = 0x0002;
        const uint KEYEVENTF_EXTENDEDKEY = 0x0001;

        public static void press(KeyGroup keyGroup)
        {
            if(keyGroup.isPlainText())
            {
                //Console.WriteLine(keyGroup.getDisplay());
                NewTypingMessageFromCodePage(keyGroup.getDisplay());
            }
            else
            {
                List<byte> bytes = keyGroup.getKeyList();

                press(bytes);
            }
        }

        private static void press(List<byte> vKeys)
        {
            for (int i = 0; i < vKeys.Count; i++)
            {
                keybd_event(vKeys[i], 0, KEYEVENTF_EXTENDEDKEY | 0, 0);
            }
            for (int i = vKeys.Count - 1; i >= 0; i--)
            {
                keybd_event(vKeys[i], 0, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, 0);
            }
        }

        public static void press(byte vKey)
        {
            keybd_event(vKey, 0, KEYEVENTF_EXTENDEDKEY | 0, 0);
            keybd_event(vKey, 0, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, 0);
        }

        static void NewTypingMessageFromCodePage(string message, uint codePage = 0)
        {
            byte[] numCode = { 0x2D, 0x23, 0x28, 0x22, 0x25, 0x0C, 0x27, 0x24, 0x26, 0x21 };
            int length = message.Length;

            for (int i = 0; i < length; i++)
            {
                char currentChar = message[i];

                byte[] multiByte = Encoding.GetEncoding((int)codePage).GetBytes(currentChar.ToString());

                int wordCode = ((~multiByte[0] ^ 0xff) << 8) + (~multiByte[1] ^ 0xff);

                string wordCodeStr = wordCode.ToString();

                keybd_event((byte)0xA4, 0, KEYEVENTF_EXTENDEDKEY | 0, 0); // VK_MENU (Left Alt) down

                foreach (char digit in wordCodeStr)
                {
                    int numCodeIndex = digit - '0';
                    Console.WriteLine(numCodeIndex.ToString());
                    press(numCode[numCodeIndex]);
                }

                keybd_event((byte)0xA4, 0, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, 0); // VK_MENU (Left Alt) up
            }
        }
    }
}
