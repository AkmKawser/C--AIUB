Account.cs
using System;

namespace ClassLibrary1
{
       abstract public class Account
    {
    
        private string accNo;
        private string accName;
        private double balance;

        private static int counter = 0;

        public Account()
        {

        }
        //Parameterized Constructor
        public Account(string accName, double balance)
        {
            this.accNo = "Acc-" + counter;
            counter++;
            this.accName = accName;
            this.balance = balance;
           
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
      

        public double CurrentBalance()
        {
            return balance;
        }

        
        public void ShowDetails()
        {
            Console.WriteLine("Account No:{0}\nAccount Name:{1}\nBalance:{2}", this.accNo, this.accName, this.balance);
        }
    }
}

savingaccount.cs
using System;

namespace ClassLibrary1
{
	public class SavingAccount : Account

	{
		private double interestRate;

		public double InterestRate
		{
			set {
				if (balance > 10000)
				{
					interestRate = balance * .06;
				}
				else
					interestRate = balance * .03;
				    this.interestRate = value;
			    
			    }
			get { return this.interestRate; }
		}


		public void showDetails()  //account class e attribute gulake protected na korle ei class theke access kora jetona.
		{

			Console.WriteLine("Account Number: " + accNo);
			Console.WriteLine("Account Name: " + accName);
			Console.WriteLine("Balance: " + balance);
			Console.WriteLine("Interest Rate: " + interestRate);
		}
	}
}


checkignaccount.cs
using System;


namespace ClassLibrary1
{
    public class CheckingAccount:Account
    {
       public CheckingAccount()
       {
       }

     

    }
}


program.cs
using System;
using ClassLibrary1;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Account a1 = new Account("Kawser", 20000.0);
            //Account a2 = new Account("Akm Kawser", 30000.0);
           SavingAccount c = new SavingAccount();

            
            c.Deposit(500.00);
            c.Withdraw(100.00);
            c.CurrentBalance();
            c.interestRate();
            c.ShowDetails();
            

            CheckingAccount s = new CheckingAccount();

            s.Deposit(200.00);
            s.Withdraw(100.00);
            s.CurrentBalance();
            s.ShowDetails();

          
        }
    }
}
        
