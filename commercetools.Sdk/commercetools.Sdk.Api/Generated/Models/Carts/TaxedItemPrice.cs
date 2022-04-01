using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Carts
{
    public partial class TaxedItemPrice : ITaxedItemPrice
    {
        public ITypedMoney TotalNet { get; set; }

        public ITypedMoney TotalGross { get; set; }
    }
}
