using System.Runtime.CompilerServices;
/*
 * Trunks Thomas, Square project
 * Creates a staircase with class methods using Objects
 */ 

//create an object to be manipulated
Square noobSqaure = new Square(0);

//get user input and print stairs
Console.WriteLine("Hello please select your square size");
//we cannot use Console.read as that returns garbage
noobSqaure.SetSize(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine("you chose: " + noobSqaure.GetSize());
Square.DrawStairs(noobSqaure.GetSize());