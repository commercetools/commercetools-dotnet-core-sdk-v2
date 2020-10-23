using commercetools.Api.Generated.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Carts
{
    public interface ICartSetCustomFieldAction : ICartUpdateAction
    {
        string Name { get; set;}
        
        Object Value { get; set;}
    }
}
