namespace commercetools.Sdk.Api.Models.Agents
{

    public partial class GraphQLAgentOutOfScopeError : IGraphQLAgentOutOfScopeError
    {
        public string Code { get; set; }
        public GraphQLAgentOutOfScopeError()
        {
            this.Code = "OutOfScope";
        }
    }
}
