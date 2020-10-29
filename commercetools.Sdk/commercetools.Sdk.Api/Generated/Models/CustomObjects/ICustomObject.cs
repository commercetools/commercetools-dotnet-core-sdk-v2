using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CustomObjects
{
    [DeserializeAs(typeof(commercetools.Api.Models.CustomObjects.CustomObject))]
    public interface ICustomObject : IBaseResource
    {
        string Id { get; set;}
        
        long Version { get; set;}
        
        DateTime CreatedAt { get; set;}
        
        DateTime LastModifiedAt { get; set;}
        
        ILastModifiedBy LastModifiedBy { get; set;}
        
        ICreatedBy CreatedBy { get; set;}
        
        string Container { get; set;}
        
        string Key { get; set;}
        
        Object Value { get; set;}
    }
}
