using commercetools.Api.Generated.Models.Carts;
using commercetools.Api.Generated.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Carts
{
    public interface ICartSetCustomLineItemCustomTypeAction : ICartUpdateAction
    {
        string CustomLineItemId { get; set;}
        
        ITypeResourceIdentifier Type { get; set;}
        
        IFieldContainer Fields { get; set;}
    }
}
