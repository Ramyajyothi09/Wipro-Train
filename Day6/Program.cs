// // See https://aka.ms/new-console-template for more information
// //Console.WriteLine("Hello, World!");
// using System.Collections;
// //using System.Collections.Generic;
// class NonGenericExample
// {

//     static void Main()
//     {
//         // int num = 45;
//         // object boxedvalue = num; //Boxing

//         // Console.WriteLine(boxedvalue.GetType());
//         ArrayList val=

//         ArrayList arrayList = new ArrayList();  // It will store the values in object
//         int value = 20;

//         arrayList.Add(value); // Boxing
//         Console.WriteLine(arrayList.GetType());

//         int unboxingvalue = (int)arrayList[0]; // Unboxing

//         Console.WriteLine("The value after unboxing " + unboxingvalue);

//         //Generic one
//         List<int> intList = new List<int>();
//         intList.Add(value); // No Boxing is required
//          double value2 = intList[0]; // No unBoxing is required
//           Console.WriteLine("The value after unboxing " + value2);
//     }


// }


// using System;
// using System.IO;



// class Program2
// {
//     static void Main()
//     {
//         string path = "File1.txt";
//         string message = "File data related to C#";

//         // To write using FileStream
//         using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
//         {
//             byte[] data = System.Text.Encoding.UTF8.GetBytes(message);
//             fs.Write(data, 0, data.Length);
//         } // Stream is automatically closed here
//     }
// }
