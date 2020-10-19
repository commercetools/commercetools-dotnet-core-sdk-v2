using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DiscriminatorValue("cart")]
    public partial class CartReference : Reference
    {
        public Cart Obj { get; set;}
        public CartReference()
        { 
           this.TypeId = "cart";
        }
    }
}
