using commercetools.Sdk.ImportApi.Models.Common;


namespace commercetools.Sdk.ImportApi.Models.Orders
{

    public partial class TaxPortion : ITaxPortion
    {
        public string Name { get; set; }

        public decimal Rate { get; set; }

        public ITypedMoney Amount { get; set; }
    }
}
