namespace commercetools.Sdk.Api.Models.Agents
{

    public partial class GraphQLAgentMissingCustomerEmailError : IGraphQLAgentMissingCustomerEmailError
    {
        public string Code { get; set; }
        public GraphQLAgentMissingCustomerEmailError()
        {
            this.Code = "MissingCustomerEmail";
        }
    }
}
