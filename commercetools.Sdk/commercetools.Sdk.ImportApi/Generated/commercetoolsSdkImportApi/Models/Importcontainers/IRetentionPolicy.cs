using commercetools.Base.CustomAttributes;
using System;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Importcontainers
{
    [TypeDiscriminator(nameof(Strategy))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.ImportApi.Models.Importcontainers.RetentionPolicy))]
    [SubTypeDiscriminator("ttl", typeof(commercetools.Sdk.ImportApi.Models.Importcontainers.TimeToLiveRetentionPolicy))]
    public partial interface IRetentionPolicy
    {
        IStrategyEnum Strategy { get; set; }

        static commercetools.Sdk.ImportApi.Models.Importcontainers.TimeToLiveRetentionPolicy Ttl(Action<commercetools.Sdk.ImportApi.Models.Importcontainers.TimeToLiveRetentionPolicy> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Importcontainers.TimeToLiveRetentionPolicy();
            init?.Invoke(t);
            return t;
        }
    }
}
