using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.ShippingMethods;
using commercetools.Api.Models.TaxCategories;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.ShippingInfoImportDraft))]
    public partial interface IShippingInfoImportDraft 
    {
        string ShippingMethodName { get; set;}
        
        IMoney Price { get; set;}
        
        IShippingRateDraft ShippingRate { get; set;}
        
        ITaxRate TaxRate { get; set;}
        
        ITaxCategoryResourceIdentifier TaxCategory { get; set;}
        
        IShippingMethodResourceIdentifier ShippingMethod { get; set;}
        
        List<IDelivery> Deliveries { get; set;}
        
        IDiscountedLineItemPriceDraft DiscountedPrice { get; set;}
        
        IShippingMethodState ShippingMethodState { get; set;}
    }
}
