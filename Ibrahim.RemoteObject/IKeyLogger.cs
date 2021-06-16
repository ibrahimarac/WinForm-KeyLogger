using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ibrahim.RemoteObject
{
    public enum MouseEventType
    {
        LeftDown,LeftUp,RightDown,RightUp,Move
    }
    public interface IKeyLogger
    {
        void Start();
        void Stop();
        KeyInfo GetLastKey();

        void SetHookedKeys(int[] keys);

        Size GetRemoteScreenSize();

        byte[] GetScreenImage();

        void SendMouseEvent(MouseEventType eventType, uint x, uint y);

        void SendMovePosition(Point movePoint);
    }
}
