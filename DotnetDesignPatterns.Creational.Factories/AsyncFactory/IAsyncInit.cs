using System.Threading.Tasks;

namespace DotnetDesignPatterns.Creational.Factories.AsyncFactory
{
    public interface IAsyncInit<T>
    {
        Task<T> InitAsync(); 
    }
}