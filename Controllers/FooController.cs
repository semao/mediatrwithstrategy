using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MultipleHandlers.Query;

namespace MultipleHandlers.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FooController : ControllerBase
    {
        private readonly IMediator _mediator;

        public FooController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<string> GetAsync(CancellationToken ct)
        {
            return await _mediator.Send(new FooQuery(2), ct);
        }
    }
}
