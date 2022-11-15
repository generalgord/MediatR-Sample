using MediatR;

namespace MediatRSample.Operations.Queries
{
    public class GetAllProductsQuery : IRequest<List<ProductsViewModel>>
    {
    }

    public class GetAllProductsHandlerQuery : IRequestHandler<GetAllProductsQuery, List<ProductsViewModel>>
    {
        public Task<List<ProductsViewModel>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            var viewModel = new List<ProductsViewModel>() {
                new ProductsViewModel() {
                    Id = Guid.NewGuid(),
                    Name = "Product 1"
                },
                new ProductsViewModel() {
                    Id = Guid.NewGuid(),
                    Name = "Product 2"
                },
                new ProductsViewModel() {
                    Id = Guid.NewGuid(),
                    Name = "Product 3"
                }
            };

            return Task.FromResult(viewModel);
        }
    }

    public class ProductsViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
