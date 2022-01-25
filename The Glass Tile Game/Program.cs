using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace The_Glass_Tile_Game
{
    internal class Program
    {
//             xxxxxx          xxx
//    xxxxxxxxx       xxx xxx      x          xxxxxxxxxx         x
//    xx     xx      xxx    xx    xx      x     x                xxxx
//    xx            xxx      x    x      xx     x                x   xxxxx
//     xx           xx       x    x      x      x                x        xx
//      xxxxx       xx       x    x      x      x                x          xx
//       xxxxxx     xx       x    x      x       x               x           xx
//          xxxx    x        x    x      x       x                x           x
//            xx    x     xxxx    xx    x        xx               x           x
//    xx      xx    x      xxxx    x   xx         x               x           x
//    xxxxxxxxxx    xxx   xx xxx   xxxxx          x               x           x
//      xxxxxxx       xxxxx    x    xx         x  x               x          x
//                                             xxxxxxx xxxxxxx    x   xxxxxxx
//                    x                                           x
//                    xx
//   xxxxxxxxx        xxx           x
// xx        x        x x           xx     x      x  xxxxxxx    xxxxxxxx
// x                 xx  x          xx     x      xxx      x    x
//xx                 x    x         xx    xxx     x             xx
//x                 x     xx        x x   x x     xx             xxx
//x      xxxxxxx    xxxxxxxx       xx x  xx x      x  xxxxxxx      xxxx
// x           xx  x        x      x  xx x   x     xxx                 xxx
//  x           x  x        xx    xx   x x   xx    x                     x
//   xxx       xx  x         x    xx   xxx    x    xx                   xx
//     xxxxxxxxx                  x           xx    xxxxxxxxx        xxx
//         xx                                       x           xxxxxx
//                                                  x
//Typing=====================================================================================

        static void Main(string[] args)
        {
            // Game loop 
            do
            {
                RenderGlassTiles();
                CheckForDeath();
                
                //I want to remove this by pulling


               

                //get users input 
                string userInput = Console.ReadLine().ToLower();
                switch (userInput)
                {
                    case "r":
                        jumpRight();
                        break;
                    case "l":
                        jumpLeft();
                        break;

                    default:
                        Console.WriteLine("Please enter a direction to jump")
                       ; break;







                }

            } while (true);
         








        }




        //how many moves left the player has  

        //check to see if player has fallen 

        //Movement 
        static void jumpRight()
        {

        }
        static void jumpLeft()
        {

        }
        //Game logic 
        //Rerender glass tiles and instructions 
        static void RenderGlassTiles()
        {
            //User instructions on how to move 
            Console.Clear();
            Console.WriteLine("\n" +
                "\nEndless Runner Glass Tile Game" +
                "\n" +
                "\n" +
                "\nInstructions:" +
                "\nPress R to jump right\n" +
                "Press L to jump left\n" +
                "Roll a 7 or more to survive jump\n" +
                "Roll a 6 or below and the glass will break GAME OVER!");
            //Draw up glass tiles

           

          
            Console.WriteLine("                        L         R");
            Console.WriteLine("                        []   |   []");
            Console.WriteLine("                        []   |   []");
            Console.WriteLine("                        []   |   []");
            Console.WriteLine("                        []   |   []");
            Console.WriteLine("  Current tile choice you're on ^^^ keep going!");
           

        }




        static void CheckForDeath()
        {
            Console.ReadKey();
            //                              seed RNG 
            Random random = new Random();
            int num = random.Next(1,13);
            if(num > 6)
                Console.WriteLine($"\n" +
                    $"You rolled a {num} the glass tile held press enter to proceed");
            else
                Console.WriteLine($"\n" +
                    $"You rolled a {num} you fell to your death press enter to play again");


            //for (int i = 0; i < 1; i++)
            //{
            //    Console.WriteLine(random.Next(1, 11));
            //}



           

        }
        static void PlayerIsAlive()
        {
            bool alive = true;
            while (alive)
            {

            }
        }
        static void CheckForWin()
        {
            Console.WriteLine("The game has begun!");

           


        }
      }  
}
