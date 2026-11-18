using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.ChangeHistories
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.ChangeHistories.Attribution))]
    public partial interface IAttribution
    {
        string ClientId { get; set; }

        IAttributionSource Source { get; set; }

    }
}
