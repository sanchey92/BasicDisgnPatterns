using System;

namespace Behavioral.Interpreter.Handmade
{
    public class BinaryOperation : IElement
    {
        public enum Type
        {
            Addition, Subtraction
        }

        public Type MyType;
        public IElement Left, Right;

        public int Value
        {
            get
            {
                switch (MyType)
                {
                    case Type.Addition:
                        return Left.Value + Right.Value;
                        break;
                    case Type.Subtraction:
                        return Left.Value - Right.Value;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                } 
            }
        }
    }
}