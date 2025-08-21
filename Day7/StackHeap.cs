//STACK & HEAP EXAMPLE
// Stack - fast , small and limited  stores : value types ,method call info ,
// a reference variable pointing to an object

// Heap  : Larger , slower  , stores an actual objects of reference types  --Managed by GC
//internal class NewPrograms
//{
//public static void Main()
//{
//    int a = 5;
//    int b = a;
//    b = 60;


//   Console.WriteLine(a);
//   Console.WriteLine(b);

//}

// }

//class Student
//{
//public string Name;


//    public static void Main()
//    {
//        Student s1 = new Student();
//        s1.Name = "Niti";

//        Student s2 = s1; // Copy reference 

//        s2.Name = "Preeti";

//        Console.WriteLine(s2.Name);
//        Console.WriteLine(s1.Name);

//    }




// 


//-------------------------------------------------------------------------

//Tuples & Deconstruction

// : a tuple is a light weight data container but on the other side it
// also unpacks(deconstruct) into variables

// class Abc
// {
//     //(int min , int max) -- Return type : Tuple with named fields  ---
//     // GetMinMax   // Method name
//     //(int[] arr)   // Input parameter : array of integers


//     public static (int min, int max) GetMinMax(int[] arr)
//         {

//         //Min() and Max() are LINQ methods which comes under using System.LINQ 
//         return (arr.Min(), arr.Max());

//     }


//     }

// class ProgramExample
// {
//     static void Main(string[] args) {
//         //deconstruction back to tuple
//         var (min, max) =  Abc.GetMinMax(new[] { 4, 5, 6, 1 });
//         Console.WriteLine("Min"+ min + "Max" +  max);
//     }
// }

//_________________________________________________________


// Indexers -- It allows instances of a class to be indexed just like an array


using System;
class Employee
{
    public int id { get; set; }
    public string name { get; set; }
    Employee(int id, string name)
    {
        this.id = id;
        this.name = name;
    }


    // modifier type  this[int index or string name]
    // Indexer for a Employee class to work as an array while fetching the values 
    public Object this[int index]
    {
        get
        {

            if (index == 0)
                return id;

            else if (index == 1)
                return name;
            else
                return null;
        }
        set
        {

            if (index == 0)
                id = Convert.ToInt32(value);

            else if (index == 1)
                name = value.ToString();

        }




    }

    class MainProgram
    {
        public static void Main1()
        {
            Employee e = new Employee(101, "Niti");
            Console.WriteLine(e[1]);


        }
    }

}







