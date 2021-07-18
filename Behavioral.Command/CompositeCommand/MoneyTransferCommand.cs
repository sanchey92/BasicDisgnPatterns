namespace Behavioral.Command.CompositeCommand
{
    public class MoneyTransferCommand : CompositeBankAccountCommand
    {
        public MoneyTransferCommand(BankAccount from, BankAccount to, int amount)
        {
            AddRange(new []
            {
                new BankAccountCommand(from, Action.Withdraw, amount),
                new BankAccountCommand(to , Action.Deposit, amount)
            });
        }

        public override void Call()
        {
            BankAccountCommand last = null;
            foreach (var cmd in this)
            {
                if (last == null || last.Success)
                {
                    cmd.Call();
                    last = cmd;
                }
                else
                {
                    cmd.Undo();
                    break;
                }
            }
        }
    }
}