using commercetools.Api.Models.CartDiscounts;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Api.Models.CartDiscounts.CartDiscountSetCustomTypeAction))]
    public partial interface ICartDiscountSetCustomTypeAction : ICartDiscountUpdateAction
    {
        ITypeResourceIdentifier Type { get; set;}
        
        Object Fields { get; set;}
    }
}
