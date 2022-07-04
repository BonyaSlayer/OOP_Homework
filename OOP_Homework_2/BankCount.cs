using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework_2
{
    public class BankCount
    {
       private int accountNumber;

       private static int count;

       private decimal balance;

       private counttype typeOfCount;
       

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
            this.typeOfCount = typeofcount;
            GenerateAccountNumber();
        }
        public BankCount(int balance, counttype typeofcount)
        {
            this.balance = balance;
            this.typeOfCount = typeofcount;
            GenerateAccountNumber();
        }

        public void GetMoney(decimal money)
        {            
            if (this.balance >= money)
            {
                this.balance = balance - money;               
            }           
        }

        public void AddMoney(decimal money)
        {            
            this.balance = balance + money;           
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
            Console.WriteLine($" Ваш тип счета: {typeOfCount}\n Ваш номер счета: {accountNumber}\n Ваш баланс: {balance}\n ");

        }
        public int AccountNumber { get { return accountNumber; } set { accountNumber = value; } }
        public decimal Balance { get { return balance; } set { balance = value; } }
        public counttype TypeofCount { get { return typeOfCount; } set { typeOfCount = value; } }


    }
}
