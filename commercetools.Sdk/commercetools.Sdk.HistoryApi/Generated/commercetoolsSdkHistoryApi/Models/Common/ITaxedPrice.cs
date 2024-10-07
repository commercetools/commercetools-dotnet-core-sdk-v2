using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.TaxedPrice))]
    public partial interface ITaxedPrice
    {
        IMoney TotalNet { get; set; }

        IMoney TotalGross { get; set; }

    }
}
