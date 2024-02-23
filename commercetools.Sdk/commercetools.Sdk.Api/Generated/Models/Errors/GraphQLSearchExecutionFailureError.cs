namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLSearchExecutionFailureError : IGraphQLSearchExecutionFailureError
    {
        public string Code { get; set; }
        public GraphQLSearchExecutionFailureError()
        {
            this.Code = "SearchExecutionFailure";
        }
    }
}
