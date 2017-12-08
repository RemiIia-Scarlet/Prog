using System;
using System.Data.Common;
using System.Dynamic;
using System.Linq.Expressions;

namespace Takuzu 
{
    public static class Takuzu
    {
        public static void PrintGrid(int[,] grid)
        {
            int i = 0;
            int x = grid.GetLength(0);
            int y = grid.GetLength(1);
            
            Console.Write("   ");
            while (i < grid.GetLength(0))
            {
                Console.Write(i + " ");
                i++;
            }

            Console.Write("\n");

            for (int line = 0; line < x; line++)  
            {
                Console.Write(line + " |");
                
                for (int column = 0; column < y; column++)               
                {
                    if (grid[line, column] == -1)
                    {
                        Console.Write(" |");
                        continue;                      
                    }
                    
                    Console.Write(grid[line, column] + "|");
                }               
                
                Console.Write("\n");                  
            }
            
        }

        public static bool IsRowValid(int[,] grid, int row)
        {
            int i = 0;
            int zero = 0;
            int one = 0;

            while (i < grid[row, i])
            {
                if (grid[row, i] == grid[row + 1, i])
                {
                    return false;
                }
                
                if (grid[row, i] == 1)
                {
                    one++;
                    i++;
                }

                else if (grid[row, i] == 0)
                {
                    zero++;
                    i++;
                }              
            }
            return zero == one;
        }
        
        public static bool IsColumnValid(int[,] grid, int col)
        {
            int i = 0;
            int zero = 0;
            int one = 0;

            while (i < grid[i, col])
            {
                if (grid[i, col] == grid[i, col + 1])
                {
                    return false;
                }

                if (grid[i, col] == 1)
                {
                    one++;
                    i++;
                }
                
                else if (grid[i, col] == 0)
                {
                    zero++;
                    i++;
                }
            }
            return zero == one;
        }

        public static bool IsGridValid(int[,] grid)
        {
            //FIXME
            return false;
        }

        public static bool PutCell(int[,] grid, int x, int y, int val)
        {
            //FIXME
            return false;
        }
        
        public static void Game(int[,] start)
        {
            //FIXME
        }

        public static int[,] AI(int[,] grid)
        {
            //FIXME
            return null;
        }
    }
}