using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class TaxPortion : ITaxPortion
    {
        public string Name { get; set; }

        public decimal Rate { get; set; }

        public ICentPrecisionMoney Amount { get; set; }
    }
}
