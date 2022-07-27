namespace commercetools.Sdk.Api.Models.GraphQl
{

    public partial class GraphQLRequest : IGraphQLRequest
    {
        public string Query { get; set; }

        public string OperationName { get; set; }

        public IGraphQLVariablesMap Variables { get; set; }
    }
}
