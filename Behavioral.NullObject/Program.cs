using System;

namespace Behavioral.NullObject
{
    public static class Program
    {
        private static void Main()
        {
            var log = new NullLog();
            var bankAccount = new BankAccount(log);
            
            bankAccount.Deposit(100);
        }
    }
}