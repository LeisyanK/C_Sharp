using System;

namespace Example007_Magic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            //Console.SetCursorPosition(10, 4);
            //Console.WriteLine("+");

            int xa = 40, ya = 1,
                xb = 1, yb = 20,
                xc = 80, yc = 20;
            
            Console.SetCursorPosition(xa,ya);
            Console.WriteLine("+");
            Console.SetCursorPosition(xb,yb);
            Console.WriteLine("+");
            Console.SetCursorPosition(xc,yc);
            Console.WriteLine("+");
            
            int x = xa, y = ya;
            int count = 0;

            while (count < 10000)
            {
                //выбираем одну из вершин
                int what = new Random().Next(0,3); // [0,3)
                //находим середину отрезка
                if (what == 0 ) // случайно выбрана первая вершина
                {
                    x = (x + xa)/2;
                    y = (y + ya)/2;
                    
                }

                if (what == 1 ) // случайно выбрана вторая вершина
                {
                    x = (x + xb)/2;
                    y = (y + yb)/2;
                    
                }

                if (what == 2 ) // случайно выбрана третья вершина
                {
                    x = (x + xc)/2;
                    y = (y + yc)/2;
                    
                }  

                Console.SetCursorPosition(x,y);
                Console.WriteLine("+");
                count += 1;

            }
        }
    }
}
