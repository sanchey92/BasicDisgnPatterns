using System.Threading.Tasks;

namespace DotnetDesignPatterns.Creational.Factories.AsyncFactory
{
    public class AsyncFactory
    {
        public static async Task<T> Create<T>() where T : IAsyncInit<T>, new()
        {
            return await new T().InitAsync();
        }
    }
}