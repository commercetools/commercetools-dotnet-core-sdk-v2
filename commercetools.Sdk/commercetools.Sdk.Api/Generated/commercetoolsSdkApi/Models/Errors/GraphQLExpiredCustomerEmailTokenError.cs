namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLExpiredCustomerEmailTokenError : IGraphQLExpiredCustomerEmailTokenError
    {
        public string Code { get; set; }
        public GraphQLExpiredCustomerEmailTokenError()
        {
            this.Code = "ExpiredCustomerEmailToken";
        }
    }
}
