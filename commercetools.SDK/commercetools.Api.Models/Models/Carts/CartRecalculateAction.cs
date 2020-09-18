using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DiscriminatorValue("recalculate")]
    public class CartRecalculateAction : CartUpdateAction
    {
        public bool UpdateProductData { get; set;}
    }
}
