using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DiscriminatorValue("recalculate")]
    public partial class CartRecalculateAction : CartUpdateAction
    {
        public bool UpdateProductData { get; set;}
        public CartRecalculateAction()
        { 
           this.Action = "recalculate";
        }
    }
}
