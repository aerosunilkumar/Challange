//// Java program to print all possible strings of length k
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace GameCode
//{

//    class AppClass
//    {
//        static void Main(string[] args)
//        {
//            Print2DArray(GameConsole.ConsolePattren);
//            GameConsole g=new GameConsole(2);
//            foreach (var item in g.capturedMoves)
//            {
//                Console.WriteLine(item);
//            }
//            Console.WriteLine(g.capturedMoves.Count);
//        }
//        #region Helper
//        public static void Print2DArray<T>(T[,] matrix)
//        {
//            for (int i = 0; i < matrix.GetLength(0); i++)
//            {
//                for (int j = 0; j < matrix.GetLength(1); j++)
//                {
//                    Console.Write(matrix[i, j] + "\t");
//                }
//                Console.WriteLine();
//            }
//        }
//        #endregion
//    }

//    public enum Direction{
//        Null,
//        Left,
//        Right,
//        Up,
//        Down
//    }
//    public class GameConsole {
//        public List<string> capturedMoves = new List<string>();
//        public int level { get; }
//        public static readonly char?[,] ConsolePattren = new char?[4, 3]
//           {
//              {     'A',      'B',       'C'     } ,
//              {     'D',      'E',       'F'     } ,
//              {     'G',      'H',       'I'     },
//              {     null,     'J',       null    }
//           };
//        public GameConsole(int Level)
//        {
//            level = Level;
//            foreach (Direction _direction in Enum.GetValues(typeof(Direction)))
//            {
//                FindMove(_direction);
//            }
//        }
//        public void FindMove(Direction direction)
//        {

//            string moveObj = "";
//            switch (direction)
//            {
//                case Direction.Null:
//                    if (level != 0)
//                    {
//                        for (int i = 0; i < 4; i++)
//                        {
//                            for (int j = 0; j < 3; j++)
//                            {
//                                if (GameConsole.ConsolePattren[i, j] != null)
//                                {
//                                    for (int l = 0; l < level; l++)
//                                    {
//                                        moveObj = moveObj + GameConsole.ConsolePattren[i, j].ToString();
//                                    }
//                                    if (!capturedMoves.Contains(moveObj) && !string.IsNullOrEmpty(moveObj))
//                                    {
//                                        capturedMoves.Add(moveObj);
//                                        moveObj = "";
//                                    }
//                                }
//                            }
//                        }
//                    }
//                    break;
//                case Direction.Left:
//                    if (level != 1 && level != 0)
//                    {
//                        for (int i = 0; i < 4; i++)
//                        {
//                            for (int j = 1; j < 3; j++)
//                            {

//                                if (GameConsole.ConsolePattren[i, j - 1] != null && GameConsole.ConsolePattren[i, j] != null)
//                                {
//                                    moveObj = moveObj + GameConsole.ConsolePattren[i, j].ToString();
//                                    for (int l = 0; l < level - 1; l++)
//                                    {
//                                        moveObj = moveObj + GameConsole.ConsolePattren[i, j - 1].ToString();
//                                    }
//                                    if (!capturedMoves.Contains(moveObj) && !string.IsNullOrEmpty(moveObj))
//                                    {
//                                        capturedMoves.Add(moveObj);
//                                        moveObj = "";
//                                    }
//                                }
//                            }
//                        }
//                    }
//                    break;
//                case Direction.Right:
//                    if (level != 1 && level != 0)
//                    {
//                        for (int i = 0; i < 4; i++)
//                        {
//                            for (int j = 0; j < 2; j++)
//                            {
//                                if (GameConsole.ConsolePattren[i, j + 1] != null && GameConsole.ConsolePattren[i, j] != null)
//                                {
//                                    moveObj = moveObj + GameConsole.ConsolePattren[i, j].ToString();
//                                    for (int l = 0; l < level - 1; l++)
//                                    {
//                                        moveObj = moveObj + GameConsole.ConsolePattren[i, j + 1].ToString();
//                                    }
//                                    if (!capturedMoves.Contains(moveObj) && !string.IsNullOrEmpty(moveObj))
//                                    {
//                                        capturedMoves.Add(moveObj);
//                                        moveObj = "";
//                                    }
//                                }
//                            }
//                        }
//                    }
//                    break;
//                case Direction.Up:
//                    if (level != 1 && level != 0)
//                    {
//                        for (int i = 1; i < 4; i++)
//                        {
//                            for (int j = 0; j < 3; j++)
//                            {
//                                if (GameConsole.ConsolePattren[i - 1, j] != null && GameConsole.ConsolePattren[i, j] != null)
//                                {
//                                    moveObj = moveObj + GameConsole.ConsolePattren[i, j].ToString();
//                                    for (int l = 0; l < level - 1; l++)
//                                    {
//                                        moveObj = moveObj + GameConsole.ConsolePattren[i - 1, j].ToString();
//                                    }
//                                    if (!capturedMoves.Contains(moveObj) && !string.IsNullOrEmpty(moveObj))
//                                    {
//                                        capturedMoves.Add(moveObj);
//                                        moveObj = "";
//                                    }
//                                }
//                            }
//                        }
//                    }
//                    break;
//                case Direction.Down:
//                    if (level != 1 && level != 0)
//                    {
//                        for (int i = 0; i < 3; i++)
//                        {
//                            for (int j = 0; j < 3; j++)
//                            {
//                                if (GameConsole.ConsolePattren[i + 1, j] != null && GameConsole.ConsolePattren[i, j] != null)
//                                {
//                                    moveObj = moveObj + GameConsole.ConsolePattren[i, j].ToString();
//                                    for (int l = 0; l < level - 1; l++)
//                                    {
//                                        moveObj = moveObj + GameConsole.ConsolePattren[i + 1, j].ToString();
//                                    }
//                                    if (!capturedMoves.Contains(moveObj) && !string.IsNullOrEmpty(moveObj))
//                                    {
//                                        capturedMoves.Add(moveObj);
//                                        moveObj = "";
//                                    }
//                                }
//                            }
//                        }
//                    }
//                    break;
//            }
//            moveObj = "";
//        }

//        void CheckAvailableMoves(Direction direction) {

//        }
//    }
//}
