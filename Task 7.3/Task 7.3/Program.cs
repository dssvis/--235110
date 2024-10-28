using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите позицию белого короля");
            var whiteKingPosition = Console.ReadLine();

            if (!IsPositionCorrect(whiteKingPosition))
            {
                Console.WriteLine("Некорректная позиция белого короля");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Введите позицию черного коня");
            var blackHorsePosition = Console.ReadLine();

            if (!IsPositionCorrect(blackHorsePosition) ||
                whiteKingPosition == blackHorsePosition ||
                IsUnderAttack(whiteKingPosition, blackHorsePosition))
            {
                Console.WriteLine("Некорректная позиция черного коня или фигуры находятся под боем друг друга");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Введите предполагаемую позицию хода белого короля");
            var move = Console.ReadLine();

            if (CanKingMove(move, whiteKingPosition, blackHorsePosition))
                Console.WriteLine("Ход разрешен");
            else
                Console.WriteLine("Ход запрещен");

            Console.ReadKey();
        }

        static bool IsPositionCorrect(string position)
        {
            int row, column;
            DecodePosition(position, out column, out row);
            return row >= 1 && row <= 8 && column >= 1 && column <= 8;
        }

        static bool IsUnderAttack(string whiteKingPosition, string blackHorsePosition)
        {
            int kingRow, kingColumn, horseRow, horseColumn;
            DecodePosition(whiteKingPosition, out kingColumn, out kingRow);
            DecodePosition(blackHorsePosition, out horseColumn, out horseRow);

            return (Math.Abs(kingRow - horseRow) == 2 && Math.Abs(kingColumn - horseColumn) == 1) ||
                   (Math.Abs(kingRow - horseRow) == 1 && Math.Abs(kingColumn - horseColumn) == 2);
        }

        static bool CanKingMove(string move, string whiteKingPosition, string blackHorsePosition)
        {
            if (!IsPositionCorrect(move)) return false;

            int kingRow, kingColumn, moveRow, moveColumn, horseRow, horseColumn;
            DecodePosition(whiteKingPosition, out kingColumn, out kingRow);
            DecodePosition(move, out moveColumn, out moveRow);
            DecodePosition(blackHorsePosition, out horseColumn, out horseRow);

            bool isMoveCorrect = Math.Abs(moveRow - kingRow) <= 1 && Math.Abs(moveColumn - kingColumn) <= 1 && (moveRow != kingRow || moveColumn != kingColumn);
            bool isMoveUnderAttack = (Math.Abs(horseRow - moveRow) == 2 && Math.Abs(horseColumn - moveColumn) == 1) ||
                                     (Math.Abs(horseRow - moveRow) == 1 && Math.Abs(horseColumn - moveColumn) == 2);

            return isMoveCorrect && !isMoveUnderAttack;
        }

        static void DecodePosition(string position, out int column, out int row)
        {
            row = int.Parse(position[1].ToString());
            column = (int)position[0] - 'a' + 1;
        }
    }

}





