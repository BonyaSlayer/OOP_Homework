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
        /// <summary>
        /// Метод генерации номера счета
        /// </summary>
        public void GenerateAccountNumber()
        {
            count = count+1;
            this.accountNumber = count;

        }      
        
        /// <summary>
        /// Метод заполнения полей счета
        /// </summary>
        /// <param name="value1">Номер счета</param>
        /// <param name="value2">Баланс</param>
        /// <param name="value3">Тип 0-2</param>
        /// <returns></returns>
        public void SetCount(int balance, int type)
        {
            //this.count = value1;
            count++;
            this.accountNumber = count;
            this.balance = balance;
            this.typeofcount = (counttype)type;
            
            
        }
        

        public void PrintCount()
        {
            Console.WriteLine($" Ваш тип счета: {typeofcount}\n Ваш номер счета: {accountNumber}\n Ваш баланс: {balance}\n ");

        }
        public int AccountNumber { get { return accountNumber; } set { accountNumber = value; } }
        public int Balance { get { return balance; } set { balance = value; } }
        public counttype TypeofCount { get { return typeofcount; } set { typeofcount = value; } }


    }
}
