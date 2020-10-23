using commercetools.Api.Generated.Models.OrderEdits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.OrderEdits
{
    public interface IOrderEditSetCustomFieldAction : IOrderEditUpdateAction
    {
        string Name { get; set;}
        
        Object Value { get; set;}
    }
}
