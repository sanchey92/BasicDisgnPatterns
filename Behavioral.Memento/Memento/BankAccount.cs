using System.Collections.Generic;

namespace Behavioral.Memento.Memento
{
    public class BankAccount
    {
        private int _balance;
        private List<Memento> _changes = new List<Memento>();
        private int _currentIndex;

        public BankAccount(int balance)
        {
            _balance = balance;
            _changes.Add(new Memento(balance));
        }

        public void Restore(Memento memento)
        {
            if (memento == null) return;
            _balance = memento.Balance;
            _changes.Add(memento);
            _currentIndex = _changes.Count - 1;
        }

        public Memento Deposit(int amount)
        {
            _balance += amount;
            var memento = new Memento(_balance);
            _changes.Add(memento);
            ++_currentIndex;
            return memento;
        }

        public Memento Undo()
        {
            if (_currentIndex <= 0) return null;
            var memento = _changes[--_currentIndex];
            _balance = memento.Balance;
            return memento;

        }

        public Memento Redo()
        {
            if (_currentIndex + 1 >= _changes.Count) return null;
            var memento = _changes[++_currentIndex];
            _balance = memento.Balance;
            return memento;

        }

        public override string ToString()
        {
            return $"{nameof(_balance)}: {_balance}";
        }
    }
}