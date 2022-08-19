using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip.Ships
{
    public class Ship
    {
        public string? Name
        { get; set; }
        public int ShipSize
        { get; set; }

        public int Health
        { get; set; }

        public int x
        { get; set; }

        public int y
        { get; set; }

        public List<Tuple<int, int>> Coordinate = new List<Tuple<int, int>>();
        
        public bool isAlive() {
            bool alive = true;
            if (Health > 0) {
                return alive;
            }
            else return false;


        
        }
    }
}
