namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLQueryTimedOutError : IGraphQLQueryTimedOutError
    {
        public string Code { get; set; }
        public GraphQLQueryTimedOutError()
        {
            this.Code = "QueryTimedOut";
        }
    }
}
