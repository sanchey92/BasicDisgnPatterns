using System;

namespace Behavioral.NullObject
{
    public class BankAccount
    {
        private ILog _log;
        private int _balance;

        public BankAccount(ILog log = null)
        {
            _log = new OptionalLog(log);
        }

        public void Deposit(int amount)
        {
            _balance += amount;
            _log.Info($"Deposited {amount}, balance now: {_balance}");
        }

        public void Withdraw(int amount)
        {
            if (_balance >= amount)
            {
                _balance -= amount;
                _log.Info($"Withdrew {amount}, we have {_balance} left");
            }
            else
            {
                _log.Warn($"Could not withdraw {amount}");
            }
        }
    }
}