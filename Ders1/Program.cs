using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Ders1
//{
//    //internal class Program
//{
//    static void Main(string[] args)
//    {
//Console.Write("Birinci ededi daxil edin: ");
//int eded1 = Convert.ToInt32(Console.ReadLine());

//Console.Write("İkinci ededi daxil edin: ");
//int eded2 = Convert.ToInt32(Console.ReadLine());

//int cem = CemiTap(eded1, eded2);
//Console.WriteLine("İki ededin cemi: " + cem);




// {
//                // int MultiplySumAndDifference(int a, int b)
//                {
//                    // Calculate the sum of the numbers
//                    // int cem = a + b;
//                    // Calculate the difference of the numbers
//                    // int ferq = a - b;
//                    // Find the product of the sum and difference
//                    // int netice = cem * ferq;
//                    // return netice;
//                }

//                {
//                    // int num1 = 9;
//                    //  int num2 = 3;
//                    // int netice = MultiplySumAndDifference(num1, num2);
//                    // Console.WriteLine("Result: " + netice);
//                }
//            }
//        }
//    }
//}




//class Program
//{
//    static void Main()
//    {
//        string[] words = { "salam", "masin", "buz", "ev", "kod", "Meymun", "avtobus" };
//        string[] anchoredWords = AnchorWordsLessThanFourLetters(words);

//        Console.WriteLine("butun arraylar:");
//        Console.WriteLine(string.Join(", ", words));

//        Console.WriteLine("\naxtarilan sozler ( 4 herfeden az olanlari * icinde gosterilib):");
//        Console.WriteLine(string.Join(", ", anchoredWords));
//    }

//    static string[] AnchorWordsLessThanFourLetters(string[] words)
//    {
//        return words.Select(word =>
//        {
//            if (word.Length < 4)
//                return $"*{word}*";
//            else
//                return word;
//        }).ToArray();
//    }
//}












//class Program
//{
//    static void Main()
//    {
//        string[] words = { "salam", "masin", "buz", "ev", "kod", "meymun", "avtobus" };

//        for (int i = 0; i < words.Length; i++)
//        {
//            if (words[i].Length > 4)
//            {
//                words[i] += "AZE";
//            }
//        }

//        // Printing the modified words
//        foreach (string word in words)
//        {
//            Console.WriteLine(word);
//        }
//    }
//}




//class Program
//{
//    static void Main()
//    {
//        string[] words = { "salam", "masin", "buz", "ev", "kod", "meymun", "avtobus" };

//        // Printing the elements of the array
//        foreach (string word in words)
//        {
//            Console.WriteLine(word);
//        }
//    }
//}




//class Program
//{
//    static void Main()
//    {
//        string[] sozler = { "salam", "maşın", "buz", "ev", "kod", "meymun", "avtobus" };

//        //  arasında boşluqlar olmaq şərti ilə yan-yana düz
//        string netice = string.Join(" ", sozler);
//        Console.WriteLine(netice);
//    }
//}







//class Program
//{
//    static void Main()
//    {
//        for (int i = 0; i <= 100; i++)
//        {
//            Console.WriteLine(i);
//        }
//    }
//}


//class Program
//{
//    static void Main()
//    {
//        for (int i = 0; i <= 100; i += 2)
//        {
//            Console.WriteLine(i);
//        }
//    }
//}




//class Program
//{
//    static void Main()
//    {
//        int sum = 0;

//        for (int i = 1; i <= 100; i += 2)
//        {
//            sum += i;
//        }

//        Console.WriteLine("0 ile 100 arasındaki tek ededlerin cemi: " + sum);
//    }
//}



//class Program
//{
//    static void Main()
//    {
//        for (int i = 10; i <= 99; i++)
//        {
//            int tensDigit = i / 10; // Tens digit
//            int onesDigit = i % 10; // Ones digit

//            if (tensDigit == onesDigit)
//            {
//                Console.WriteLine(i);
//            }
//        }
//    }
//}



//class Program
//{
//    static void Main()
//    {
//        int[] numbers = { 1, 2, 3, 4, 5 };
//        string[] words = { "alma", "banan", "nar" };

//        int firstNumber = GetFirstElement(numbers);
//        string firstWord = GetFirstElement(words);

//        Console.WriteLine("arrayin ilk reqemi: " + firstNumber);
//        Console.WriteLine("arrayin ilk sozu: " + firstWord);
//    }

//    static T GetFirstElement<T>(T[] array)
//{
//        if (array.Length > 0)
//        {
//            return array[0];
//        }
//        else
//        {
//            throw new InvalidOperationException("hec biri uygun deyil.");
//        }
//    }
//}



//class Program
//{
//    static void Main()
//    {
//        int[] intArray = { 1, 2, 3, 4, 5 };
//        string[] stringArray = { "alma", "kivi", "sogan", "pomidor" };

//        PrintLastElement(intArray);
//        PrintLastElement(stringArray);
//    }

//    static void PrintLastElement<T>(T[] array)
//    {
//        if (array.Length > 0)
//        {
//            T lastElement = array[array.Length - 1];
//            Console.WriteLine("son element: " + lastElement);
//        }
//        else
//        {
//            Console.WriteLine("The array is empty.");
//        }
//    }
//}


