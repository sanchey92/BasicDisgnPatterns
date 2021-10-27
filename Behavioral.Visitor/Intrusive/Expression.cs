using System.Text;

namespace Behavioral.Visitor.Intrusive
{
    public abstract class Expression
    {
        public abstract void Print(StringBuilder stringBuilder);
    }
}