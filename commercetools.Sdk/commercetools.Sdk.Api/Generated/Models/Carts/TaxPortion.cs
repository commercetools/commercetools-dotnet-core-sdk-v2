using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Carts
{
    public partial class TaxPortion : ITaxPortion
    {
        public string Name { get; set; }

        public double Rate { get; set; }

        public ITypedMoney Amount { get; set; }
    }
}
