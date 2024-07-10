namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLQueryComplexityLimitExceededError : IGraphQLQueryComplexityLimitExceededError
    {
        public string Code { get; set; }
        public GraphQLQueryComplexityLimitExceededError()
        {
            this.Code = "QueryComplexityLimitExceeded";
        }
    }
}
