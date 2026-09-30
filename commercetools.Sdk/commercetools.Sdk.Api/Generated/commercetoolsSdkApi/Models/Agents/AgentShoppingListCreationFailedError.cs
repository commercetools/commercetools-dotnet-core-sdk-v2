namespace commercetools.Sdk.Api.Models.Agents
{

    public partial class AgentShoppingListCreationFailedError : IAgentShoppingListCreationFailedError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public AgentShoppingListCreationFailedError()
        {
            this.Code = "ShoppingListCreationFailed";
        }
    }
}
