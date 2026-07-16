using commercetools.Base.CustomAttributes;
using System;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.McpServers
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.McpServers.McpServerConfigDraft))]
    [SubTypeDiscriminator("CommerceMCP", typeof(commercetools.Sdk.Api.Models.McpServers.CommerceMcpServerConfigDraft))]
    public partial interface IMcpServerConfigDraft
    {
        string Type { get; set; }

        static commercetools.Sdk.Api.Models.McpServers.CommerceMcpServerConfigDraft CommerceMcp(Action<commercetools.Sdk.Api.Models.McpServers.CommerceMcpServerConfigDraft> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.McpServers.CommerceMcpServerConfigDraft();
            init?.Invoke(t);
            return t;
        }
    }
}
