using System.Threading;
using System.Threading.Tasks;

namespace MultipleHandlers.Query
{
    public interface IMyCustomStrategy<T, U>
    {
        Task<U> Handle(T request, CancellationToken cancellationToken);
    }
}
