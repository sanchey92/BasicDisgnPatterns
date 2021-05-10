namespace SOLID_ISP
{
    // Bad
    public interface IMachine
    {
        void Print(Document document);
        void Fax(Document document);
        void Scan(Document document);
    }
}