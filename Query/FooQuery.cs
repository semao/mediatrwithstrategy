using MediatR;

namespace MultipleHandlers.Query
{
    public class FooQuery : IRequest<string>, IStrategy
    {
        public object StrategySelector { get; }

        public FooQuery(int taxonomy)
        {
            StrategySelector = taxonomy;
        }
    }
}
