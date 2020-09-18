using commercetools.Api.Models.CartDiscounts;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    [DiscriminatorValue("setCustomType")]
    public class CartDiscountSetCustomTypeAction : CartDiscountUpdateAction
    {
        public TypeResourceIdentifier Type { get; set;}
        
        public Object Fields { get; set;}
    }
}
