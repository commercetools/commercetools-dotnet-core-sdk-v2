namespace commercetools.Sdk.Api.Models.Agents
{

    public partial class AgentShoppingListUnresolvedError : IAgentShoppingListUnresolvedError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public AgentShoppingListUnresolvedError()
        {
            this.Code = "ShoppingListUnresolved";
        }
    }
}
