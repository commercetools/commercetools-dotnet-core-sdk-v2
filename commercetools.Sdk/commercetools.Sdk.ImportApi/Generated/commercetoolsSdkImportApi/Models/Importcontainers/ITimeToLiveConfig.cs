using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Importcontainers
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Importcontainers.TimeToLiveConfig))]
    public partial interface ITimeToLiveConfig
    {
        string TimeToLive { get; set; }

    }
}
