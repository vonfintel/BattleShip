using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleShip.Ships;


namespace BattleShip.GameBoard
{
    public class Gameboard {
        Random rnd = new Random();


        public List<Tuple<int, int>> allShips = new List<Tuple<int, int>>();
        
        Dictionary<char, int> charInput = new Dictionary<char, int>() 
        { 
            { 'a', 0 }, 
            { 'b', 1 }, 
            { 'c', 2 }, 
            { 'd', 3 }, 
            { 'e', 4 }, 
            { 'f', 5 }, 
            { 'g', 6 }, 
            { 'h', 7 }, 
            { 'i', 8 },
            { 'j', 9 },};
        

        Battleship battleship = new Battleship();
        Submarine submarine = new Submarine();
        Carrier carrier = new Carrier();
        Destroyer destroyer = new Destroyer();
        Cruiser cruiser = new Cruiser();
        

        char[,] Gamingboard = new char[10, 10];

        public Gameboard() { 
        PopulateGameBoard();
        RandomizeShipPlacements(cruiser);
        RandomizeShipPlacements(carrier);
        RandomizeShipPlacements(destroyer);
        RandomizeShipPlacements(submarine);
        RandomizeShipPlacements(battleship);
        }

        public void PopulateGameBoard()
        {
            
            for (int row = 0; row < 10; row++)
            {
                for (int column = 0; column < 10; column++)
                {
                    Gamingboard[row, column] = ('~');
                }
            }
            
            
            
        }

        //prints the game board
        public void OutputGameBoard() {

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine();

                for (int j = 0; j < 10; j++)
                {
                    Console.Write(" " + Gamingboard[i, j]);
                }
            }


        }
        // picks a random number between 1 and 2 (x and y) corresponding to vertical vs horizontal. takes random number between 10 minus ship size and occupies the fields based off size.
        public void RandomizeShipPlacements(Ship ship) {
            int direction = rnd.Next(1, 3);
            int length = 11 - ship.ShipSize;
            //horizontal
            //Console.WriteLine(direction);
            if (direction == 1)
            {
                ship.y = rnd.Next(0, length);
                ship.x = rnd.Next(0, length);
                for (int i = 0; i < ship.ShipSize; i++)
                {
                    ship.Coordinate.Add(Tuple.Create(ship.x, ship.y));
                    allShips.Add(Tuple.Create(ship.x, ship.y));
                    ship.x = ship.x + 1;


                }
                Console.WriteLine(ship.Name);
                
               
            }
            else {
                ship.y = rnd.Next(0, length);
                ship.x = rnd.Next(0, length);
                for (int i = 0; i < ship.ShipSize; i++)
                {
                    ship.Coordinate.Add(Tuple.Create(ship.x, ship.y));
                    allShips.Add(Tuple.Create(ship.x, ship.y));
                    ship.y = ship.y + 1;


                }
                Console.WriteLine(ship.Name);
                
                


            }
            foreach (var value in ship.Coordinate)
            {
                Console.WriteLine(value);
            }


        }


        // checks if the user input of the coordinate is occupied in the allShips list
        public bool isOccupied(int userInput, int userInput2) {
            if (allShips.Contains(new Tuple<int, int>(userInput, userInput2))){
                return true;

            }
            else { return false; }
            
            
        
        }
        //takes user input and converts first character to corresponding number. checks if the coordinate is occupied and marks it differently if it is
        public void fire(String userInput, int winCondition) {
          
            

            char userInputSecond = userInput[1];

            int userInputConversion = (int)Char.GetNumericValue(userInputSecond);


            if ( String.IsNullOrEmpty(userInput) || !charInput.ContainsKey(char.ToLower(userInput[0])) || !charInput.ContainsValue(userInputConversion))
            {
                Console.WriteLine("Invalid coordinates (A1, B2 etc)");
            }
            else {
                if (isOccupied(charInput.GetValueOrDefault(userInput[0]), userInputConversion))
                {
                    Gamingboard[charInput.GetValueOrDefault(userInput[0]), userInputConversion] = '|';
                    Console.WriteLine("Hit");
                    winCondition--;
                    
                }
                else {


                    Gamingboard[charInput.GetValueOrDefault(userInput[0]), userInputConversion] = 'x';
                    Console.WriteLine("Miss");
                }
                
            
            }
            
        
        }

    }
}
