using commercetools.Api.Generated.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Common
{
    public interface IReference 
    {
        string TypeId { get; set;}
        
        ReferenceTypeId TypeIdAsEnum { get; }
        
        string Id { get; set;}
    }
}
