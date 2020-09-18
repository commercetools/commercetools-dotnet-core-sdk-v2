using commercetools.Api.Models.CartDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    [DiscriminatorValue("changeStackingMode")]
    public class CartDiscountChangeStackingModeAction : CartDiscountUpdateAction
    {
        public string StackingMode { get; set;}
        
        public StackingMode StackingModeAsEnum => this.StackingMode.GetEnum<StackingMode>();
    }
}
