using System;
using Behavioral.Memento.Memento;

namespace Behavioral.Memento
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            var bankAccount = new BankAccount(100);
            var m1 = bankAccount.Deposit(50);
            var m2 = bankAccount.Deposit(25);

            Console.WriteLine(bankAccount);

            bankAccount.Undo();
            Console.WriteLine(bankAccount);
            bankAccount.Redo();
            Console.WriteLine(bankAccount);
        }
    }
}