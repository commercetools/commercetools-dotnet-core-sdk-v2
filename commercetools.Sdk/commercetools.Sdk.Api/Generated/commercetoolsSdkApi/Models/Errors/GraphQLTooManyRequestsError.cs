namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLTooManyRequestsError : IGraphQLTooManyRequestsError
    {
        public string Code { get; set; }
        public GraphQLTooManyRequestsError()
        {
            this.Code = "TooManyRequests";
        }
    }
}
