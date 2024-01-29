using System;
namespace oop
{
    class Player    
    {
        public Player(int x, int y)  // Remember the position of player`s spawn
        {
            X = x;
            Y = y;
        }
 
        public int X { get; private set; }
        public int Y { get; private set; }
    }
 
    class Drawer
    {
        public void Draw(char symbol, int x, int y)  // Player display in console
        {
            Console.SetCursorPosition(x, y);  // Position 
            Console.Write(symbol);            // Form
        }
    }
 
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = '@';
            Console.WriteLine("Enter x position: ");         // User choice of position
            int positionX = Int32.Parse(Console.ReadLine());
 
            Console.WriteLine("Enter y position: ");
            int positionY = Int32.Parse(Console.ReadLine());
 
            Player player1 = new Player(positionX, positionY);
 
 
            Drawer drawer = new Drawer();
            drawer.Draw(symbol, player1.X, player1.Y);      // Show results
 
            Console.ReadKey();
        }
    }
}