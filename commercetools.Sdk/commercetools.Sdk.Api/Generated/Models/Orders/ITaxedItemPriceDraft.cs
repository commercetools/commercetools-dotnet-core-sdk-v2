using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.TaxedItemPriceDraft))]
    public partial interface ITaxedItemPriceDraft 
    {
        IMoney TotalNet { get; set;}
        
        IMoney TotalGross { get; set;}
    }
}
