using System;

namespace DotnetDesignPatterns.Structural.Proxy.VirtualProxy
{
    public static class Drawer
    {
        public static void DrawImage(IBitmap img)
        {
            Console.WriteLine("About to draw image");
            img.Draw();
            Console.WriteLine("Done drawing image");
        }
    }
}