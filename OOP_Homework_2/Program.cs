using OOP_Homework;
using System.Linq;


var rationalNumber = new RationalNumber(1, 2);
Console.WriteLine(rationalNumber.ToString());

var sum = rationalNumber + rationalNumber;
Console.WriteLine(sum.ToString());

Console.WriteLine(rationalNumber.Equals(rationalNumber));

Console.ReadKey(true);
