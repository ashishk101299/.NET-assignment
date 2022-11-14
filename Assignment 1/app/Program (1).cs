public class MathUtil{
    private static int number;
    public static bool isEven(int num)
    {
        number=num;
        if(number%2==0)
        return true;
        else
        return false;
    }

    public static bool isOdd(int num)
    {
        number=num;
    if (number%2 !=0)
    return true;
    else 
    return false;
    }


    public static int reverseNumber(int num){  
        number=num;      
        int reverse=0;
        while(number!=0)   
        {
            int remainder=number % 10;
            reverse=reverse *10+remainder;
            number=number/10;
        }    
        return reverse; 
    }

    public static int Digitcount(int num){
    number=num;
    int m,n,q;
    m=1;
    n=number;
    q=0;
    do
    {
       m=m*10;
       n=n+1;
       q++;
    }
    while(m<=n);
    return q;
    }


    public static bool isPrime(int num){
    number=num;
    if(number<=1)
      return false;
    if(number==2)
      return true;
    if(number==3)
      return true;
    if(isEven(number))
      return false;
    if(isOdd(number))
      for(int m=3; m*m<=number; m +=2)
      {
         if(number%m==0)
          return false;
      }
      return true;

    } 
}

    





























