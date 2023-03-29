using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project
{
    class archer : soldier
    {
        public archer()
        {
            Hp = 300;
            Attack = 5;
            Coidneed = 30;
            Attacktype = false;
            Mananeed = 5;
            Level = 1;
        }
        override public void levelup()
        {
            Level++;
            Hp += (int)(Hp * 1.2);
            Attack += (int)(Attack * 1.3);
            Coidneed += (int)(Coidneed * 1.5);
            Mananeed += (int)(Mananeed * 1.4);
        }
    }
}