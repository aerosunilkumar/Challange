//class PrintAllKLengthStrings
//{
//    static void WorkingSolution(int level)
//    {

//        char?[,] a = new char?[4, 3] {
//                                   {'A', 'B', 'C' } ,
//                                   {'D', 'E', 'F' } ,
//                                   {'G', 'H', 'I'},
//                                   {null, 'J', null}
//                                };
//        /*
//                    a[0,0]  a[0,1]  a[0, 2]
//                    a[1, 0] a[1, 1] a[1, 2]
//                    a[2, 0] a[2, 1] a[2, 2]
//                    a[3, 0] a[3, 1] a[3, 2]
//        */

//        Print2DArray(a);
//        int given = 1;
//        List<string> combinations = new List<string>();
//        for (int i = 0; i < 5; i++)
//        {
//            switch (i)
//            {
//                case 0:
//                    StringBuilder value = new StringBuilder();
//                    for (int j = 0; j < level; j++)
//                    {
//                        Console.Write(a[given, given]);
//                        value.Append(a[given, given]);
//                    }
//                    combinations.Add(value.ToString());
//                    break;
//                case 1:
//                    value = new StringBuilder();
//                    for (int j = 0; j < level; j++)
//                    {
//                        Console.Write(a[given, given + j] + "");
//                        value.Append(a[given, given + j] + "");
//                    }
//                    combinations.Add(value.ToString());
//                    break;
//                case 2:
//                    //Console.WriteLine(a[given, given - 1]);
//                    value = new StringBuilder();
//                    for (int j = 0; j < level; j++)
//                    {
//                        Console.Write(a[given, given - j] + "");
//                        value.Append(a[given, given - j] + "");
//                    }
//                    combinations.Add(value.ToString());
//                    break;
//                case 3:
//                    //Console.WriteLine(a[given - 1, given]);
//                    Console.Write(a[given, given]);
//                    Console.Write(a[given - 1, given]);
//                    combinations.Add(a[given, given] + "" + a[given - 1, given]);
//                    break;

//                case 4:
//                    //Console.WriteLine(a[given + 1, given]);
//                    Console.Write(a[given, given]);
//                    Console.Write(a[given + 1, given]);
//                    combinations.Add(a[given, given] + "" + a[given + 1, given]);
//                    break;

//            };
//            Console.WriteLine();
//        }
//    }

//    public static void Print2DArray<T>(T[,] matrix)
//    {
//        for (int i = 0; i < matrix.GetLength(0); i++)
//        {
//            for (int j = 0; j < matrix.GetLength(1); j++)
//            {
//                Console.Write(matrix[i, j] + "\t");
//            }
//            Console.WriteLine();
//        }
//    }
//    static int count = 0;
//    // Driver method to test below methods
//    static void Main(string[] args)
//    {
//        WorkingSolution(1);
//    }
//}