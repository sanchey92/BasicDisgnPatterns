namespace Behavioral.Command.CompositeCommand
{
    public interface ICommand
    {
        void Call();
        void Undo();
        bool Success { get; set; }
    }
}