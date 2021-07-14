using System;
using Behavioral.Command.SimpleCommand;
using Action = Behavioral.Command.SimpleCommand.Action;

namespace Behavioral.Command
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            var bankAccount = new BankAccount();
            var command = new BankAccountCommand(bankAccount, Action.Deposit, 100);
            command.Call();
            Console.WriteLine(bankAccount); 
        }
    }
}