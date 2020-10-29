using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Common
{
    [DeserializeAs(typeof(commercetools.Api.Models.Common.BaseResource))]
    public interface IBaseResource 
    {
        string Id { get; set;}
        
        long Version { get; set;}
        
        DateTime CreatedAt { get; set;}
        
        DateTime LastModifiedAt { get; set;}
    }
}
