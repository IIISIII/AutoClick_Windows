using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoClick
{
    internal class KeyGroup
    {
        private List<byte> keyList = new List<byte>();

        public void addKey(byte key)
        {
            this.keyList.Add(key);
        }

        public List<byte> getKeyList()
        { 
            return this.keyList;
        }
    }
}
