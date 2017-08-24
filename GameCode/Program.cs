// Java program to print all possible strings of length k
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCode
{

    class AppClass
    {
        static void Main(string[] args)
        {
            Print2DArray(GameConsole.ConsolePattren);
            GameConsole g=new GameConsole(4);
        }

        #region Helper
        public static void Print2DArray<T>(T[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        #endregion
    }

    public enum Direction{
        Null,
        Left,
        Right,
        Up,
        Down
    }
    public class GameConsole {
        public CheckMove checkMove { get; set; }
        public int level { get; }
        public static readonly char?[,] ConsolePattren = new char?[4, 3]
           {
              {     'A',      'B',       'C'     } ,
              {     'D',      'E',       'F'     } ,
              {     'G',      'H',       'I'     },
              {     null,     'J',       null    }
           };
        public GameConsole(int Level)
        {
            level = Level;
            checkMove = new CheckMove(level, 0);
        }
    }

    public class CheckMove{
        public List<string> capturedMoves = new List<string>();

        public CheckMove Null { get; set; }
        public CheckMove Left { get; set; }
        public CheckMove Right { get; set; }
        public CheckMove Top { get; set; }
        public CheckMove Bottom { get; set; }
        int level;
        int BaseIndex;
        public CheckMove(int Level,int Index)
        {
            level = Level;
            BaseIndex = Index;
            foreach (Direction _direction in Enum.GetValues(typeof(Direction)))
            {
                FindMove(_direction);
            }
        }

        List<Direction> FindAvailableMoves(int CurrentIndex)
        {
            return new List<Direction>();
        }
        public void FindMove(Direction direction)
        {

            string moveObj = "";
            switch (direction)
            {
                case Direction.Null:
                    for (int i = 0; i < level; i++)
                    {
                        moveObj = moveObj + GameConsole.ConsolePattren[BaseIndex, BaseIndex].ToString();
                        Console.Write(GameConsole.ConsolePattren[BaseIndex, BaseIndex].ToString());
                        //Null = new CheckMove(level, currentIndex);
                    }
                    if (!capturedMoves.Contains(moveObj))
                    {
                        capturedMoves.Add(moveObj);
                    }
                break;
                case Direction.Left:
                    if(BaseIndex - level>0 && BaseIndex - level<3)
                    {
                        for (int i = 0; i < level; i++)
                        {
                            moveObj = moveObj + GameConsole.ConsolePattren[BaseIndex, BaseIndex].ToString();
                            Console.Write(GameConsole.ConsolePattren[BaseIndex, BaseIndex - i].ToString());
                            //Left = new CheckMove(level, currentIndex);
                        }
                        if (!capturedMoves.Contains(moveObj))
                        {
                            capturedMoves.Add(moveObj);
                        }
                    }
                    else
                    {

                    }
                    //for (int i = 0; i < level; i++)
                    //{
                    //    Console.Write(GameConsole.ConsolePattren[currentIndex, currentIndex].ToString());
                    //    Left = new CheckMove(level, currentIndex);
                    //}
                    break;
                case Direction.Right:
                    if (BaseIndex + level > 0 && BaseIndex + level < 3)
                    {
                        for (int i = 0; i < level; i++)
                        {
                            moveObj = moveObj + GameConsole.ConsolePattren[BaseIndex, BaseIndex].ToString();
                            Console.Write(GameConsole.ConsolePattren[BaseIndex, BaseIndex + i].ToString());
                            //Left = new CheckMove(level, currentIndex);
                        }
                        if (!capturedMoves.Contains(moveObj))
                        {
                            capturedMoves.Add(moveObj);
                        }
                    }
                    else
                    {

                    }

                    break;
                case Direction.Up:
                    if (BaseIndex + level > 0 && BaseIndex + level < 4)
                    {
                        for (int i = 0; i < level; i++)
                        {
                            moveObj = moveObj + GameConsole.ConsolePattren[BaseIndex, BaseIndex].ToString();
                            Console.Write(GameConsole.ConsolePattren[BaseIndex + i, BaseIndex].ToString());
                            //Left = new CheckMove(level, currentIndex);
                        }
                        if (!capturedMoves.Contains(moveObj))
                        {
                            capturedMoves.Add(moveObj);
                        }
                    }
                    else
                    {

                    }

                    break;
                case Direction.Down:
                    if (BaseIndex + level > 0 && BaseIndex + level < 4)
                    {
                        for (int i = 0; i < level; i++)
                        {
                            moveObj = moveObj + GameConsole.ConsolePattren[BaseIndex, BaseIndex].ToString();
                            Console.Write(GameConsole.ConsolePattren[BaseIndex - i, BaseIndex].ToString());
                            //Left = new CheckMove(level, currentIndex);
                        }
                        if (!capturedMoves.Contains(moveObj))
                        {
                            capturedMoves.Add(moveObj);
                        }
                    }
                    else
                    {

                    }

                    break;
            }
            moveObj = "";
        }

        public bool CheckAvailability()
        {

            return true;
        }
    }
}
