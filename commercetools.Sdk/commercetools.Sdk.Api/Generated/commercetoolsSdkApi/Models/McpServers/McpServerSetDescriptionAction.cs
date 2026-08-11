using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.McpServers
{

    public partial class McpServerSetDescriptionAction : IMcpServerSetDescriptionAction
    {
        public string Action { get; set; }

        public ILocalizedString Description { get; set; }
        public McpServerSetDescriptionAction()
        {
            this.Action = "setDescription";
        }
    }
}
