using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework_2
{
    public class BankCount
    {
       private   int accountNumber;

       private static int count;

       private int balance;

       private counttype typeofcount;
       

       public enum counttype
        {
            rub,
            dollar,
            euro,
        }
        public BankCount(int balance)
        {
            this.balance = balance;
            GenerateAccountNumber();
        }
        public BankCount(counttype typeofcount)
        {
            this.typeofcount = typeofcount;
            GenerateAccountNumber();
        }
        public BankCount(int balance, counttype typeofcount)
        {
            this.balance = balance;
            this.typeofcount = typeofcount;
            GenerateAccountNumber();
        }

        /// <summary>
        /// Метод генерации номера счета
        /// </summary>
        public void GenerateAccountNumber()
        {
            count = count+1;
            this.accountNumber = count;

        }      
        
       
        /// <summary>
        /// Печать счета
        /// </summary>
        public void PrintCount()
        {
            Console.WriteLine($" Ваш тип счета: {typeofcount}\n Ваш номер счета: {accountNumber}\n Ваш баланс: {balance}\n ");

        }
        public int AccountNumber { get { return accountNumber; } set { accountNumber = value; } }
        public int Balance { get { return balance; } set { balance = value; } }
        public counttype TypeofCount { get { return typeofcount; } set { typeofcount = value; } }


    }
}
