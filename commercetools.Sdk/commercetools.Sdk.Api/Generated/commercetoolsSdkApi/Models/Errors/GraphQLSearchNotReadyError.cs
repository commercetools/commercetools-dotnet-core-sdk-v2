namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLSearchNotReadyError : IGraphQLSearchNotReadyError
    {
        public string Code { get; set; }
        public GraphQLSearchNotReadyError()
        {
            this.Code = "SearchNotReady";
        }
    }
}
