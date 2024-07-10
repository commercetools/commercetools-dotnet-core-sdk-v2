namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLSearchIndexingInProgressError : IGraphQLSearchIndexingInProgressError
    {
        public string Code { get; set; }
        public GraphQLSearchIndexingInProgressError()
        {
            this.Code = "SearchIndexingInProgress";
        }
    }
}
