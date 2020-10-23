using commercetools.Api.Models.CartDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    public  partial class CartDiscountChangeStackingModeAction : ICartDiscountChangeStackingModeAction
    {
        public string Action { get; set;}
        
        public string StackingMode { get; set;}
        
        [JsonIgnore]
        public StackingMode StackingModeAsEnum => this.StackingMode.GetEnum<StackingMode>();
        public CartDiscountChangeStackingModeAction()
        { 
           this.Action = "changeStackingMode";
        }
    }
}
