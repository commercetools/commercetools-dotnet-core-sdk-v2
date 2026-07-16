using commercetools.Base.CustomAttributes;
using System;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.McpServers
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.McpServers.McpServerConfig))]
    [SubTypeDiscriminator("CommerceMCP", typeof(commercetools.Sdk.Api.Models.McpServers.CommerceMcpServerConfig))]
    public partial interface IMcpServerConfig
    {
        string Type { get; set; }

        static commercetools.Sdk.Api.Models.McpServers.CommerceMcpServerConfig CommerceMcp(Action<commercetools.Sdk.Api.Models.McpServers.CommerceMcpServerConfig> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.McpServers.CommerceMcpServerConfig();
            init?.Invoke(t);
            return t;
        }
    }
}
