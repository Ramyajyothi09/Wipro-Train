// // See https://aka.ms/new-console-template for more information
// using System.Runtime.ExceptionServices;
// using static ABC;





// class ABC{

    
//     // parameterized Delegates responsible for method invocation at runtime
//     public delegate int Admin(int a, int b);

//     //public delegate void Printing(int result);

//     public static void Main(string[] args) {

//         //Assign Methods to delegates
//        Admin tutionfess = Tution;

      
      

//         Printing print = PrintResult;

//         // calling/using delegate
//         Console.WriteLine("Enter Tuition fee: ");
//         int tf = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("Enter Transport fee: ");
//         int tpf = Convert.ToInt32(Console.ReadLine());
//        int sum = tutionfess(tf,tpf);
//         print(sum);
    
//     }


//     static int Tution(int x , int y)
//     { return x + y; }

//     static void PrintResult(int result)
//     { 
//         Console.WriteLine("The total fees: "+result);
//     }
// }




