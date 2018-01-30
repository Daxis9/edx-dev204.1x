using System;

namespace ChessBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            int col;
            int row;
            
            for (col = 0; col < 8; col++)
            {
                for (row = 0; row < 8; row++)
                {
                    if (col % 2 == 0)
                    {
                        if(row % 2 == 0)
                        {
                            Console.Write("X");
                        }
                        else
                        {
                            Console.Write("O");
                        }
                    }
                    else if(col % 2 == 1)
                    {
                        if(row % 2 == 0)
                        {
                            Console.Write("O");
                        }
                        else
                        {
                            Console.Write("X");
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
