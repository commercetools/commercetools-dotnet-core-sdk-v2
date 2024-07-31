using commercetools.Sdk.Api.Models.Products;

namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLProductAssignmentMissingError : IGraphQLProductAssignmentMissingError
    {
        public string Code { get; set; }

        public IProductReference Product { get; set; }
        public GraphQLProductAssignmentMissingError()
        {
            this.Code = "ProductAssignmentMissing";
        }
    }
}
