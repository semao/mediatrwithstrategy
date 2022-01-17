using Autofac;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MultipleHandlers
{
    public class StrategyRequestHandler<TRequest, TResponse> : IRequestHandler<TRequest, TResponse>
        where TRequest : IRequest<TResponse>, IStrategy
    {
        private readonly IComponentContext context;

        public StrategyRequestHandler(IComponentContext context)
        {
            this.context = context;
        }

        public Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken)
        {
            var selector = request.StrategySelector;
            return context.ResolveKeyed<IRequestHandler<TRequest, TResponse>>(selector).Handle(request, cancellationToken);
        }
    }
}
