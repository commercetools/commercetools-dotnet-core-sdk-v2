using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class TaxedItemPrice : ITaxedItemPrice
    {
        public ICentPrecisionMoney TotalNet { get; set; }

        public ICentPrecisionMoney TotalGross { get; set; }

        public ICentPrecisionMoney TotalTax { get; set; }
    }
}
