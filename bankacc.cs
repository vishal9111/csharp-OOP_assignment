using System;

namespace ConsoleApp1
{

    class bankacc
    {
        double Bal;

        public bankacc()
        {
            this.Bal = 500.0;
        }

        public bankacc(double balance)
        {
            this.Bal = balance;
        }

        public double getBalance()
        {
            return Bal;
        }
    }

    class OutputofBankAccount
    {
        public static void Main()
        {

            bankacc b1 = new bankacc();
            Console.WriteLine("Account Balance default = " + b1.getBalance());

            bankacc b2 = new bankacc(1000);
            Console.WriteLine("Account Balance = " + b2.getBalance());

        }
    }
}