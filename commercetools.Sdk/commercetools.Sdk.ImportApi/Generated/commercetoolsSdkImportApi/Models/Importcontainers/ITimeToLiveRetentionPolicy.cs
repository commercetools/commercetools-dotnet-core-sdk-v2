using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Importcontainers
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Importcontainers.TimeToLiveRetentionPolicy))]
    public partial interface ITimeToLiveRetentionPolicy : IRetentionPolicy
    {
        ITimeToLiveConfig Config { get; set; }

    }
}
