namespace commercetools.Sdk.Api.Models.Agents
{

    public partial class GraphQLAgentNoLineItemsExtractedError : IGraphQLAgentNoLineItemsExtractedError
    {
        public string Code { get; set; }
        public GraphQLAgentNoLineItemsExtractedError()
        {
            this.Code = "NoLineItemsExtracted";
        }
    }
}
