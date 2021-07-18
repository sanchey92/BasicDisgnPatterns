using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Behavioral.Command.CompositeCommand
{
    public class CompositeBankAccountCommand : List<BankAccountCommand>, ICommand
    {
        public CompositeBankAccountCommand()
        {
        }

        public CompositeBankAccountCommand(
            [NotNull] IEnumerable<BankAccountCommand> collection) : base(collection)
        {
        }

        public bool Success { get; set; }

        public virtual void Call()
        {
            Success = true;
            ForEach(cmd =>
            {
                cmd.Call();
                Success &= cmd.Success;
            });
        }

        public virtual void Undo()
        {
            foreach (var cmd in ((IEnumerable<BankAccountCommand>)this).Reverse())
            {
                cmd.Undo();
            }
        }
    }
}