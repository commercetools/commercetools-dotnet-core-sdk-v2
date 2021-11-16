using commercetools.ImportApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Orders
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Orders.CustomLineItemTaxedPrice))]
    public partial interface ICustomLineItemTaxedPrice 
    {
        ITypedMoney TotalNet { get; set;}
        
        ITypedMoney TotalGross { get; set;}
    }
}
