using OOP_Homework_2;


BankCount mycount = new BankCount(1000, BankCount.counttype.rub);
BankCount mycount2 = new BankCount(1000, BankCount.counttype.rub);
mycount.PrintCount();
mycount.TransferMoney(mycount, 600);
mycount.PrintCount();
mycount2.PrintCount();
mycount2.TransferMoney(mycount2, 200);
mycount2.PrintCount();
mycount.TransferMoney(mycount, 150);
mycount.PrintCount();
Console.ReadKey(true);
