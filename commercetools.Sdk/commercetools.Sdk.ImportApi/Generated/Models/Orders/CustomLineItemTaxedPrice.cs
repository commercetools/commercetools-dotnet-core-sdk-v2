using commercetools.ImportApi.Models.Common;


namespace commercetools.ImportApi.Models.Orders
{
    public partial class CustomLineItemTaxedPrice : ICustomLineItemTaxedPrice
    {
        public ITypedMoney TotalNet { get; set;}
        
        public ITypedMoney TotalGross { get; set;}
    }
}
