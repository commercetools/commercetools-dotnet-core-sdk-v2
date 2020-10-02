using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DiscriminatorValue("addDiscountCode")]
    public partial class CartAddDiscountCodeAction : CartUpdateAction
    {
        public string Code { get; set;}
        public CartAddDiscountCodeAction()
        { 
           this.Action = "addDiscountCode";
        }
    }
}
