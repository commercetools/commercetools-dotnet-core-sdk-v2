namespace commercetools.Sdk.Api.Models.Agents
{

    public partial class AgentMissingShoppingListNameError : IAgentMissingShoppingListNameError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public AgentMissingShoppingListNameError()
        {
            this.Code = "MissingShoppingListName";
        }
    }
}
