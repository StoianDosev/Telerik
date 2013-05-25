using System;
using System.Collections.Generic;

/*4.Refactor and improve the naming in the C# source project “3. Naming-Identifiers-Homework.zip”. 
You are allowed to make other improvements in the code as well (not only naming) as well as to fix bugs.*/


namespace Minesweeper
{
    public class Mines
    {
        static void Main()
        {
            string command = string.Empty;
            char[,] field = CreatePlayField();
            char[,] mines = CreateMineField();
            int count = 0;
            bool isDetonated = false;
            List<Score> winners = new List<Score>(6);
            int row = 0;
            int col = 0;
            bool isNewGame = true;
            const int MaxScore = 35;
            bool isWinner = false;

            do
            {
                if (isNewGame)
                {
                    Console.WriteLine("Let's play “Minesweeper”. Try your chance to find positions on the field without mines." +
                    " Commmand 'top'- shows statistics of the game, 'restart' - starts new game, 'exit' - exits from the game !");
                    DrawField(field);
                    isNewGame = false;
                }
                Console.Write("Select row and column : ");
                command = Console.ReadLine().Trim();
                int maxCommandLength = 3;
                if (command.Length >= maxCommandLength)
                {
                    if (int.TryParse(command[0].ToString(), out row) && int.TryParse(command[2].ToString(), out col) &&
                        row <= field.GetLength(0) && col <= field.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        TopScores(winners);
                        break;
                    case "restart":
                        field = CreatePlayField();
                        mines = CreateMineField();
                        DrawField(field);
                        isDetonated = false;
                        isNewGame = false;
                        break;
                    case "exit":
                        Console.WriteLine("Goodbye!");
                        break;
                    case "turn":
                        if (mines[row, col] != '*')
                        {
                            if (mines[row, col] == '-')
                            {
                                ProcessingTurns(field, mines, row, col);
                                count++;
                            }
                            if (MaxScore == count)
                            {
                                isWinner = true;
                            }
                            else
                            {
                                DrawField(field);
                            }
                        }
                        else
                        {
                            isDetonated = true;
                        }
                        break;
                    default:
                        Console.WriteLine(Environment.NewLine + "Invalid command " + Environment.NewLine);
                        break;
                }
                if (isDetonated)
                {
                    DrawField(mines);
                    Console.Write("Game over! ");
                    Console.WriteLine("{0}: score", count);
                    Console.WriteLine("Enter your name:");
                    string playerName = Console.ReadLine();
                    Score topScores = new Score(playerName, count);
                    int maxWinnersDisplayScore = 5;
                    if (winners.Count < maxWinnersDisplayScore)
                    {
                        winners.Add(topScores);
                    }
                    else
                    {
                        for (int index = 0; index < winners.Count; index++)
                        {
                            if (winners[index].Points < topScores.Points)
                            {
                                winners.Insert(index, topScores);
                                winners.RemoveAt(winners.Count - 1);
                                break;
                            }
                        }
                    }
                    winners.Sort((Score firstPlayer, Score secondPlayer) => secondPlayer.Name.CompareTo(firstPlayer.Name));
                    winners.Sort((Score firstPlayer, Score secondPlayer) => secondPlayer.Points.CompareTo(firstPlayer.Points));
                    TopScores(winners);

                    field = CreatePlayField();
                    mines = CreateMineField();
                    count = 0;
                    isDetonated = false;
                    isNewGame = true;
                }
                if (isWinner)
                {
                    Console.WriteLine("Well-Done! You have discoverd all cells without error.");
                    Console.WriteLine("Your maxscore is: {0} ", MaxScore);
                    Console.WriteLine("Please enter your name: ");
                    string winnerName = Console.ReadLine();
                    Score playerScore = new Score(winnerName, count);
                    winners.Add(playerScore);
                    TopScores(winners);

                    DrawField(mines);
                    field = CreatePlayField();
                    mines = CreateMineField();
                    count = 0;
                    isWinner = false;
                    isNewGame = true;
                }
            }
            while (command != "exit");

            Console.WriteLine("Made in Bulgaria!");
            Console.WriteLine("ⓒ All rigths reserved.");
            Console.Read();
        }

        private static void TopScores(List<Score> winners)
        {
            Console.WriteLine("score :");
            if (winners.Count > 0)
            {
                for (int index = 0; index < winners.Count; index++)
                {
                    Console.WriteLine("{0}. {1} --> {2} cells",
                        index + 1, winners[index].Name, winners[index].Points);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty score!" + Environment.NewLine);
            }
        }

        private static void ProcessingTurns(char[,] field, char[,] mines, int row, int col)
        {
            char numberOfMines = NumberOfMinesAroundOpenedCell(mines, row, col);
            mines[row, col] = numberOfMines;
            field[row, col] = numberOfMines;
        }

        private static void DrawField(char[,] field)
        {
            int rowCount = field.GetLength(0);
            int colCount = field.GetLength(1);

            Console.WriteLine(Environment.NewLine + "    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");

            for (int row = 0; row < rowCount; row++)
            {
                Console.Write("{0} | ", row);
                for (int col = 0; col < colCount; col++)
                {
                    Console.Write(string.Format("{0} ", field[row, col]));
                }
                Console.Write("|" + Environment.NewLine);
            }

            Console.WriteLine("   ---------------------" + Environment.NewLine);
        }

        private static char[,] CreatePlayField()
        {
            int fieldRows = 5;
            int fieldCols = 10;
            char[,] field = new char[fieldRows, fieldCols];
            for (int row = 0; row < fieldRows; row++)
            {
                for (int col = 0; col < fieldCols; col++)
                {
                    field[row, col] = '?';
                }
            }

            return field;
        }

        private static char[,] CreateMineField()
        {
            int mineFieldRows = 5;
            int mineFieldCols = 10;
            char[,] mineField = new char[mineFieldRows, mineFieldCols];

            for (int row = 0; row < mineFieldRows; row++)
            {
                for (int col = 0; col < mineFieldCols; col++)
                {
                    mineField[row, col] = '-';
                }
            }

            List<int> minesMap = new List<int>();
            int maxMinesOnTheField = 15;

            while (minesMap.Count < maxMinesOnTheField)
            {
                int fieldCells = 50;
                Random random = new Random();
                int minesLocation = random.Next(fieldCells);
                if (!minesMap.Contains(minesLocation))
                {
                    minesMap.Add(minesLocation);
                }
            }

            foreach (int mines in minesMap)
            {
                int col = (mines / mineFieldCols);
                int row = (mines % mineFieldCols);
                if (row == 0 && mines != 0)
                {
                    col--;
                    row = mineFieldCols;
                }
                else
                {
                    row++;
                }
                mineField[col, row - 1] = '*';
            }

            return mineField;
        }

        private static char NumberOfMinesAroundOpenedCell(char[,] mineField, int row, int col)
        {
            int mineCount = 0;
            int rows = mineField.GetLength(0);
            int cols = mineField.GetLength(1);

            if (row - 1 >= 0)
            {
                if (mineField[row - 1, col] == '*')
                {
                    mineCount++;
                }
            }
            if (row + 1 < rows)
            {
                if (mineField[row + 1, col] == '*')
                {
                    mineCount++;
                }
            }
            if (col - 1 >= 0)
            {
                if (mineField[row, col - 1] == '*')
                {
                    mineCount++;
                }
            }
            if (col + 1 < cols)
            {
                if (mineField[row, col + 1] == '*')
                {
                    mineCount++;
                }
            }
            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (mineField[row - 1, col - 1] == '*')
                {
                    mineCount++;
                }
            }
            if ((row - 1 >= 0) && (col + 1 < cols))
            {
                if (mineField[row - 1, col + 1] == '*')
                {
                    mineCount++;
                }
            }
            if ((row + 1 < rows) && (col - 1 >= 0))
            {
                if (mineField[row + 1, col - 1] == '*')
                {
                    mineCount++;
                }
            }
            if ((row + 1 < rows) && (col + 1 < cols))
            {
                if (mineField[row + 1, col + 1] == '*')
                {
                    mineCount++;
                }
            }
            return char.Parse(mineCount.ToString());
        }
    }
}
