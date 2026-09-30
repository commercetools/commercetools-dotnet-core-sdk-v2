namespace commercetools.Sdk.Api.Models.Agents
{

    public partial class GraphQLAgentFeatureDisabledError : IGraphQLAgentFeatureDisabledError
    {
        public string Code { get; set; }
        public GraphQLAgentFeatureDisabledError()
        {
            this.Code = "FeatureDisabled";
        }
    }
}
