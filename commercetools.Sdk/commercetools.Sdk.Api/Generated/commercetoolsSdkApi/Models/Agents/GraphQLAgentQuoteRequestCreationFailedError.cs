namespace commercetools.Sdk.Api.Models.Agents
{

    public partial class GraphQLAgentQuoteRequestCreationFailedError : IGraphQLAgentQuoteRequestCreationFailedError
    {
        public string Code { get; set; }

        public string CartId { get; set; }
        public GraphQLAgentQuoteRequestCreationFailedError()
        {
            this.Code = "QuoteRequestCreationFailed";
        }
    }
}
