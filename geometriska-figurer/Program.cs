using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometriska_figurer
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {Console.Clear();
                Shape[] randomShapes = RandomizeShapes();

                Array.Sort(randomShapes);

                ViewShapes(randomShapes);

            } while (IsContinuing());

            Console.Clear();
        }
        static bool IsContinuing()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n\t\tNya figurer? ESC avslutar\t\t");
            Console.ResetColor();
            
            return Console.ReadKey(true).Key != ConsoleKey.Escape;

        }
        private static Shape[] RandomizeShapes()
        {
            Random random = new Random();
            int rows = random.Next(5, 21);
            Shape[] randomizedShapes = new Shape[rows];
            for (int i = 0; i < rows; i++)
            {
 
                switch ((ShapeType)random.Next(0, 2))
                {
   
                    case ShapeType.Ellipse:
                        randomizedShapes[i] = new Ellipse(random.Next(5, 100), random.Next(5, 100));
                        break;
                    case ShapeType.Rectangle:
                        randomizedShapes[i] = new Rectangle(random.Next(5, 100), random.Next(5, 100));
                        break;
                }
            }
            return randomizedShapes;
        }
        private static void ViewShapes(Shape[] shapes)
        {
            ViewMessage(new string[] 
            { 
                "╔══════════════════════════════════════════════════════╗",
                "║                                                      ║",
                "║                 Gemetriska figurer                   ║",
                "║                                                      ║",
                "╚══════════════════════════════════════════════════════╝"
            });
            List<string> shapes_arr = new List<string>((new string[] 
            { 
              "Figur\t     Längd\tBredd\t  Omkrets\t    Area",
              "========================================================" 
            }));
            foreach (Shape shape in shapes)
            {

                shapes_arr.Add(shape.ToString());
               
            }
            ViewMessage(shapes_arr.ToArray(), ConsoleColor.Black);

        }
        /// <summary>
        ///  Vissar meddelanden för användaren
        /// </summary>
        /// <param name="messages">En array med alla meddelanden som ska visas</param>
        /// <param name="color">Färgen</param>
        private static void ViewMessage(string[] messages, ConsoleColor color = ConsoleColor.DarkYellow)
        {
            Console.BackgroundColor = color;
            foreach (string i in messages)
            {
                Console.WriteLine("{0}",i);
            }
            Console.ResetColor();
        }

    }
}
