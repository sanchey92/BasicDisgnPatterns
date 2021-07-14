using System;

namespace Behavioral.Command.SimpleCommand
{
    public class BankAccountCommand
    {
        private BankAccount _account;
        private Action _action;
        private int _amount;

        public BankAccountCommand(BankAccount account, Action action, int amount)
        {
            _account = account;
            _action = action;
            _amount = amount;
        }

        public void Call()
        {
            switch (_action)
            {
                case Action.Deposit:
                    _account.Deposit(_amount);
                    break;
                case Action.Withdraw:
                    _account.Withdraw(_amount);
                    break;
            }
        }
    }
}