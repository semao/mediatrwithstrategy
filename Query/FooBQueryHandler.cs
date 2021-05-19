﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MultipleHandlers.Query
{
    public class FooBQueryHandler : IMyCustomStrategy<FooQuery, string>
    {
        public Task<string> Handle(FooQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult("hej foo b");
        }
    }
} 