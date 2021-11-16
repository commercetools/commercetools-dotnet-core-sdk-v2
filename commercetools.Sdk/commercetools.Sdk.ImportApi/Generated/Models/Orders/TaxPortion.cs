using commercetools.ImportApi.Models.Common;


namespace commercetools.ImportApi.Models.Orders
{
    public partial class TaxPortion : ITaxPortion
    {
        public string Name { get; set;}
        
        public double Rate { get; set;}
        
        public ITypedMoney Amount { get; set;}
    }
}
