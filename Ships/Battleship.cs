using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip.Ships
{
    public class Battleship : Ship
    {
        public Battleship() {
            Name = "BattleShip";
            Health = 4;
            ShipSize = 4;
        }
    }
}
