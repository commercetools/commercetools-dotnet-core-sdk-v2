namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLExpiredCustomerPasswordTokenError : IGraphQLExpiredCustomerPasswordTokenError
    {
        public string Code { get; set; }
        public GraphQLExpiredCustomerPasswordTokenError()
        {
            this.Code = "ExpiredCustomerPasswordToken";
        }
    }
}
