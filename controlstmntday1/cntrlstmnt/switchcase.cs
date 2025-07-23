using System.Collections;

class PrimeOdd
{
    static void Main()
    {
        Console.WriteLine("Enter a value:");
        int a = Convert.ToInt32(Console.ReadLine());


        switch (a)
        {
            case 1:
                Console.WriteLine("Enter a value to check it is prime or not: ");
                int b = Convert.ToInt32(Console.ReadLine());
                Primenum pr = new Primenum();
                pr.Display();
                break;
            //case 2:
                /*Console.WriteLine("Enter a value to check it is odd or not: ");
                int b = Convert.ToInt32(Console.ReadLine());
                Oddnum o = new Oddnum();
                o.Display();
                break;
            //case 3:
                Console.WriteLine("Enter a value to check it is prime or not: ");
                int b = Convert.ToInt32(Console.ReadLine());
                Evennum e = new Evennum();
                p.Display();
                break;   */ 
        }
       


    }



}


        