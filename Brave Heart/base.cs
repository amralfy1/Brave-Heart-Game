using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project
{
    class @base
    {
        private int hp;

        public int Hp
        {
            get { return hp; }
            set { hp = value; }
        }
        private int armor;

        public int Armor
        {
            get { return armor; }
            set { armor = value; }
        }
        private int level;

        public int Level
        {
            get { return level; }
            set { level = value; }
        }
        private int coin_needed;

        public int Coin_needed
        {
            get { return coin_needed; }
            set { coin_needed = value; }
        }
        public void level_up()
        {
        }
        public @base()
        {
            hp = 500;
            armor = 0;
            level = 1;
            coin_needed = 50;
        }
    }
}
