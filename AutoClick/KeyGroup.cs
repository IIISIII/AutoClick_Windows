using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoClick
{
    internal class KeyGroup
    {
        private bool IsPlainText = false;

        private string display = "";

        private List<byte> keyList = new List<byte>();


        public void setPlainText(string plainText)
        {
            this.IsPlainText = true;
            this.display = plainText;
        }

        public bool isPlainText()
        {
            return this.IsPlainText;
        }

        public void addKey(byte key)
        {
            this.keyList.Add(key);
        }

        public List<byte> getKeyList()
        { 
            return this.keyList;
        }

        public void setDisplay(string display)
        {
            this.display = display;
        }

        public string getDisplay()
        {
            return this.display;
        }

        public static String toString(List<KeyGroup> list)
        {
            string str = "";

            if(list.Count > 0)
            {
                str += list[0].getDisplay();
                for(int i = 1; i < list.Count; i++)
                {
                    str += ", " + list[i].getDisplay();
                }
            }
            return str;
        }
    }
}
