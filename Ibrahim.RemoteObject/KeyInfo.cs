using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ibrahim.RemoteObject
{
    public enum KEY_STATE
    {
        DOWN,
        UP
    }
    [Serializable]
    public class KeyInfo
    {
        public int Ascii { get; private set; }
        public string KeyName { get; private set; }
        public DateTime PressDate { get; private set; }
        public KEY_STATE KeyState { get; set; }

        public KeyInfo(int ascii,string key)
        {
            this.Ascii = ascii;
            this.KeyName = key;
            this.PressDate = DateTime.Now;
        }

        public KeyInfo(int ascii, string key,KEY_STATE state)
        {
            this.Ascii = ascii;
            this.KeyName = key;
            this.PressDate = DateTime.Now;
            this.KeyState = state;
        }
    }
}
