using commercetools.Api.Generated.Models.OrderEdits;
using commercetools.Api.Generated.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.OrderEdits
{
    public interface IOrderEditSetCustomTypeAction : IOrderEditUpdateAction
    {
        ITypeResourceIdentifier Type { get; set;}
        
        Object Fields { get; set;}
    }
}
