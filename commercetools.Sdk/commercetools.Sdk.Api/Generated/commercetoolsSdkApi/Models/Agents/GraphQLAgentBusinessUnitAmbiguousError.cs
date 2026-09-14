namespace commercetools.Sdk.Api.Models.Agents
{

    public partial class GraphQLAgentBusinessUnitAmbiguousError : IGraphQLAgentBusinessUnitAmbiguousError
    {
        public string Code { get; set; }
        public GraphQLAgentBusinessUnitAmbiguousError()
        {
            this.Code = "BusinessUnitAmbiguous";
        }
    }
}
