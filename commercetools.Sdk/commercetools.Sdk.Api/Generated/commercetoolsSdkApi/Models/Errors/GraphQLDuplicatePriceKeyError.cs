using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLDuplicatePriceKeyError : IGraphQLDuplicatePriceKeyError
    {
        public string Code { get; set; }

        public IPrice ConflictingPrice { get; set; }
        public GraphQLDuplicatePriceKeyError()
        {
            this.Code = "DuplicatePriceKey";
        }
    }
}
