using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    [DeserializeAs(typeof(commercetools.Api.Models.Types.TypeUpdate))]
    public partial interface ITypeUpdate 
    {
        long Version { get; set;}
        
        List<ITypeUpdateAction> Actions { get; set;}
    }
}
