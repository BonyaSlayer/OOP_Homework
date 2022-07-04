using OOP_Homework_2;


BankCount mycount = new BankCount(BankCount.counttype.dollar);
mycount.PrintCount();
BankCount mycount2 = new BankCount(500);
mycount2.PrintCount();
BankCount mycount3 = new BankCount(1000, BankCount.counttype.euro);
mycount3.PrintCount();

Console.ReadKey(true);
