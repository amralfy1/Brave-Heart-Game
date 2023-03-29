using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project
{
    abstract class soldier
    {
        int attack;
        int hp;
        int level;
        bool attacktype;
        int mananeed;
        int coidneed;

        public bool Attacktype
        {
            get { return attacktype; }
            set { attacktype = value; }
        }
        public int Attack
        {
            get { return attack; }
            set { attack = value; }
        }
        public int Hp
        {
            get { return hp; }
            set { hp = value; }
        }
        public int Level
        {
            get { return level; }
            set { level = value; }
        }
        public int Mananeed
        {
            get { return mananeed; }
            set { mananeed = value; }
        }

        public int Coidneed
        {
            get { return coidneed; }
            set { coidneed = value; }
        }

        abstract public void levelup();
    }   
}
