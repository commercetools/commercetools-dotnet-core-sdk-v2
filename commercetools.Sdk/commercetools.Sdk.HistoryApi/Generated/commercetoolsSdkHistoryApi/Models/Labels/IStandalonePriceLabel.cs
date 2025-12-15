using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Labels
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Labels.StandalonePriceLabel))]
    public partial interface IStandalonePriceLabel : ILabel
    {
        new string Type { get; set; }

        string Key { get; set; }

        string Sku { get; set; }

    }
}
