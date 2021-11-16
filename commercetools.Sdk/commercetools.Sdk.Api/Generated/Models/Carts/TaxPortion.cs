using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Carts
{
    public partial class TaxPortion : ITaxPortion
    {
        public string Name { get; set; }

        public double Rate { get; set; }

        public ITypedMoney Amount { get; set; }
    }
}
