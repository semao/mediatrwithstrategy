using MediatR;

namespace MultipleHandlers.Query
{
    public class FooQuery : IRequest<string>
    {
        public int Taxonomy { get; }

        public FooQuery(int taxonomy)
        {
            Taxonomy = taxonomy;
        }
    }
}
