namespace commercetools.Sdk.Api.Models.Agents
{

    public partial class GraphQLAgentBusinessUnitUnresolvedError : IGraphQLAgentBusinessUnitUnresolvedError
    {
        public string Code { get; set; }
        public GraphQLAgentBusinessUnitUnresolvedError()
        {
            this.Code = "BusinessUnitUnresolved";
        }
    }
}
