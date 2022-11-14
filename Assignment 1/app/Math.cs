using System;
class Math
{
    public static void Main(string [] args)
    {
        int number=int.Parse(args[0]);
        Console.WriteLine("Check for number is Even or odd");
        bool result = MathUtil.isEven(number);
        if(result)
        {
            Console.WriteLine("number is Even");
        }
        else
        {
            Console.WriteLine("Given number is odd");
        }
        Console.WriteLine("Reverse of the number {0} is:{1}",number, MathUtil.reverseNumber(number));

        Console.WriteLine("digit in number {0}", MathUtil.Digitcount(number)); 

        bool prime=MathUtil.isPrime(number);
        if(prime)
        {
            Console.WriteLine("Given number is prime");
        }
        else 
         Console.WriteLine("Given number is notprime");



    }
}