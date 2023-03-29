using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project
{
    class player
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int stamina;
        public int Stamina
        {
            get { return stamina; }
            set { stamina = value; }
        }

        private int coins;
        public int Coins
        {
            get { return coins; }
            set { coins = value; }
        }

        private int soldiers_capacity;
        public int Soldiers_capacity
        {
            get { return soldiers_capacity; }
            set { soldiers_capacity = value; }
        }
        public @base castle;
        public Dictionary<PictureBox, soldier> soldiers;
        public void increase_income()
        {
            coins += 10;
        }
        player(string name)
        {

            this.name = name;
            stamina = 50;
            coins = 50;
            soldiers_capacity = 3;
            castle = new @base();
            soldiers = new Dictionary<PictureBox, soldier>();
        }
    }
}
