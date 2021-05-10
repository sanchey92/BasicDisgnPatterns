using System;

namespace SOLID_ISP
{
    public class OldFashionedPrinter : IMachine
    {
        public void Print(Document document)
        {
            // ok
        }

        public void Fax(Document document)
        {
            throw new System.NotImplementedException();
        }

        [Obsolete("Not supported", true)]
        public void Scan(Document document)
        {
            //
        }
    }
}