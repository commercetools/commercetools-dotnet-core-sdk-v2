namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLNoMatchingProductDiscountFoundError : IGraphQLNoMatchingProductDiscountFoundError
    {
        public string Code { get; set; }
        public GraphQLNoMatchingProductDiscountFoundError()
        {
            this.Code = "NoMatchingProductDiscountFound";
        }
    }
}
