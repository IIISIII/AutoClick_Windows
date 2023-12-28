using System.Runtime.InteropServices;

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
                NewTypingMessage(keyGroup.getDisplay());
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

        static void NewTypingMessage(string message)
        {
            SendKeys.SendWait(message);
        }
    }
}
