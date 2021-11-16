using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Carts
{
    public partial class TaxedItemPrice : ITaxedItemPrice
    {
        public ITypedMoney TotalNet { get; set;}
        
        public ITypedMoney TotalGross { get; set;}
    }
}
