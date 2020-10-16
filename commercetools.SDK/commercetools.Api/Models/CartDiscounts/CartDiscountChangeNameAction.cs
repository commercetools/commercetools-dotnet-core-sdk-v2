using commercetools.Api.Models.CartDiscounts;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    [DiscriminatorValue("changeName")]
    public partial class CartDiscountChangeNameAction : CartDiscountUpdateAction
    {
        public LocalizedString Name { get; set;}
        public CartDiscountChangeNameAction()
        { 
           this.Action = "changeName";
        }
    }
}
