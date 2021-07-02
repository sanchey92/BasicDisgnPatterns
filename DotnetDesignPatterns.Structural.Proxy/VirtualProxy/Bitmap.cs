using System;

namespace DotnetDesignPatterns.Structural.Proxy.VirtualProxy
{
    public class Bitmap : IBitmap
    {
        private readonly string _filename;
        
        public Bitmap(string filename)
        {
            _filename = filename;
            Console.WriteLine($"Loading image from {filename}");
        }

        public void Draw()
        {
            Console.WriteLine($"Drawing image {_filename}");
        }
    }
}