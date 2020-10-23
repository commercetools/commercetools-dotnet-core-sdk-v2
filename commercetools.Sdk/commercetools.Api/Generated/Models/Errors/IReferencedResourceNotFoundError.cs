using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Errors
{
    public interface IReferencedResourceNotFoundError : IErrorObject
    {
        string TypeId { get; set;}
        
        ReferenceTypeId TypeIdAsEnum { get; }
        
        string Id { get; set;}
        
        string Key { get; set;}
    }
}
