using System;
using System.Text;

namespace Assignment
{
    internal class Program
    {
        static void FunctionQuestion1ValueType(int x, int y)
        {
            x = 10;
            y = 20;
        }
        static void FunctionQuestion1ReferenceType(ref int x, ref int y)
        {
            x = 10;
            y = 20;
        }

        static void FunctionQuestion2ValueType(int[] arr)
        {
            arr = new int[2];
            arr[0] = 10;
            arr[1] = 20;
        }
        static void FunctionQuestion2ReferenceType(ref int[] arr)
        {
            arr = new int[2];
            arr[0] = 10;
            arr[1] = 20;
        }

        static void FunctionQuestion3(int x, int y , int w , int z , out int sum, out int sub)
        {
            sum = x + y;
            sub = w * z;
        }

        static int FunctionQuestion4SumDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }

        static bool FunctionQuestion5IsPrime(int number)
        {
            if (number == 1)
            {
                return false;
            }
            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void FunctionQuestion6MinMaxArray(int[] arr, ref int mn, ref int mx)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                mn = Math.Min(mn, arr[i]);
                mx = Math.Max(mx, arr[i]);
            }
        }
        static int FunctionQuestion7Factorial(int number)
        {
            int fact = 1;
            for (int i = 1; i <= number; i++)
            {
                fact *= i;
            }
            return fact;
        }

        static void FunctionQuestion8ChangeCharUsingStringBuilder(StringBuilder s, int index, char c)
        {
            s[index] = c;
        }
        static void FunctionQuestion8ChangeCharUsingString(ref string s, int index, char c)
        {
            char[] arr = s.ToCharArray();
            arr[index] = c;
            s = new string(arr);
        }
        static void Main(string[] args)
        {
            #region Question 1
            ///*
            // * Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            // */
            //int[] arr1 = new int [] { 4, 1, 3, -2, -5};
            //int[] arr2 = new int [] { -1 , 2 , 40 , 30 , 5 };
            //int[] merged_array = new int[arr1.Length + arr2.Length];
            //Array.Sort(arr1);
            //Array.Sort(arr2);

            //int pt1 = 0, pt2 = 0;
            //int pt_final = 0;
            //while (pt1 < arr1.Length && pt2 < arr2.Length)
            //{
            //    if (arr1[pt1] <= arr2[pt2])
            //    {
            //        merged_array[pt_final] = arr1[pt1];

            //        pt1++;
            //    }
            //    else
            //    {
            //        merged_array[pt_final] = arr2[pt2];
            //        pt2++;
            //    }
            //    pt_final++;
            //}
            //while(pt1 < arr1.Length)
            //{
            //    merged_array[pt_final] = arr1[pt1];
            //    pt1++;
            //    pt_final++;
            //}
            //while(pt2 < arr2.Length)
            //{
            //    merged_array[pt_final] = arr2[pt2];
            //    pt2++;
            //    pt_final++;
            //}
            //for (int i = 0; i < merged_array.Length; i++)
            //{
            //    Console.Write(merged_array[i] + " ");
            //}
            #endregion
            #region Question 2
            ///*
            // * Write a program in C# Sharp to count the frequency of each element of an array.
            // */
            //int[] frequency = new int[(int)1e6];
            //int[] arr = new int[] { 1, 2, 8, 3, 2, 2, 2, 5, 1 };
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    frequency[arr[i]]++;
            //}
            //for (int i = 0; i < frequency.Length; i++)
            //{
            //    if (frequency[i] > 0)
            //    {
            //        Console.WriteLine("Frequency of " + i + " is " + frequency[i]);
            //    }
            //}
            #endregion
            #region Question 3
            ///*
            // * Write a program in C# Sharp to find maximum and minimum element in an array
            // */
            //int[] arr = new int[] { 1, 2, 8, 3, 2, 2, 2, 50, 1 };
            //int mx = int.MinValue , mn = int.MaxValue;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    mx = Math.Max(mx, arr[i]);
            //    mn = Math.Min(mn, arr[i]);
            //}
            //Console.WriteLine("Maximum element is " + mx);
            //Console.WriteLine("Minimum element is " + mn);
            #endregion
            #region Question 4
            ///*
            // * Write a program in C# Sharp to find the second largest element in an array.
            // */
            //int[] arr = new int[] { 1, 2, 8, 3, 2, 2, 2, 50, 1 };
            //Array.Sort(arr);
            //Array.Reverse(arr);
            //int second_largest = arr[1];
            //Console.WriteLine("Second largest element is " + second_largest);
            #endregion
            #region Question 5
            ///*
            // * Consider an Array of Integer values with size N, having values as    
            //        in this Example
            //7 0 0 0 0 5 6 7 5 0 7 5 3
            //write a program find the longest distance between Two equal cells.
            // */
            //int n;
            //do
            //{
            //    Console.WriteLine("Enter the size of the array");
            //} while (!int.TryParse(Console.ReadLine(), out n));
            //int[] arr = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    do
            //    {
            //        Console.WriteLine("Enter the value of the cell number " + (i + 1));
            //    } while (!int.TryParse(Console.ReadLine(), out arr[i]));
            //}
            //// the naive approach 
            //int MaxDistance = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            MaxDistance = Math.Max(MaxDistance, j - i - 1);
            //        }
            //    }
            //}
            //Console.WriteLine("The maximum distance between two equal cells is " + MaxDistance);
            #endregion
            #region Question 6
            ///*
            // * Given a list of space separated words, reverse the order of the words.
            //    Input: this is a test		Output: test a is this
            //    Input: all your base		Output: base your all
            //    Input: Word			Output: Word
            //    Note : 
            //    Check the Split Function (Member in String Class) Output will be a Single Console.WriteLine Statement
            // */
            //Console.WriteLine("Enter the string");
            //string s = Console.ReadLine();
            //string[] words = s.Split(' ');
            //Array.Reverse(words);
            //for (int i = 0; i < words.Length; i++)
            //{
            //    Console.Write(words[i] + " ");
            //}
            #endregion
            #region Question 7
            ///*
            // * Write a program to create two multidimensional arrays of same size.
            // * Accept value from user and store them in first array.
            // * Now copy all the elements of first array on second array and print second array.
            // */
            //int n, m;
            //do
            //{
            //    Console.WriteLine("Enter the number of rows");
            //} while (!int.TryParse(Console.ReadLine(), out n));
            //do
            //{
            //    Console.WriteLine("Enter the number of columns");
            //} while (!int.TryParse(Console.ReadLine(), out m));

            //int[,] arr1 = new int[n, m];
            //int[,] arr2 = new int[n, m];
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        do
            //        {
            //            Console.WriteLine("Enter the value of the cell number " + (i + 1) + " " + (j + 1));
            //        } while (!int.TryParse(Console.ReadLine(), out arr1[i, j]));
            //    }
            //}
            //Array.Copy(arr1, arr2, arr1.Length);
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        Console.Write(arr2[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region Question 8
            ///*
            // * Write a Program to Print One Dimensional Array in Reverse Order
            // */
            //int n;
            //do
            //{
            //    Console.WriteLine("Enter the size of the array");
            //} while (!int.TryParse(Console.ReadLine(), out n));
            //int[] arr = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    do
            //    {
            //        Console.WriteLine("Enter the value of the cell number " + (i + 1));
            //    } while (!int.TryParse(Console.ReadLine(), out arr[i]));
            //}
            //Array.Reverse(arr);
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}
            #endregion

            #region Functions 
            #region Question 1
            ///*
            // * Explain the difference between passing (Value type parameters) by value and by reference
            // * then write a suitable c# example.
            // */
            ///*
            // * passing value type parameters by value means that the function will copy the value of the variable 
            // * so the actual variable will not be changed
            // * passing value type parameters by reference means that the function will change the actual variable
            // * because it will pass the address of the variable in the heap
            // */
            //int x = 5;
            //int y = 10;
            //Console.WriteLine("Using passing by value");
            //FunctionQuestion1ValueType(x, y); // x , y will not be changed
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine("Using passing by reference");
            //FunctionQuestion1ReferenceType(ref x, ref y); // x , y will be changed to 10 , 20
            //Console.WriteLine(x);
            //Console.WriteLine(y);

            #endregion
            #region Question 2
            ///*
            // * Explain the difference between passing (Reference type parameters) by value and by reference 
            // * then write a suitable c# example.
            // */
            ///*
            // * passing reference type parameters by value means that the function will allocate 4 bytes in the stack frame
            // * but will reference to the same object in the heap so the actual object will be changed
            // * so changing in the passed array will change the main reference
            // * but if you assign the object to a new object the main reference will not be changed
            // * so changing in the new object will not change the main reference
            // * 
            // * passing reference type parameters by reference means that the function will refer to the same object in the heap
            // * so if you change the object in the function it will change the main reference
            // * also if you assign the object to a new object it will change the main reference
            // */

            //int[] arr = new int[] { 1, 2, 3, 4, 5 };
            //Console.WriteLine("Using passing by value");
            //FunctionQuestion2ValueType(arr); // arr will be changed
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}
            //Console.WriteLine();
            //Console.WriteLine("Using passing by reference");
            //FunctionQuestion2ReferenceType(ref arr); // arr will be changed
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}
            #endregion
            #region Question 3
            ///*
            // * Write a c# Function that accept 4 parameters from user 
            // * and return result of summation and subtracting of two numbers
            // */
            //int x, y, w, z, sum, sub;
            //do
            //{
            //    Console.WriteLine("Enter the first number");
            //} while (!int.TryParse(Console.ReadLine(), out x));
            //do
            //{
            //    Console.WriteLine("Enter the second number");
            //} while (!int.TryParse(Console.ReadLine(), out y));
            //do
            //{
            //    Console.WriteLine("Enter the third number");
            //} while (!int.TryParse(Console.ReadLine(), out w));
            //do
            //{
            //    Console.WriteLine("Enter the fourth number");
            //} while (!int.TryParse(Console.ReadLine(), out z));

            //FunctionQuestion3(x, y, w, z, out sum, out sub);
            //Console.WriteLine("The summation is " + sum);
            //Console.WriteLine("The subtraction is " + sub);
            #endregion
            #region Question 4
            ///*
            // * Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
            //    Output should be like 
            //    Enter a number: 25                                                                                            
            //    The sum of the digits of the number 25 is: 7

            // */

            //int number;
            //do
            //{
            //    Console.WriteLine("Enter the number");
            //} while (!int.TryParse(Console.ReadLine(), out number) || number < 0);
            //int sum = FunctionQuestion4SumDigits(number);
            //Console.WriteLine("The sum of the digits of the number " + number + " is " + sum);

            #endregion
            #region Question 5
            ///*
            // * Create a function named "IsPrime", 
            // * which receives an integer number and returns true if it is prime, or false if it is not:
            // */
            //int number;
            //do
            //{
            //    Console.WriteLine("Enter a number greater than 0");
            //} while(!int.TryParse(Console.ReadLine(), out number) || number <= 0);
            //if (FunctionQuestion5IsPrime(number))
            //{
            //    Console.WriteLine("The number is prime");
            //}
            //else
            //{
            //    Console.WriteLine("The number is not prime");
            //}
            #endregion
            #region Question 6
            ///*
            // * Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, 
            // * using reference parameters
            // */
            //int[] arr = new int[] { 1, 2, -3, 4, 5, 6, 7, 8 };
            //int mn = int.MaxValue, mx = int.MinValue;
            //FunctionQuestion6MinMaxArray(arr, ref mn, ref mx);
            //Console.WriteLine("The minimum value is " + mn);
            //Console.WriteLine("The maximum value is " + mx);
            #endregion
            #region Question 7
            ///*
            // * Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter
            // */
            //int number;
            //do
            //{
            //    Console.WriteLine("Enter the number");
            //} while (!int.TryParse(Console.ReadLine(), out number) || number < 0);
            //Console.WriteLine("The factorial of the number " + number + " is " + FunctionQuestion7Factorial(number));
            #endregion
            #region Question 8
            /*
             * Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, 
             * replacing it with a different letter
             */
            StringBuilder s = new StringBuilder("");
            string BasicString;
            char c;
            int index;
            Console.WriteLine("Enter the string");
            BasicString = Console.ReadLine();
            s.Append(BasicString);
            do {
                Console.WriteLine("Enter the index 0 based");
            } while (!int.TryParse(Console.ReadLine(), out index) || index < 0 || index >= s.Length);
            do
            {
                Console.WriteLine("Enter the character");
            } while(!char.TryParse(Console.ReadLine(), out c));

            FunctionQuestion8ChangeCharUsingStringBuilder(s, index, c);
            FunctionQuestion8ChangeCharUsingString(ref BasicString, index, c);

            Console.WriteLine("String after modification using string builder " + s);
            Console.WriteLine("String after modification using basic string " + BasicString);

            #endregion
            #endregion

        }
    }
}
