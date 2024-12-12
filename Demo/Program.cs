namespace Demo
{
    internal class Program
    {
        #region video 7 functions and escape 

        //static void printShape()
        //{
        //    for (int i = 0; i <= 10; i++)
        //    {
        //        Console.WriteLine("*_*");

        //    }
        //}

        //static void printShape(int count , string pattern)
        //{
        //    for (int i = 0; i <= count; i++)
        //    {
        //        Console.WriteLine(pattern);

        //    }
        //}

        /* static void printShape(int count = 10, string pattern = "*_*")
         {
             for (int i = 0; i <= count; i++)
             {
                 Console.WriteLine(pattern);

             }
         }*/

        //static void printShape(string pattern, int count = 10)
        //{
        //    for (int i = 0; i <= count; i++)
        //    {
        //        Console.WriteLine(pattern);

        //    }
        //}
        #endregion

        #region video 8 functions with value type paramenters

        // passing by value 
        //static void swap (int x , int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //}

        // passing by reference
        //static void swap(ref int x, ref int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //}


        #endregion

        #region video 9 functions with reference type paramenters 

        //static int SumArray(int[] Arr)  
        //{
        //    // sends copy of references which makes it refers to the same place the array in driver code 
        //    int sum = 0;
        //    if (Arr is not null)
        //    {
        //        Arr[0] = 100;

        //        for (int i = 0; i < Arr.Length; i++)
        //        {
        //            sum += Arr[i];

        //        }
        //    }
        //    return sum;


        //}

        //static int SumArray(ref int[] Arr)
        //{
        //    // no difference between passing by value and passing by reference  
        //    int sum = 0;
        //    if (Arr is not null)
        //    {
        //        Arr[0] = 100;

        //        for (int i = 0; i < Arr.Length; i++)
        //        {
        //            sum += Arr[i];

        //        }
        //    }
        //    return sum;


        //}

        #endregion

        #region video 10 functions with reference type paramenters part 2  
        //static int SumArray(int[] Arr)
        //{
        //    // sends copy of references which makes it refers to the same place the array in driver code 
        //    int sum = 0;
        //    if (Arr is not null)
        //    {
        //        Arr[0] = 100;

        //        Arr = new int[] { 1, 2, 3, 4 };

        //        for (int i = 0; i < Arr.Length; i++)
        //        {
        //            sum += Arr[i];

        //        }
        //    }
        //    return sum;


        //}
        //static int SumArray(ref int[] Arr)
        //{
        //    // sends copy of references which makes it refers to the same place the array in driver code 
        //    int sum = 0;
        //    if (Arr is not null)
        //    {
        //        Arr[0] = 100;

        //        Arr = new int[] { 1, 2, 3, 4 };  // changing the refernce of the main array and make it point to the new array as they are sent by referece

        //        for (int i = 0; i < Arr.Length; i++)
        //        {
        //            sum += Arr[i];

        //        }
        //    }
        //    return sum;


        //}


        #endregion

        #region video 11 functions passing by out [sum multiply]

        //static int SumMultiply (int x , int y)
        //{
        //    return x + y;
        //    return x + y;

        //}

        //static int[] SumMultiply(int x, int y)
        //{
        //    return new int[] { x+y , x*y };



        //}

        //static Data SumMultiply(int x, int y)
        //{
        //    Data data = new Data();
        //    data.sum = x+y;
        //    data.multiply = x* y;
        //    return data;


        //}

        //static void SumMultiply(int x, int y, out int sum, out int multiply)
        //{
        //    sum = x + y;
        //    multiply = x * y;
        //    Console.WriteLine("hello");


        //}


        #endregion

        #region video 12 params

        static int SumArray(int size, params int[] Arr)
        {
            // sends copy of references which makes it refers to the same place the array in driver code 
            int sum = 0;
            if (Arr is not null)
            {

                for (int i = 0; i < Arr.Length; i++)
                {
                    sum += Arr[i];

                }
            }
            return sum;

        }

        #endregion

        #region video 13 exception handling 

        static void DoSomeCode()
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int division = x / y;
            Console.WriteLine(division);

            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            arr[100] = 0;

        }

        static void DoSomeProtectiveCode()
        {
            bool flag;
            int x, y;
            do
            {
                flag = int.TryParse(Console.ReadLine(), out x);

            } while (!flag);

            do
            {
                flag = int.TryParse(Console.ReadLine(), out y);

            } while (!flag || y == 0);

            int division = x / y;
            Console.WriteLine(division);


            int[] arr = new int[] { 1, 2, 3, 4, 5 };

            try
            {

                arr[100] = 0;


            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Hello from finally ");
                //deallocate || remove || relese  [database / file connection ]
            }






        }
        #endregion



        static void Main(string[] args)
        {
            #region video 1 judged array 
            //int[][] marks = new int[3][];
            //marks[0] = new int[3] { 10, 9, 8 };
            //marks[1] = new int[2] { 9, 7 };
            //marks[2] = new int[1] { 10 };

            //for (int i = 0; i < marks.Length; i++)
            //{
            //    for (int j = 0; j < marks[i].Length; j++)
            //    {
            //        Console.Write(marks[i][j] + " ");
            //    }
            //    Console.WriteLine();

            //}

            //// another syntax 
            //int[][] marks1 =
            //    [new int[3] { 10, 9, 8 }, new int[2] { 9, 7 }, new int[1] { 10 }];





            #endregion

            #region video 2 judged array part 2 
            // using for loop 
            //Console.WriteLine("please enter the size of your judgd array");
            //int size = int.Parse(Console.ReadLine());
            //int[][] marks = new int[size][];

            //for (int i = 0; i < size; i++)
            //{
            //    Console.WriteLine($"please enter the size of student array {i + 1}");
            //    int SizeTwo = int.Parse(Console.ReadLine());
            //    for (int j = 0; j < SizeTwo; j++)
            //    {
            //        Console.Write($"please enter the element number {j + 1}");
            //        int.TryParse(Console.ReadLine(), out marks[i][j]);
            //    }

            //}

            #endregion

            #region video 3 array Methods 

            // 1- static method (class members)


            //int[] numbers = { 1, 23, 2, 5, 10, 0 };
            //int[] numbers2 = new int[6];

            //Array.Sort(numbers);

            //for (int i = 0; i < numbers.Length; i++) 
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //Array.Reverse(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //  Array.Copy(numbers, numbers2, 3);


            //for (int i = 0; i < numbers2.Length; i++)
            //{
            //    Console.WriteLine(numbers2[i]);
            //}

            //copy in specific place in array 

            // Array.ConstrainedCopy(numbers , 1 ,numbers2,0 ,3);

            //for (int i = 0; i < numbers2.Length; i++)
            //{
            //    Console.WriteLine(numbers2[i]);
            //}


            //int index = Array.IndexOf(numbers, 5);
            //Console.WriteLine(index);

            //int Lindex = Array.LastIndexOf(numbers, 5);
            //Console.WriteLine(Lindex);

            //int Noindes = Array.IndexOf(numbers, 5);
            //Console.WriteLine(Noindes);


            //int [] numbers3 = (int[]) Array.CreateInstance(typeof(int), 1);

            //int[,] numbers4 = (int[,])Array.CreateInstance(typeof(int), 1,2);




            // 2- object member methods 


            //numbers.CopyTo(numbers2, 0);

            // foreach (int i in numbers2)
            // {
            //     Console.WriteLine(i);
            // }

            //// numbers.Length;

            // int[] arr = { 1, 2, 3, 4 };
            // arr.SetValue(10, 1); //arr[1] = 10

            // Console.WriteLine(arr[1]);

            // Console.WriteLine(arr.GetValue(1)); //arr[1]





            #endregion

            #region video 4 boxing and unboxing 

            //object obj = new object();

            //obj = "Mariam"; ///reference type in referece type 

            ////boxing 
            //obj = 15; // boxing int [value type] object [refernce type ]
            ////safe impelicit casting 


            //obj = true; //boxing

            //obj = 13.5; //boxing 

            //obj = new DateTime();

            //int x = 5;
            //object obj = 15;
            ////obj = "Eslam"
            //// x = obj; // error unboxing 

            //x = (int)obj; // unboxing //explicit unsafe casting 



            #endregion

            #region video 5 nullable types && null coalescing operator

            //string name = null;

            // int Num = null; ///error 

            //int[] Numbers;
            //Numbers = null;

            //int? num = 6;  // make it nullable
            //num = 7; 

            //string? name = null; // only for readability 

            //double? salary = 3000;
            //salary = null;

            // casting form nullabel to value type 

            //int x = 100;
            //int? y = null;

            //y = x;


            // int? y = 15;
            // int x = 0;

            // x = y;// can cause run time error 
            // x = (int)y;// Must do it that way 

            // if /*(y != null)*/  (y is not null)
            // {
            //     x = (int)y;
            // }
            // else
            // {
            //     x = 0;

            // }
            // Console.WriteLine(x);

            // x = y is not null ? (int)y : 0;


            // if (y.HasValue)
            //     x = (int)y;
            // else
            //     x = 0;

            //// null colesing operator 

            // x = y ?? 0;  // replace the value of null in 

            // x = y is not null ? (int)y : 0; // is translated in the back ground 


            #endregion

            #region video 6  null propagation operator 

            //double salary = default; // = 0

            //int[] arr;   // don't have to write ?
            //arr = default;

            //if (arr is not null)  // fixed runtime 
            //{

            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        Console.WriteLine(arr[i]);   //runtime error 
            //    }
            //}

            //for (int i = 0;(arr is not null )  && (i < arr.Length); i++)
            //{
            //    Console.WriteLine(arr[i]);   //runtime error 
            //}


            //arr = new int[] { 1, 2, 3 ,4,  5};

            //for (int i = 0; i < arr?.Length; i++)  //  (only runs 1 if null and n times if array has values ) 
            //null propagation operator if array is not null return length

            //{
            //    Console.WriteLine(arr[i]);

            //}


            //employee {department ,name , id}
            //department {dept name , dept id}

            //employee?.department?.deptName

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
            numbers = null;

            Console.WriteLine(numbers?.Length ?? 0); // if numbers returns null return 0 if not return the length

            // null forgeviness opeartor

            string name = null!;  //this to say that i won't use this that it will thorw an exception 




            #endregion

            #region video 7  functions and escape 

            //Program.printShape();  // don't have to write program because Main and print shape are in the same class

            //printShape();


            //printShape(10,"-_-");

            //printShape(pattern : "-_-" , count : 10); // passing by name 

            //printShape(pattern: "***");

            //printShape( "***" , 4);

            //Console.WriteLine("Eslam \n Sayed");


            //Console.WriteLine("Eslam \\n Sayed");


            //Console.WriteLine("Eslam \n \\t Sayed");

            //Console.WriteLine(@"Eslam \n Sayed");

            //printShape(@"\*/", 5);



            #endregion


            #region video 8 functions with value type paramenters

            // passing by valeu 
            //int a = 10 ; int b = 5;
            //Console.WriteLine(" a = " + a);
            //Console.WriteLine(" b = " + b);

            //swap(a, b); // passing copy of values
            //// after call the stack frame is deleted hense the values 

            //Console.WriteLine("after swap");
            //Console.WriteLine(" a = " + a);
            //Console.WriteLine(" b = " + b);

            //// passing by reference 

            //int a = 10; int b = 5;
            //Console.WriteLine(" a = " + a);
            //Console.WriteLine(" b = " + b);

            //swap(ref a, ref b); // passing copy of values
            //// after call the stack frame is deleted hense the values 

            //Console.WriteLine("after swap");
            //Console.WriteLine(" a = " + a);
            //Console.WriteLine(" b = " + b);


            #endregion

            #region video 9 functions with reference type paramenters 
            //int[] Arr = { 20, 30, 40, 50 };

            //int Return = SumArray(ref Arr);

            //Console.WriteLine(Return);
            //Console.WriteLine(Arr[0]);


            #endregion


            #region video 10 functions with reference type paramenters part 2  

            //int[] Numbers = { 100, 200, 300, 400 };

            //int result = SumArray(Numbers);

            //Console.WriteLine(Return);
            //Console.WriteLine(Arr[0]);

            //int[] Numbers = { 100, 200, 300, 400 };

            //int result = SumArray(ref Numbers);

            //Console.WriteLine(result);
            //Console.WriteLine(Numbers[0]);



            #endregion

            #region video 11 functions passing by out [sum multiply]
            //int a = 10, b = 5;

            //int s = 0, m = 0;


            //SumMultiply(a, b, out s, out m);

            //// SumMultiply(a, b, ref s, ref m); //input output param
            ////SumMultiply(a, b, out int  s, out int m);  // you can initilaize it here 

            //SumMultiply(a, b, out _, out m);  // i don't need to make sum retrun the multi only not the sum (not a variable)


            //Console.WriteLine(s);
            //Console.WriteLine(m);

            //bool flag = int.TryParse(Console.ReadLine(), out int x);


            #endregion

            #region video 12  params


            //int[] Numbers = { 1, 2, 3, 4, 5 };
            //int res = SumArray(1, 2, 3, 4, 5);
            //Console.WriteLine(res);

            #endregion

            #region video 13 exception handling 
            DoSomeCode();
            DoSomeProtectiveCode();

            #endregion





        }

    }
}
