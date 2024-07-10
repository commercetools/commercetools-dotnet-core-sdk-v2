using commercetools.Sdk.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class DiscountedLineItemPriceForQuantity : IDiscountedLineItemPriceForQuantity
    {
        public long Quantity { get; set; }

        public IDiscountedLineItemPrice DiscountedPrice { get; set; }
    }
}
