using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.TaxedItemPrice))]
    public partial interface ITaxedItemPrice
    {
        IMoney TotalNet { get; set; }

        IMoney TotalGross { get; set; }

    }
}
