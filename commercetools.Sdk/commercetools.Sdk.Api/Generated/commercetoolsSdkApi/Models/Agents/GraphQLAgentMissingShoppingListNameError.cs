namespace commercetools.Sdk.Api.Models.Agents
{

    public partial class GraphQLAgentMissingShoppingListNameError : IGraphQLAgentMissingShoppingListNameError
    {
        public string Code { get; set; }
        public GraphQLAgentMissingShoppingListNameError()
        {
            this.Code = "MissingShoppingListName";
        }
    }
}
