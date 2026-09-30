namespace commercetools.Sdk.Api.Models.Agents
{

    public partial class GraphQLAgentShoppingListCreationFailedError : IGraphQLAgentShoppingListCreationFailedError
    {
        public string Code { get; set; }
        public GraphQLAgentShoppingListCreationFailedError()
        {
            this.Code = "ShoppingListCreationFailed";
        }
    }
}
