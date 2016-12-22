using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Player
    {
        public string name;
        public string team;
        public byte uniformNo;
        public string position;

        public Player()
        {
            uniformNo = 1;
        }
        public Player(string _name) //zorunluluk: ad vermeden oyuncu oluşturamazsın
        {
            this.name = _name;
        }

        public Player(string _name, string _team)
        {
            this.name = _name;
            this.team = _team;
        }

        public Player(string _name, string _team, byte _uniformNo, string _position)
        {
            this.name = _name;
            this.team = _team;
            this.uniformNo = _uniformNo;
            this.position = _position;
        }
    }
}
