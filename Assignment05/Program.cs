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
        // Explanation:
        // Passing by value: means that a copy of the variable's value is passed to the function. Modifications inside the function do not affect the original variable.
        // Passing by reference: means the function works directly with the variable's memory address, so changes affect the original variable.
        static void PassByValue(int x)
            {
                x = 20; // Changes only the local copy
            }
            static void PassByReference(ref int x)
            {
                x = 20; // Changes the original variable
            }
            static void Q1()
            {
                int v = 10;
                PassByValue(v);
                Console.WriteLine($"After PassByValue: {v}"); 
                PassByReference(ref v);
                Console.WriteLine($"After PassByReference: {v}"); 
            }
        #endregion

        #region Q2
        // Explanation:
        // When passing a reference type by value, the reference itself is copied, so changes to the object are reflected, but reassignment does not affect the original reference.
        // When passing a reference type by reference, both the reference and the object it points to can be modified.
        static void ReferenceByValue(string[] arr)
        {
            arr[0] = "Changed"; 
            arr = new string[] { "New Array" }; // Reassignment doesn't affect original reference
        }
        static void ReferenceByReference(ref string[] arr)
        {
            arr[0] = "Changed"; 
            arr = new string[] { "New Array" }; // Reassignment affects the original reference
        }
        static void Q2()
        {
            string[] array = { "Original" };
            ReferenceByValue(array);
            Console.WriteLine($"After ReferenceByValue: {array[0]}"); 
            ReferenceByReference(ref array);
            Console.WriteLine($"After ReferenceByReference: {array[0]}"); 
        }
        #endregion

        #region Q3 
        static (int sum, int dif) SumAndSub(int a, int b, int c, int d)
        {
            int sum = a + b + c + d;
            int dif = (c + d) - (a + b);
            return (sum, dif);
        }
        static void Q3()
        {
            Console.WriteLine("Enter four numbers:");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());
            var (sum, dif) = SumAndSub(num1, num2, num3, num4);
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Difference: {dif}");
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
            Console.WriteLine("Enter a number:");
            int num = int.Parse(Console.ReadLine());
            int res = SumOfDigits(num);
            Console.WriteLine($"The sum of the digits of the number {num} is: {res}");
        }
        #endregion

        #region Q5
        static bool IsPrime(int num)
        {
            if (num <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)if (num % i == 0) return false;
            return true;
        }
        static void Q5()
        {
            Console.WriteLine("Enter a number to check if it is prime:");
            int num = int.Parse(Console.ReadLine());
            bool f = IsPrime(num);
            if (f) Console.WriteLine($"{num} is a prime number.");
            else Console.WriteLine($"{num} isn't a prime number.");
        }
        #endregion

        #region Q6 
        static void MinMaxArray(int[] arr, out int min, out int max)
        {
            min = arr[0];
            max = arr[0];
            foreach (int value in arr)
            {
                if (value < min) min = value;
                if (value > max) max = value;
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
              Console.WriteLine("Position is out of range.");
            char[] chars = str.ToCharArray();
            chars[p] = n;
            return new string(chars);
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
