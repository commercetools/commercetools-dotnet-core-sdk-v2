namespace commercetools.Sdk.Api.Models.Agents
{

    public partial class GraphQLAgentExtractionFailedError : IGraphQLAgentExtractionFailedError
    {
        public string Code { get; set; }
        public GraphQLAgentExtractionFailedError()
        {
            this.Code = "ExtractionFailed";
        }
    }
}
