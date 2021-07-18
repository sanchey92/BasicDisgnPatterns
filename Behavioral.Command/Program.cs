using System;
using Behavioral.Command.CompositeCommand;
using Action = Behavioral.Command.CompositeCommand.Action;

namespace Behavioral.Command
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            //composite
            var bankAccount = new BankAccount();
            var cmdDeposit = new BankAccountCommand(bankAccount, Action.Deposit, 100);
            var cmdWithdraw = new BankAccountCommand(bankAccount, Action.Withdraw, 10);
            var composite = new CompositeBankAccountCommand(new[] {cmdDeposit, cmdWithdraw});
            
            composite.Call();
            
            Console.WriteLine(bankAccount);
            
            composite.Undo();
            
            Console.WriteLine(bankAccount);
            
            //money transfer
            var account1 = new BankAccount();
            account1.Deposit(100);
            var account2 = new BankAccount();
            var moneyTransferCommand = new MoneyTransferCommand(account1, account2, 10);
            
            moneyTransferCommand.Call();
            
            Console.WriteLine(account1);
            Console.WriteLine(account2);
            
            moneyTransferCommand.Undo();

            Console.WriteLine(account1);
            Console.WriteLine(account2);
            

        }
    }
}