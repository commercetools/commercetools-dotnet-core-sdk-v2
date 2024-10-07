using commercetools.Sdk.Api.Models.Common;

namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLDuplicatePriceScopeError : IGraphQLDuplicatePriceScopeError
    {
        public string Code { get; set; }

        public IPrice ConflictingPrice { get; set; }
        public GraphQLDuplicatePriceScopeError()
        {
            this.Code = "DuplicatePriceScope";
        }
    }
}
