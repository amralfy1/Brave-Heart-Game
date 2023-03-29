using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project
{
    class warrior : soldier
    {
        public warrior()
        {
            Attack = 30;
            Level = 1;
            Attacktype = false;
            Hp = 100;
            Coidneed = 12;
            Mananeed = 15;
        }
        public override void levelup()
        {
            Level++;
            Hp += (int)(Hp * 1.2);
            Attack += (int)(Attack * 1.3);
            Coidneed += (int)(Coidneed * 1.5);
            Mananeed += (int)(Mananeed * 1.2);
        }
    }
}
