using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.McpServers
{

    public partial class McpServerDraft : IMcpServerDraft
    {
        public string Key { get; set; }

        public ILocalizedString Name { get; set; }

        public ILocalizedString Description { get; set; }

        public IMcpServerState State { get; set; }

        public IMcpServerConfigDraft McpServer { get; set; }
    }
}
