using OOP_Homework_2;


BankCount mycount = new BankCount();
BankCount mycount2 = new BankCount();
BankCount mycount3 = new BankCount();


mycount.GenerateAccountNumber();
mycount.PrintCount();

mycount2.GenerateAccountNumber();
mycount2.PrintCount();

mycount3.GenerateAccountNumber();
mycount3.PrintCount();

Console.ReadKey(true);
