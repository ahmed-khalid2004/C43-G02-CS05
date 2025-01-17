using System.Diagnostics.CodeAnalysis;

namespace Assignment05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1();
            //Q2();
            //Q3();
            //Q4();
            //Q5();
            //Q6();
            //Q7();
            //Q8();
        }
        
        #region Q1 
        public static int sum1(int x, int y)
        {
            x = 50;
            y = 60;
            return x + y; // Changes only the local copy
        }
        public static int sum2(ref int x,ref int y)
        {
            x = 50;
            y = 60;
            return x + y; // Changes the original variable
        }
       
        // Explanation:
        // Passing by value: means that a copy of the variable's value is passed to the function. Modifications inside the function do not affect the original variable.
        // Passing by reference: means the function works directly with the variable's memory address, so changes affect the original variable.
            static void Q1()
            {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = sum1(a, b);
            Console.WriteLine($"After PassByValue: {a},{b}");
            Console.WriteLine(c);// 110
            int d = sum2(ref a, ref b);
            Console.WriteLine($"After PassByReference: {a},{b}");
            Console.WriteLine(d);// 110
            }
        #endregion

        #region Q2
        // Explanation:
        // When passing a reference type by value, the reference itself is copied, so changes to the object are reflected, but reassignment does not affect the original reference.
        // When passing a reference type by reference, both the reference and the object it points to can be modified.
        public static int sumarr1(int[] arr)
        {
            int sum = 0;
            arr = new int[] { 10, 20, 30, 40, 50 };
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        public static int sumarr2(ref int[] arr)
        {
            int sum = 0;
            arr = new int[] { 10, 20, 30, 40, 50 };
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        static void Q2()
        {
            int[] arr = { 1, 2, 3 };
            int res = sumarr1(arr);
            Console.WriteLine($"After ReferenceByValue: {arr[0]}"); // 1   =>  // Reassignment doesn't affect original reference
            Console.WriteLine(res);// 150 
            int res2 = sumarr2(ref arr);
            Console.WriteLine($"After ReferenceByReference: {arr[0]}"); // 10  => // Reassignment affects the original reference     
            Console.WriteLine(res2);// 150    
        }
        #endregion

        #region Q3 
        public static void sumsub(int x, int y, out int sum, out int sub)
        {
            sum = x + y;
            sub = x - y;
        }
        static void Q3()
        {
            Console.WriteLine("Enter numbers:");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int sumres,subres;
            sumsub(x, y, out sumres, out subres);
            Console.WriteLine($"Sum: {sumres}");
            Console.WriteLine($"Difference: {subres}");
        }
        #endregion

        #region Q4 
        static int SumOfDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }
        static void Q4()
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            int res = SumOfDigits(num);
            Console.WriteLine($"The sum of the digits of the number {num} is: {res}");
        }
        #endregion

        #region Q5
        public static bool IsPrime(int num)
        {
            if (num < 2) return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
                if (num % i == 0) return false;
            return true;
        }
        static void Q5()
        {
            Console.WriteLine("Enter a number to check if it is prime:");
            int num = int.Parse(Console.ReadLine());
            bool f = IsPrime(num);
            if (f) Console.WriteLine($"{num} is True");
            else Console.WriteLine($"{num} is False");
        }
        #endregion

        #region Q6 
        static void MinMaxArray(int[] arr, out int min, out int max)
        {
            min = arr[0];
            max = arr[0];
            for(int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min) min = arr[i];
                if (arr[i] > max) max = arr[i];
            }
        }
        static void Q6()
        {
            Console.WriteLine("Enter the size of the array:");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < size; i++)arr[i] = int.Parse(Console.ReadLine());
            MinMaxArray(arr, out int min, out int max);
            Console.WriteLine($"The minimum value in the array is: {min}");
            Console.WriteLine($"The maximum value in the array is: {max}");
        }
        #endregion

        #region Q7 
        static long Factorial(int num)
        {
            long res = 1;
            for (int i = 1; i <= num; i++)res *= i;
            return res;
        }
        static void Q7()
        {
            Console.WriteLine("Enter a number:");
            int num = int.Parse(Console.ReadLine());
            long fac = Factorial(num);
            Console.WriteLine($"The factorial of {num} is: {fac}");
        }
        #endregion

        #region Q8 
        static string ChangeChar(string str, int p, char n)
        {
            if (p < 0 || p >= str.Length)
            {
                Console.WriteLine("Position is out of range.");
                return str;
            }
            string res= "";
            for (int i = 0; i < str.Length; i++)
                if (i == p)res += n; 
                else res += str[i]; 
            return res;
        }
        static void Q8()
        {
            Console.WriteLine("Enter a string:");
            string str = Console.ReadLine();
            Console.WriteLine("Enter the position:");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the new character:");
            char n = Console.ReadLine()[0]; 
                string res = ChangeChar(str, p, n);
                Console.WriteLine($"The new string is: {res}");
        }
        #endregion
    }

}
