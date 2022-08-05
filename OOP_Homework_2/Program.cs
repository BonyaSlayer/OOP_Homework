using OOP_Homework;
using System.Linq;


Building building1 = new Building(14, 5, 45, 3);
Building building2 = new Building(14, 5, 80, 4);


Console.WriteLine($"Высота одного этажа в доме {building1.Id} = {Building.GetFloorHeight(building1)} м.");
Console.WriteLine(Building.GetEntarnceRooms(building1));
Console.WriteLine(Building.GetFloorRooms(building1));

Console.ReadKey(true);
