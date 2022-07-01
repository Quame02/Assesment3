using System;

namespace New_folder
{
    class Program
    {
        static void Main(string[] args)
        {
             //(Question 1............)
             Console.WriteLine("Enter first integer");
             int integer1 =Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Enter second integer");
             int integer2 = Convert.ToInt32(Console.ReadLine());
             While(integer1 <= integer2)
            { 
              integer1++;
              if (integer1 % 5==0)
             {
                Console.WriteLine(integer1);
             }
            }
              Console.WriteLine($"Answer equals {integer1}");

              

             //(Question number 3.......)
             Console.Write("Enter first number:");
             int num1 = int.Parse(Console.ReadLine());
             Console.Write("Enter second number:");
             int num2 = int.Parse(Console.ReadLine());
             Console.Write("Enter third number:");
             int num3 = int.Parse(Console.ReadLine());
             Console.Write("Enter fourth number:");
             int num4 = int.Parse(Console.ReadLine());
             Console.Write("Enter fifth number:");
             int num5 = int.Parse(Console.ReadLine());

             if (num1>num2 && num1>num3 && num1>num4 && num1>num5)
            {
              Console.WriteLine(num1);
            }
             else if (num2>num1 && num2>num3 && num2>num4 && num2>num5)
            { 
              Console.WriteLine(num2);
            }
             else if (num3>num1 && num3>num2 && num3>num4 && num3>num5)
            {
              Console.WriteLine(num3);
            }
             else if (num4>num1 && num4>num2 && num4>num3 && num4>num5)
            {
              Console.WriteLine(num4);
            }
             else
            {
              Console.WriteLine(num5);
            }

            // (Question 4).........
            Console.WriteLine("Enter coefficient of a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter coefficient of b:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter coefficient of c:");
            int c = int.Parse(Console.ReadLine());
            double x;
            double x2;
            int D = b*b-4*a*c;
            Console.WriteLine(D);

            if (D<0)
            { 
              Console.WriteLine("it has no real root");
            }
            else if (D==0)
            {
              x= -b/2*a;
              Console.WriteLine(x);
            }
            else
            {
              x = -b-Math.Sqrt(D)/2*a;
              x2 = -b+Math.Sqrt(D)/2*a;
              Console.WriteLine($"roots of the equation are {x} and {x2}");
            }
           
            //(Question 5)*********
            Console.Write("Enter random score:");
            int score = int.Parse(Console.ReadLine());
            if (score >=1 && score <=3)
            {
             Console.WriteLine(score*10);
            }
            else if (score >=4 && score <=6)
            {
              Console.WriteLine(score*100);
            }
            else if (score >=7 && score<=9)
            {
              Console.WriteLine(score*1000);
            }
            else if (score == 0 || score>9)
            { 
              Console.WriteLine("Error message!!!");
            }

            //(Question 6)********
            Console.Write("Input a number:");
            int num = int.Parse(Console.ReadLine());
            for (int value = 1; value <= num; value++)
            {
              if (value % (3*7) != 0)
              {
                Console.WriteLine(value);
              }
            }

           Console.WriteLine("----------------Question 8--------------")
            int t1 = 0;
            int t2 = 1;
            Console.Write("Enter number:");
            int input = int.Parse(Console.ReadLine());
            int term;
            for (int i = 0; i <=input; i++)
            {
              Console.WriteLine("{0}",t1);
              term = t1+t2;
              t1=t2;
              t2=term;
            }

            Console.WriteLine("---------------Question 9---------------");
            
            Console.Write("Enter the numbers of the rows:");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of the columns:");
            int columns = int.Parse(Console.ReadLine());
            int[,] spiral = new int[rows, columns];
            Console.WriteLine("Enter the cells of the matrix:");
            for (int row = 0; row< rows; row++)
            {
            for (int col = 0; col < columns; col++)
            {
              Console.Write("matrix[{0},{1}] = ", row, col); 
              spiral[row, col] = int.Parse(Console.ReadLine());
            }
            }
            for (int row =0; row < spiral.GetLength(0); row++)
            {
            for (int col = 0; col < spiral.GetLength(1); col++)
            {
              Console.Write($" {spiral[row, col]}");
            }
              Console.WriteLine();
            }

            Console.WriteLine("-----------Question 10----------");
            int [] num = new int [20];
            for (int i = 0; i < num.Length; i++);
            {
              Console.Write("Enter number:");
              num[i] = Convert.ToInt32(Console.ReadLine());
              int result = num[i] *5;
              Console.WriteLine(result);
            }

            Console.WriteLine("-----------Question 11---------");
            int [] number1 = new int [5];
            int [] number2 = new int [5];

            for (int i = 0; i < number1.Length; i++)
            { 
              Console.Write("input a number:");
              number1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("second array");
            for (int j = 0; j < number2.Length; j++) 
            {
              Console.Write("Enter a number:");
              number2[j] = int.Parse(Console.ReadLine());
            }
            bool isArrayEqual = number1.SequenceEqual(number2);
            Console.WriteLine($"is first array equal to second array?? {isArrayEqual}");

            Console.WriteLine("--------Question 12--------");
            int n, i;
            int [] a = new int [10];
            Console.Write("Enter the number to convert:");
            n= int.Parse(Console.ReadLine());
            for (i=0; n>0; i++)
            { 
              a[i]=n%2;
              n=n/2;
            }
            Console.Write("Binary of the given number= ");
            for (i=i-1; i>=0; i--)
            {
              Console.Write(a[i]);
            }
              
            Console.WriteLine("-----------Question 14-----------");
          
           Console.Write("enter a number:");
           string answer= Console.ReadLine();

            int num = Convert.ToInt32(answer);
           int result = "";
            while (num>1)
            { 
              int remainder = num % 2;
              result = Convert.ToString(remainder) + result;
              num /= 2;
            }
           int result = Convert.ToString(num) + result;
            Console.WriteLine("Binary: {0}", result);

            Console.WriteLine("--------Question 15--------");
            Console.Write("Enter the binary number:");
            int binaryNumber = int.Parse(Console.ReadLine());
            int decimalValue = 0;
            //initialaizing base1 value to 1,i.e 2^0
            int base1 = 1;
            
            while (binaryNumber > 0)
            { 
              int remainder = binaryNumber % 10;
              binaryNumber = binaryNumber / 10;
              decimalValue += remainder * base1;
              base1 = base1 * 2;
            }
            Console.Write($"Decimal value : {decimalValue}");
            Console.ReadKey();


        }

    }
}
