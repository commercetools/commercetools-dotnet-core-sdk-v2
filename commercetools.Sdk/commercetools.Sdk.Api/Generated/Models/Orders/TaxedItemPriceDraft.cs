using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Orders
{
    public partial class TaxedItemPriceDraft : ITaxedItemPriceDraft
    {
        public IMoney TotalNet { get; set; }

        public IMoney TotalGross { get; set; }
    }
}
