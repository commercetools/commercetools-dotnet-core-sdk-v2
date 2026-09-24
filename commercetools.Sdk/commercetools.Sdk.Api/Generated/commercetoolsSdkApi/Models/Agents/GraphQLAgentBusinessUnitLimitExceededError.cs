namespace commercetools.Sdk.Api.Models.Agents
{

    public partial class GraphQLAgentBusinessUnitLimitExceededError : IGraphQLAgentBusinessUnitLimitExceededError
    {
        public string Code { get; set; }
        public GraphQLAgentBusinessUnitLimitExceededError()
        {
            this.Code = "BusinessUnitLimitExceeded";
        }
    }
}
