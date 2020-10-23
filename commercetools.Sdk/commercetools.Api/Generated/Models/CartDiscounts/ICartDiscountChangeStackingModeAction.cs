using commercetools.Api.Generated.Models.CartDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.CartDiscounts
{
    public interface ICartDiscountChangeStackingModeAction : ICartDiscountUpdateAction
    {
        string StackingMode { get; set;}
        
        StackingMode StackingModeAsEnum { get; }
    }
}
