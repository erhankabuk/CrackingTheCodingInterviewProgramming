using System;

namespace _8._10PaintFill
{
    class Program
    {
        static void Main(string[] args)
        {

            Color[,] colors = new Color[5, 4] {
            {Color.Black,Color.Green,Color.Black,Color.Green },
            {Color.Red,Color.Yellow ,Color.White,Color.Yellow},
            {Color.Green,Color.Red,Color.White,Color.White  },
            {Color.Yellow,Color.White,Color.Yellow,Color.Black  },
            {Color.Black,Color.Red ,Color.Black,Color.Black }
           };

            Console.WriteLine(PaintFill(colors, 2, 1, Color.White, Color.White));
            //for (int i = 0, j = 0; i < 5; i++)
            //{
            //    Console.WriteLine(colors[i, j]);
            //}
            Console.ReadKey();
        }

        public static bool PaintFill(Color[,] screen, int row, int column, Color ncolor)
        {
            if (screen[row, column] == ncolor) return false;
            return PaintFill(screen, row, column, ncolor);

        }

        public static bool PaintFill(Color[,] screen, int row, int column, Color ocolor, Color ncolor)
        {
            if (row < 0 || row >= screen.Length || column < 0 || column >= screen.Length) return false;

            if (screen[row, column] == ocolor)
            {
                screen[row, column] = ncolor;
                PaintFill(screen, row - 1, column, ocolor, ncolor);//up
                PaintFill(screen, row + 1, column, ocolor, ncolor);//down
                PaintFill(screen, row, column - 1, ocolor, ncolor);//left
                PaintFill(screen, row, column + 1, ocolor, ncolor);//right
            }
            return true;
        }

        public enum Color { Black, White, Red, Yellow, Green }

    }
}
