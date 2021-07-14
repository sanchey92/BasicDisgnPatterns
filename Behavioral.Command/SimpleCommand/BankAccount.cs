using System;

namespace Behavioral.Command.SimpleCommand
{
    public class BankAccount
    {
        private int _balance;
        private int _overdraftLimit = -500;

        public void Deposit(int amount)
        {
            _balance += amount;
            Console.WriteLine($"Deposited ${amount}, balance = {_balance}");
        }

        public void Withdraw(int amount)
        {
            if (_balance - amount >= _overdraftLimit)
            {
                _balance -= amount;
                Console.WriteLine($"Withdrew ${amount}, balance = {_balance}");
            }
        }

        public override string ToString()
        {
            return $"{nameof(_balance)}: {_balance}";
        }
    }
}