using OOP_Homework;
using System.Linq;


BankCount mycount = new BankCount(500, BankCount.counttype.rub);
BankCount mycount2 = new BankCount(500, BankCount.counttype.rub);
mycount.PrintCount();
mycount2.PrintCount();
mycount2.TransferMoney(mycount, 100);
mycount.PrintCount();
mycount2.PrintCount();

string s = "апож";

//Метод с использованием стандартной библиотеки
string ReverseString2(ref string s)
    {
        return new string(s.Reverse().ToArray());
    }

ReverseString reverse = new ReverseString();
Console.WriteLine(ReverseString.ReverseWord(ref s));
Console.WriteLine(ReverseString2(ref s));



SearchMail search = new SearchMail();
StreamReader sr = new StreamReader("D:\\HomeWorkDir\\filename.txt");
StreamWriter sw = new StreamWriter("D:\\HomeWorkDir\\email.txt");
string line = sr.ReadLine();
sw.WriteLine(search.SearchTheMail(ref line));
string line2 = sr.ReadLine();
sw.WriteLine(search.SearchTheMail(ref line2));
sw.Close();
sr.Close();

Console.ReadKey(true);
