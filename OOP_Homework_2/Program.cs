using OOP_Homework;
using System.Linq;


var rationalNumber = new RationalNumber(1, 2);
Console.WriteLine(rationalNumber.ToString());

var sum = rationalNumber + rationalNumber;
Console.WriteLine(sum.ToString());


Console.WriteLine(rationalNumber.Equals(rationalNumber));

Console.WriteLine($"Высота одного этажа в доме {building1.Id} = {Building.GetFloorHeight(building1)} м.");
Console.WriteLine(Building.GetEntarnceRooms(building1));
Console.WriteLine(Building.GetFloorRooms(building1));

Console.ReadKey(true);
