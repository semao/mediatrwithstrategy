using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MultipleHandlers.Query
{
    public class FooQueryHandlerFactory : IRequestHandler<FooQuery, string>
    {
        private readonly Func<FooQuery, IMyCustomStrategy<FooQuery, string>> _factory;

        public FooQueryHandlerFactory(Func<FooQuery, IMyCustomStrategy<FooQuery, string>> factory)
        {
            _factory = factory;
        }

        public async Task<string> Handle(FooQuery request, CancellationToken cancellationToken)
        {
            return await _factory(request).Handle(request, cancellationToken);
        }
    }
}
