using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.McpServers
{

    public partial class McpServerSetNameAction : IMcpServerSetNameAction
    {
        public string Action { get; set; }

        public ILocalizedString Name { get; set; }
        public McpServerSetNameAction()
        {
            this.Action = "setName";
        }
    }
}
