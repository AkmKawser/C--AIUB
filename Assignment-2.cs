
Program.cs 
using MyLibrary2;
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
			Bank b1 = new Bank(2);
			Account a1 = new Account("Kawser",20000.0,'29-04-1994');
			a1.AccName("OOP2 G");
			//a1.AccNo("11111111");
			a1.Balance(2000.0);

			Account a2 = new Account("Asif",10000.0,'12-05-1990');
			a2.AccName("OOP2 C");
			//a2.AccNo("11111112");
			a2.Balance(2500.0);


			b1.AddAccount(a1);
			b1.AddAccount(a2);


			b1.ShowAccounts();

			b1.DeleteAccount(a1);  //auto generated account pass korbo kibhabe

			b1.ShowAccounts();

			b1.DeleteAccount(a2);

        }
    }
}


Bank.cs
using System;
namespace MyLibrary2
{
    public class Bank          //One to many association.
    {
        private Account[] accountList;

        //Paramiterized Constructor
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
namespace MyLibrary2
{

    public class Account
    {
        //Structure type Attribute Date
        private struct Date        //one to one association
        {
            private int day;
            private int month;
            private int year;

            public Date(int day, int month, int year)
            {
                this.day = day;
                this.month = month;
                this.year = year;

            }
            //property for day
            public int Day
            {
                set
                {
                    this.day = value;
                }
                get
                {
                    return this.day;
                }
            }

            //property for month
            public int Month
            {
                set
                {
                    this.month = value;
                }
                get
                {
                    return this.month;
                }
            }
            //property for year
            public int Year
            {
                set
                {
                    this.year = value;
                }
                get
                {
                    return this.year;
                }
            }

        }


        private string accNo;
        private string accName;
        private double balance;
        private Date dob;

        private static int c = 1;
     

        //Parameterized Constructor
        public Account(string accName, double balance, Date dob)
        {
            this.accNo = "Acc-" + c;
            c++;
            this.accName = accName;
            this.balance = balance;
            this.dob = dob;
        }



        //Property for accessing private attributes
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

   
        public bool Deposit(double amount)
        {
            if (amount > 0)
            {
                this.balance += amount;
                return true;
            }
            return false;
        }
   
        public bool Withdraw(double amount)
        {
            if (amount > 0 && amount <= this.balance)
            {
                this.balance -= amount;
                return true;
            }
            return false;
        }
      
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

      
        public int CalculateAge()
        {
            int age = DateTime.Now.Year - this.dob.Year;
            return age;
        }


        
        public void ShowDetails()
        {
            Console.WriteLine("Account No:{0}\nAccount Name:{1}\nBalance:{2}\nDate of Birth:{3}\nAge:{4}", this.accNo, this.accName, this.balance, this.CalculateAge());
        }
    }
}
