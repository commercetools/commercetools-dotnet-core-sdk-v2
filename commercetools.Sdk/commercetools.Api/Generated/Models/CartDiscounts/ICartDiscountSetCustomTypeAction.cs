using commercetools.Api.Generated.Models.CartDiscounts;
using commercetools.Api.Generated.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.CartDiscounts
{
    public interface ICartDiscountSetCustomTypeAction : ICartDiscountUpdateAction
    {
        ITypeResourceIdentifier Type { get; set;}
        
        Object Fields { get; set;}
    }
}
