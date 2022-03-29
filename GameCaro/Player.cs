using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCaro
{
    public class Player
    {
        private string name;
        private Image mark;
        private Image avatar;

        public Image Avatar
        {
            get { return avatar; }
            set { avatar = value; }
        }

        public Image Mark
        {
            get { return mark; }
            set { mark = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Player(string name, Image mark, Image avatar) 
        {
            this.Name = name;
            this.Mark = mark;
            this.Avatar = avatar;
        }
    }
}
