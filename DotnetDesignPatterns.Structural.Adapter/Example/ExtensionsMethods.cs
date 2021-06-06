namespace DotnetDesignPatterns.Structural.Adapter.Example
{
    public static class ExtensionsMethods
    {
        public static int Area(this IRectangle rc)
        {
            return rc.Width * rc.Height;
        }
    }
}