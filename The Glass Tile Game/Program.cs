using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace The_Glass_Tile_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Game loop 
            do
            {
                RenderGlassTiles();
                CheckForDeath();
                



               

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
            Console.WriteLine("Press R to jump right\n" +
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
                Console.WriteLine($"You rolled a {num} the glass tile held.");
            else
                Console.WriteLine($"You rolled a {num} you fell to your death");


            //for (int i = 0; i < 1; i++)
            //{
            //    Console.WriteLine(random.Next(1, 11));
            //}



            Console.ReadLine();

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
