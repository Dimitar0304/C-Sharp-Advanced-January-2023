using System;
using System.Linq;

namespace _10._Radioactive_Mutant_Vampire_Bunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isThePlayerDied = false;
            //first we recive row and cols of the lair in one line 
            //then we recive string with these chars'.','B' or'P'
            //where '.' empty space, B is a bunny and P is a player in matrix has only one P
            //after that we recive a string with directions wich is up,right,left,down
            //after each command of the player, all of bunnies spread of all '.' spaces become to B
            //if bunny reaches player he died and if player reach b cells also he died 
            //if commands become to end and player is still alive he escape from Lair  
            //after that print the matrix 
            //and if player is won or died + his cordinates

            int[] countOfRowsAndCols = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = countOfRowsAndCols[0];
            int cols = countOfRowsAndCols[1];

            char[,] matrix = new char[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                string LairLine = Console.ReadLine();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = LairLine[col];
                }
            }

            int startRow = 0;
            int startCol = 0;
            int currentRow = 0;
            int currentCol = 0;


            //indicate where player is 
            for (int row = 0; row < rows; row++)
            {

                for (int col = 0; col < cols; col++)
                {
                    if (matrix[row, col] == 'P')
                    {
                        startRow = row;
                        startCol = col;
                    }
                }
            }
            currentRow = startRow;
            currentCol = startCol;


            string commands = Console.ReadLine();
            for (int i = 0; i < commands.Length; i++)
            {
                
                char currenDirection = commands[i];
                if (currenDirection == 'U' && isThePlayerDied == false)
                {
                    if (currentRow - 1 >= 0 & matrix[currentRow - 1, currentCol] != 'B')
                    {
                        matrix[currentRow, currentCol] = '.';
                        matrix[currentRow - 1, currentCol] = 'P';
                        currentRow--;



                    }
                    else 
                    {
                        isThePlayerDied = true;
                        break;

                    }
                    if (isThePlayerDied == true)
                    {
                        break;
                    }
                    BunniesSpread(matrix, isThePlayerDied);


                }
                if (currenDirection == 'R' && isThePlayerDied == false)
                {
                    if (currentCol + 1 < matrix.GetLength(1) && matrix[currentRow, currentCol + 1] != 'B')
                    {
                        matrix[currentRow, currentCol] = '.';
                        matrix[currentRow, currentCol + 1] = 'P';
                        currentCol++;
                    }
                    else
                    {
                        isThePlayerDied = true;
                        break;

                    }
                    if (isThePlayerDied == true)
                    {
                        break;
                    }
                    BunniesSpread(matrix, isThePlayerDied);
                }
                if (currenDirection == 'L' && isThePlayerDied == false)
                {
                    if (currentCol - 1 >= 0 && matrix[currentRow, currentCol - 1] != 'B')
                    {
                        matrix[currentRow, currentCol] = '.';
                        matrix[currentRow, currentCol - 1] = 'P';
                        currentCol--;

                    }
                    else
                    {
                        isThePlayerDied = true;
                        break;
                    }
                    if (isThePlayerDied == true)
                    {
                        break;
                    }
                    BunniesSpread(matrix, isThePlayerDied);
                }
                if (currenDirection == 'D' && isThePlayerDied == false)
                {
                    if (currentRow + 1 < matrix.GetLength(0) && matrix[currentRow + 1, currentCol] != 'B')
                    {
                        matrix[currentRow, currentCol] = '.';
                        matrix[currentRow + 1, currentCol] = 'P';
                        currentRow++;

                    }
                    else
                    {
                        isThePlayerDied = true;
                        break;
                    }
                    if (isThePlayerDied == true)
                    {
                        break;
                    }
                    BunniesSpread(matrix, isThePlayerDied);
                }

            }
            for (int row = 0; row < rows; row++)
            {

                for (int col = 0; col < cols; col++)
                {
                    if (matrix[row, col] == 'P')
                    {
                        matrix[row, col] = '.';
                    }
                }
            }

            for (int row = 0; row < rows; row++)
            {

                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
            if (isThePlayerDied == true)
            {

                Console.WriteLine($"won: {currentRow} {currentCol}");
            }
            else
            {
                Console.WriteLine($"dead: {currentRow} {currentCol}");
            }
        }



        public static void BunniesSpread(char[,] matrix, bool isThePlayerDied)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'B')
                    {
                        //up add bunny
                        if (row - 1 >= 0)
                        {
                            if (matrix[row - 1, col] != 'P')
                            {
                                matrix[row - 1, col] = 'B';
                            }
                            else
                            {
                                matrix[row - 1, col] = 'B';
                                isThePlayerDied = true;
                                break;
                            }

                        }
                        //down add bunny
                        if (row + 1 < matrix.GetLength(0))
                        {
                            if (matrix[row + 1, col] != 'P')
                            {
                                matrix[row + 1, col] = 'B';
                            }
                            else
                            {
                                matrix[row - 1, col] = 'B';
                                isThePlayerDied = true;
                                break;
                            }

                        }
                        //right add B
                        if (col + 1 < matrix.GetLength(1))
                        {
                            if (matrix[row, col + 1] != 'P')
                            {
                                matrix[row, col + 1] = 'B';
                            }
                            else
                            {
                                matrix[row - 1, col] = 'B';
                                isThePlayerDied = true;
                                break;
                            }

                        }
                        //left add B
                        if (col - 1 >= 0)
                        {
                            if (matrix[row, col - 1] != 'P')
                            {
                                matrix[row, col - 1] = 'B';
                            }
                            else
                            {
                                matrix[row - 1, col] = 'B';
                                isThePlayerDied = true;
                                break;
                            }

                        }
                    }
                }
            }
        }
    }
}
