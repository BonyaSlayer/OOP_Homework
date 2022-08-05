using OOP_Homework;


BankCount mycount1 = new BankCount(1000, BankCount.counttype.rub);
BankCount mycount2 = new BankCount(2000, BankCount.counttype.rub);

bool result1 = mycount1 == mycount2;
bool result2 = mycount1 != mycount2;

string check = mycount1.ToString();
Console.WriteLine(check);

int hashCode1 = mycount1.GetHashCode();
int hashCode2 = mycount2.GetHashCode();

Console.WriteLine(rationalNumber.Equals(rationalNumber));

Console.WriteLine($"Высота одного этажа в доме {building1.Id} = {Building.GetFloorHeight(building1)} м.");
Console.WriteLine(Building.GetEntarnceRooms(building1));
Console.WriteLine(Building.GetFloorRooms(building1));

Console.ReadKey(true);
