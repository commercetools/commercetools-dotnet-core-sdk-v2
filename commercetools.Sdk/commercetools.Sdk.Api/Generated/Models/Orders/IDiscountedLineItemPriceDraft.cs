using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.DiscountedLineItemPriceDraft))]
    public partial interface IDiscountedLineItemPriceDraft 
    {
        IMoney Value { get; set;}
        
        List<IDiscountedLineItemPortion> IncludedDiscounts { get; set;}
    }
}
