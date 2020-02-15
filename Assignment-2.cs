
Bank.cs
using System;
namespace MyLibrary
{
    public class Bank
    {
        private Account[] accountList;
        public Bank(int size)
        {
            accountList = new Account[size];
        }

        public void AddAccount(Account obj)
        {
            for (int i = 0; i < accountList.Length; i++)
            {
                if (accountList[i] == null)
                {
                    accountList[i] = obj;
                    break;
                }
            }
        }

        public void DeleteAccount(string accNo)
        {
            for (int i = 0; i < accountList.Length; i++)
            {
                if (accountList[i].AccNo == accNo)
                {
                    accountList[i] = null;
                    break;
                }
            }
        }

        public void ShowAccounts()
        {
            for (int i = 0; i < accountList.Length; i++)
            {
                if (accountList[i] == null)
                { continue; }
                accountList[i].ShowDetails();                
            }
        }
    }
}




Account.cs
using System;
namespace MyLibrary
{
    private struct Date{
        private int day;
        private int month;
        private int year;

        public Date(int day,int month,int year){
            this.day=day;
            this.month=month;
            this.year=year;

        }
        public int Day{
            set{
                this.day=value;
            }
            get{
                return this.day;
            }
        }
        public int Month{
            set{
                this.month=value;
            }
            get{
                return this.month;
            }
        }
        public int Year{
            set{
                this.year=value;
            }
            get{
                return this.year;
            }
        }

    }
    
        
    }
    public class Account
    {
        private string accNo;
        private string accName;
        private double balance;
       
        private static int c = 1;
        //Parameterless Constructor
        public Account(string accName,double balance,Date dob){
            this.accName=null;
            this.balance=0.0d;
            
        }

     //Parameterized Constructor
        public Account(string accName,double balance,Date dob)
        {
            this.accNo = "Acc-" + c;
            c++;
            this.accName = accName;
            this.balance = balance;
            this.dob = dob;
        }



//Property
        public string AccNo
        {
            get { return this.accNo; }
        }
        public string AccName
        {
            get { return this.accName; }
            set { this.accName = value; }
        }
        public double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }
        public Date DateOfBirth
        {
            get { return this.dob; }
            set { this.dob = value; }
        }

        //Deposit
        public bool Deposit(double amount)
        {
            if (amount > 0)
            {
                this.balance += amount;
                return true;
            }
            return false;
        }
        //Withdraw
        public bool Withdraw(double amount)
        {
            if (amount > 0 && amount<=this.balance)
            {
                this.balance -= amount;
                return true;
            }
            return false;
        }
        //Transfer
        public bool Transfer(Account receiver, double amount)
        {
            if (amount > 0 && amount <= this.balance)
            {
                this.balance -= amount;
                receiver.balance += amount;
                return true;
            }
            return false;
        }

//Calculate Age
        public int CalculateAge()
        {
            int age = DateTime.Now.Year - this.dob.Year;
            return age;
        }


//Show Details
        public void ShowDetails()
        {
            Console.WriteLine("Account No:{0}\nAccount Name:{1}\nBalance:{2}\nDate of Birth:{3}\nAge:{4}",this.accNo,this.accName,this.balance,this.dob.GetDate(),this.CalculateAge());
        }
    }

