namespace DotnetDesignPatterns.Structural.Proxy.VirtualProxy
{
    public class LazyBitmap : IBitmap
    {
        private readonly string _filename;
        private Bitmap _bitmap;

        public LazyBitmap(string filename)
        {
            _filename = filename;
        }
        
        public void Draw()
        {
            if (_bitmap == null)
                _bitmap = new Bitmap(_filename);
            
            _bitmap.Draw(); 
        }
    }
}