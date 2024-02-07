////// task1
///
////int numbers = 56; // AnyNum

////if (numbers % 3 == 0)
////{
////    Console.WriteLine($"{numbers} 3 tam olaraq bolunur");
////}
////else
////{
////    Console.WriteLine($"{numbers} 3 bolunmur");
////}

////if (numbers % 7 == 0)
////{
////    Console.WriteLine($"{numbers} 7 tam olaraq bolunur");
////}
////else
////{
////    Console.WriteLine($"{numbers} 7 bolunmur");
////}

//////________________________________________________________________

///////task2

////        // n and m num
////        Console.WriteLine("800");
////int n = 800;

////        Console.WriteLine("4");
////int m = 4;

////        // false - true
////        if (n % 2 == 0 && m % 2 == 0)
////        {
////            // true n+m
////            int sum = n + m;
////            Console.WriteLine($"{n} and {m} equals {sum}");
////        }
////        else
////        {
////            Console.WriteLine("Not true");

////        }



///
//task3
//________________________________________________________

//        // n and m num
//        Console.WriteLine("n = 15");
//        int n = 15;

//        Console.WriteLine("m = 25");
//        int m = 25;

//        // n < m error
//        if (n >= m)
//        {
//            Console.WriteLine("error m<n.");
//            return;
//        }

//        // 0 ++ m
//        int sum = 0;

//// from n to m
//for (int i = n + 1; i < m; i++)
//        {
//            // test i
//            if (i % 2 != 0)
//            {
//                // add 1
//                sum += i;
//            }
//        }

//        Console.WriteLine($"n={n} sum of odd numbers between them. m={m} = {sum}");



//// task4
//_________________________________________________________

////array
//int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

////start zero
//int sum = 0;

//// i dont no
//foreach (int number in array)
//{
//    // test \2
//    if (number % 2 != 0)
//    {
//        // If the number is odd, add it to the sum
//        sum += number;
//    }
//}

//Console.WriteLine($"The sum of the odd values in the array is = {sum}");

//testtask 
//_______________________________________________

//// Array example
//int[] array = { 1, 2, 3, 4, 5 };

//// Finding the number of elements in the array
//int count = array.Length;

//Console.WriteLine($"number of elements in the array: {count}");

//task5
//-----------------------------------------------

//// Array example
//int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 14, 16, 18 };

//// Variable for storing the number of even numbers (buradolur 0dan)
//int count = 0;

//// Iterate through all elements of the array
//foreach (int number in array)
//{
//    // test /2
//    if (number % 2 == 0)
//    {
//        // count+1
//        count++;
//    }
//}

//Console.WriteLine($"Number of even numbers in the array= {count}");

//task6
//------------------------------------------------

//// numbers n и m
//Console.WriteLine("n = 20");
//int n = 20;

//Console.WriteLine("m = 60");
//int m = 60;

//// test n < m
//if (n >= m)
//{
//    Console.WriteLine("Error n > m.");
//    return;
//}

//// storage
//int count = 0;

//// n+1 to m
//for (int i = n + 1; i < m; i++)
//{
//    // i /2
//    if (i % 2 != 0)
//    {
//        // count +1
//        count++;
//    }
//}

//Console.WriteLine($"Number of odd numbers between {n} and {m} = {count}");
//________________________________________________________________________
//tast7


//// Entering numbers n and m
//Console.WriteLine("n = 3");
//int n = 3;

//Console.WriteLine("m = 89");
//int m = 89;

//// test n >= m
//if (n >= m)
//{
//    Console.WriteLine("Error n > m.");
//    return;
//}

//// storage start 0
//int sum = 0;

//// n+1 to m
//for (int i = n + 1; i < m; i++)
//{
//    // i/2
//    if (i % 2 == 0)
//    {
//        // total numbers
//        sum += i;
//    }
//}

//Console.WriteLine($"Sum of even numbers between {n} and {m} = {sum}");

//_________________________________________________________________________
////task8

//// Entering numbers n and m
//Console.WriteLine("n = 11");
//int n = 11;

//Console.WriteLine("m = 44");
//int m = 44;

//// test n >= m
//if (n >= m)
//{
//    Console.WriteLine("error n>m");
//    return;
//}

//// storage start 0
//int count = 0;

//// start n+1 to m 11-44
//for (int i = n + 1; i < m; i++)
//{
//    // i / 2 test
//    if (i % 2 == 0)
//    {
//        // 0 + 1 ......
//        count++;
//    }
//}

//Console.WriteLine($"Number of even numbers between {n} and {m} = {count}");



//task9


//Console.WriteLine("nuber 7");
//int number = 7;

//if (IsPrime(number))
//{
//    Console.WriteLine("Prime number.");
//}
//else
//{   
//    Console.WriteLine("composite number.");
//}
   

//    static bool IsPrime(int number)
//{
//    // If a number is less than or equal to 1, it is not prime
//    if (number <= 1)
//    {
//        return false;
//    }

//    // We check numbers from 2 to number - 1
//    for (int i = 2; i < number; i++)
//    {
//        // If number is divisible by i, then it is composite
//        if (number % i == 0)
//        {
//            return false;
//        }
//    }
//    // 
//    return true;
//}

