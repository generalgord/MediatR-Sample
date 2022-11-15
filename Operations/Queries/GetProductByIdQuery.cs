using MediatR;

namespace MediatRSample.Operations.Queries
{
    public class GetProductByIdQuery : IRequest<ProductDetailViewModel>
    {
        public Guid Id { get; set; }

        public GetProductByIdQuery(Guid id)
        {
            Id = id;
        }
    }

    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, ProductDetailViewModel>
    {
        public Task<ProductDetailViewModel> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            // Get product from repository
            var viewModel = new ProductDetailViewModel()
            {
                Id = Guid.NewGuid(),
                Name = "Sample Name of Product"
            };
            return Task.FromResult(viewModel);
        }
    }

    public class ProductDetailViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
