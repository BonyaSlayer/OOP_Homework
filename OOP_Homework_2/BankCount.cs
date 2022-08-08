using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework
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
        public BankCount(decimal balance)
        {
            this.balance = balance;
            GenerateAccountNumber();
        }
        public BankCount(counttype typeofcount)
        {
            this.typeOfCount = typeofcount;
            GenerateAccountNumber();
        }
        /// <summary>
        /// Конструктор счета
        /// </summary>
        /// <param name="balance">Баланс</param>
        /// <param name="typeofcount">Тип счета</param>
        public BankCount(decimal balance, counttype typeofcount)
        {
            this.balance = balance;
            this.typeOfCount = typeofcount;
            GenerateAccountNumber();
        }
        /// <summary>
        /// Метод списания суммы с счета
        /// </summary>
        /// <param name="mycount">сслыка на объект</param>
        /// <param name="money">сумма</param>
        /// <returns></returns>
        public bool TransferMoney(BankCount mycount, decimal money)
        {
            if(money > this.balance)
            {
                return false;
            }
            else
            {
                this.balance -= money;
                mycount.balance += money;
                return true;
            }
        }

        /// <summary>
        /// Метод списания денег
        /// </summary>
        /// <param name="money">Сумма для списания</param>
        public void GetMoney(decimal money)
        {            
            if (this.balance >= money)
            {
                this.balance = balance - money;               
            }           
        }
        /// <summary>
        /// Метод зачисления денег
        /// </summary>
        /// <param name="money">Сумма для зачисления</param>
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

        public override bool Equals(object obj)
        {
            if(obj is not BankCount acc) return false;
            return this.accountNumber == acc.accountNumber;
        }
        /// <summary>
        /// Переопределеный оператор для сравнения двух аккаунтов
        /// </summary>
        /// <param name="mycount1">акк1</param>
        /// <param name="mycount2">акк2</param>
        /// <returns></returns>
        public static bool operator == (BankCount mycount1, BankCount mycount2)
        {
            return Equals(mycount1, mycount2);
        }
        /// <summary>
        /// Переопределеный оператор для сравнения двух аккаунтов
        /// </summary>
        /// <param name="mycount1">акк1</param>
        /// <param name="mycount2">акк2</param>
        /// <returns></returns>
        public static bool operator != (BankCount mycount1, BankCount mycount2)
        {
            return !(mycount1 == mycount2);
        }
        /// <summary>
        /// Перегруженный метод, возвращает хеш-код аккаунта
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return count + accountNumber;
        }
        /// <summary>
        /// Перегруженный метод, возвращает номер счета и баланс.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return ($"Номер счета: {accountNumber}\nБаланс: {balance}{typeOfCount} ");
        }




        public int AccountNumber { get { return accountNumber; } set { accountNumber = value; } }
        public decimal Balance { get { return balance; } set { balance = value; } }
        public counttype TypeofCount { get { return typeOfCount; } set { typeOfCount = value; } }


    }
}
