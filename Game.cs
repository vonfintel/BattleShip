// See https://aka.ms/new-console-template for more information
using BattleShip.Ships;

namespace BattleShip.GameBoard;


class Caller
{
   public static void Main(string[] args)
   {
       // Console.WriteLine("Enter your firing coordinates (A2, B1, etc)");
        //String firingInput = Console.ReadLine();
        bool isWon = false;
        int winCondition = 17;
        Gameboard g = new Gameboard();

        
        while (!isWon)
        {
            if (winCondition == 0) {
                Console.WriteLine("You Won");
                break;
            }
            g.OutputGameBoard();
            Console.WriteLine();
            Console.WriteLine("Enter your firing coordinates (A2, B1, etc)");
            String firingInput = Console.ReadLine();


            while (firingInput.Length != 2 )
            {
                Console.WriteLine("Enter your firing coordinates (A2, B1, etc)");
                firingInput = Console.ReadLine();
            }

            //g.OutputGameBoard();
            

            g.fire(firingInput, winCondition);
        }


    }
}
