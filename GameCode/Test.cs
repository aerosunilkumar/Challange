//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace GameCode
//{
//    // Java program to print all possible strings of length k
//    class PrintAllKLengthStrings
//    {
//        static int counter = 0;
//        public static string[] InvalidCombinations = new string[] { "AE", "EA", "AC", "CA", "AF", "FA", "AI", "IA", "AH", "HA", "AG", "GA", "AJ", "JA", "BD", "DB", "BF", "FB", "BG", "GB", "BH", "HB", "BJ", "JB", "BI", "IB", "CD", "DC", "CE", "EC", "CG", "GC", "CH", "HC", "CI", "IC", "CJ", "JC", "DF", "FD", "DH", "HD", "DI", "ID", "DJ", "JD", "EI", "IE", "EG", "GE", "EJ", "JE", "FG", "GF", "FH", "HF", "FJ", "JF", "GJ", "JG", "GI", "IG","IJ","JI" };
//        // Driver method to test below methods
//        public static void Main(string[] args)
//        {
            
//            Console.WriteLine("First Test");
//            char[] set1 = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' };
//            int k = 100000;
//            printAllKLength(set1, k);
//            Console.WriteLine(counter);
//            //foreach (var item in finalList)
//            //{
//            //    Console.WriteLine(item);
//            //}
//            //if (finalList.Count > 0)
//            //{
//            //    Console.WriteLine(finalList.Count+ counter);
//            //}
//        }

//        static bool checkAvailable(string input,int k)
//        {
//            return InvalidCombinations.Any(input.Contains);
//        }
//        // The method that prints all possible strings of length k.  It is
//        //  mainly a wrapper over recursive function printAllKLengthRec()
//        static void printAllKLength(char[] set, int k)
//        {
//            int n = set.Length;
//            printAllKLengthRec(set, "", n, k);
//        }

//        // The main recursive method to print all possible strings of length k
//        static void printAllKLengthRec(char[] set, String prefix, int n, int k)
//        {

//            // Base case: k is 0, print prefix
//            if (k == 0)
//            {
//                if (!checkAvailable(prefix, 2))
//                {
//                    counter++;
//                    //availableMoves.Add(prefix);
//                    //if (availableMoves.Count > 50) {
//                        //counter = counter+availableMoves.Count;
//                    //    availableMoves = new List<string>();
//                    //}
//                }
//                //Console.WriteLine(prefix);
//                return;
//            }

//            // One by one add all characters from set and recursively 
//            // call for k equals to k-1
//            for (int i = 0; i < n; ++i)
//            {

//                // Next character of input added
//                String newPrefix = prefix + set[i];

//                // k is decreased, because we have added a new character
//                printAllKLengthRec(set, newPrefix, n, k - 1);
//            }
//        }
//    }
//}