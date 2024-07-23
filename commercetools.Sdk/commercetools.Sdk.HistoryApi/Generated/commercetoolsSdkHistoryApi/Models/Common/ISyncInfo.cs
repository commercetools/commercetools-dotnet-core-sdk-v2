using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.SyncInfo))]
    public partial interface ISyncInfo
    {
        IReference Channel { get; set; }

        string ExternalId { get; set; }

        string SyncedAt { get; set; }

    }
}
