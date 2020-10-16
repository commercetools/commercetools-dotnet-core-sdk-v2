using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DiscriminatorValue("cart")]
    public partial class CartResourceIdentifier : ResourceIdentifier
    {
        public CartResourceIdentifier()
        { 
           this.TypeId = "cart";
        }
    }
}
