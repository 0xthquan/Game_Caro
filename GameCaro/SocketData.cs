using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCaro
{
    [Serializable]
    public class SocketData
    {
        private int command;

        public int Command
        {
            get { return command; }
            set { command = value; }
        }

        private Point point;

        public Point Point
        {
            get { return point; }
            set { point = value; }
        }

        public SocketData(int command, Point point)
        {
            this.Command = command;
            this.Point = point;
        }
    }

    public enum SocketCommand
    {
        SEND_POINT,
        NEW_GAME,
        UNDO,
        QUIT,
    }
}
