namespace commercetools.Sdk.Api.Models.Agents
{

    public partial class GraphQLAgentMissingCountryError : IGraphQLAgentMissingCountryError
    {
        public string Code { get; set; }
        public GraphQLAgentMissingCountryError()
        {
            this.Code = "MissingCountry";
        }
    }
}
