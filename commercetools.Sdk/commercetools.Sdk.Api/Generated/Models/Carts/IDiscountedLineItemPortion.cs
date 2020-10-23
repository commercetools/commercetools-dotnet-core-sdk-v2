using commercetools.Api.Models.CartDiscounts;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.DiscountedLineItemPortion))]
    public interface IDiscountedLineItemPortion 
    {
        ICartDiscountReference Discount { get; set;}
        
        ITypedMoney DiscountedAmount { get; set;}
    }
}
