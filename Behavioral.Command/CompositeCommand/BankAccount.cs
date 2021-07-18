using System;

namespace Behavioral.Command.CompositeCommand
{
    public class BankAccount
    {
        private int _balance;
        private readonly int _overdraftLimit = -500;

        public BankAccount(int balance = 0)
        {
            _balance = balance;
        }

        public void Deposit(int amount)
        {
            _balance += amount;
            Console.WriteLine($"Deposited {amount}, balance is now {_balance}");
        }

        public bool Withdraw(int amount)
        {
            if (_balance - amount >= _overdraftLimit)
            {
                _balance -= amount;
                Console.WriteLine($"Withdrew {amount}, balance is now {_balance}");
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            return $"{nameof(_balance)}: {_balance}";
        }
    }
}