namespace commercetools.Sdk.Api.Models.Agents
{

    public partial class GraphQLAgentShoppingListUnresolvedError : IGraphQLAgentShoppingListUnresolvedError
    {
        public string Code { get; set; }
        public GraphQLAgentShoppingListUnresolvedError()
        {
            this.Code = "ShoppingListUnresolved";
        }
    }
}
