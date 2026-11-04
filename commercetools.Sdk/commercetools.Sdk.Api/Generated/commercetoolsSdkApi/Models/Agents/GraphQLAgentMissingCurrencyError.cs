namespace commercetools.Sdk.Api.Models.Agents
{

    public partial class GraphQLAgentMissingCurrencyError : IGraphQLAgentMissingCurrencyError
    {
        public string Code { get; set; }
        public GraphQLAgentMissingCurrencyError()
        {
            this.Code = "MissingCurrency";
        }
    }
}
