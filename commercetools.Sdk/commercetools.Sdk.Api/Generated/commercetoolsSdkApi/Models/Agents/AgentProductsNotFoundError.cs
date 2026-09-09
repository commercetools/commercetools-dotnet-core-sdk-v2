namespace commercetools.Sdk.Api.Models.Agents
{

    public partial class AgentProductsNotFoundError : IAgentProductsNotFoundError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public AgentProductsNotFoundError()
        {
            this.Code = "ProductsNotFound";
        }
    }
}
