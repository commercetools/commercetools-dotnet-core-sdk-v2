using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetPriceKeyChange))]
    public partial interface ISetPriceKeyChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        string CatalogData { get; set; }

        string Variant { get; set; }

        string PriceId { get; set; }

        string PreviousValue { get; set; }

        string NextValue { get; set; }

    }
}
