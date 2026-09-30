namespace commercetools.Sdk.Api.Models.Agents
{

    public partial class GraphQLAgentMissingEntityTypeError : IGraphQLAgentMissingEntityTypeError
    {
        public string Code { get; set; }
        public GraphQLAgentMissingEntityTypeError()
        {
            this.Code = "MissingEntityType";
        }
    }
}
