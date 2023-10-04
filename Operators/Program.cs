namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Example1(arithematic)
            int sum1 = 100 + 20;
            int sum2 = sum1 + 900;
            int sum3 = sum2 + sum2;
            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
            Console.WriteLine(sum3);

            //Example2(assignment)
            int x = 10;
            Console.WriteLine(x += 3);

            //Example3(Comparision)
            int X = 5;
            int Y = 10; 
            Console.WriteLine(X == Y);

            //Example4(Logical)
            int x1 = 5;
            Console.WriteLine(x1 > 3 && x1 < 10);

        }
    }
        
    }
