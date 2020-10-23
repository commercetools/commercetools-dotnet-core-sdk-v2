using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.CustomObjects
{
    public interface ICustomObjectDraft 
    {
        string Container { get; set;}
        
        string Key { get; set;}
        
        Object Value { get; set;}
        
        long Version { get; set;}
    }
}
