using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip.Ships
{
    public class Carrier : Ship
    {
        public Carrier() {

            Name = "Carrier";
            Health = 5;
            ShipSize = 5;
        
        }
    }
}
