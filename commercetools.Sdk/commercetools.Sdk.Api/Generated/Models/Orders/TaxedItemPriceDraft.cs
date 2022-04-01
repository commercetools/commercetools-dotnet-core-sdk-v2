using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Orders
{
    public partial class TaxedItemPriceDraft : ITaxedItemPriceDraft
    {
        public IMoney TotalNet { get; set; }

        public IMoney TotalGross { get; set; }
    }
}
