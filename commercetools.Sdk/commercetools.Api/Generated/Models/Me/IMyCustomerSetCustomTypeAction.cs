using commercetools.Api.Generated.Models.Me;
using commercetools.Api.Generated.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Me
{
    public interface IMyCustomerSetCustomTypeAction : IMyCustomerUpdateAction
    {
        ITypeResourceIdentifier Type { get; set;}
        
        IFieldContainer Fields { get; set;}
    }
}
