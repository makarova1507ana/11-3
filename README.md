### Инструкция по использованию:
1. скачать [тут]()
![image](https://github.com/makarova1507ana/11-3/assets/103330304/03dc6f98-f73a-4d5b-899d-a68c7c1ba6e3)
2. подключить вот так 
```c#
using my_module;
```


еще один пример можно посмотреть [тут](https://github.com/Kyros222/Kyros222/blob/main/mark.md) <br>
*File:* user_location.cpp
 
*Description*: Spawn module
 
```c#
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
```
# smoke
```c++
/*
5   4  ->   passed
-5  4  ->   passed   add (check for negative numbers)
*/
```
# CP
```
/*
1.2  1,2 -> passed  add (check for double numbers)
*/
```
# Ext
```
/*
string -> passed   add (check for string)
