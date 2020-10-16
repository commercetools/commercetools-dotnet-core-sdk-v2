using commercetools.Api.Models.CartDiscounts;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    [DiscriminatorValue("setDescription")]
    public partial class CartDiscountSetDescriptionAction : CartDiscountUpdateAction
    {
        public LocalizedString Description { get; set;}
        public CartDiscountSetDescriptionAction()
        { 
           this.Action = "setDescription";
        }
    }
}
