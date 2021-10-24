using System.Text;

namespace Behavioral.Strategy.DynamicStrategy
{
    public interface IListStrategy
    {
        void Start(StringBuilder stringBuilder);
        void End(StringBuilder stringBuilder);
        void AddListItem(StringBuilder stringBuilder, string item);
    }
}