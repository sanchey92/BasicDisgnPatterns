using System;

namespace SOLID_LSP
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            var rc = new Rectangle(3, 2);
            Demo.UseIt(rc);

            var sq = new Square(5);
            Demo.UseIt(sq);
        }
    }
}