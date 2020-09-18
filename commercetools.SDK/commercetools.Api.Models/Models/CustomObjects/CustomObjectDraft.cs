using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.CustomObjects
{
    public class CustomObjectDraft 
    {
        public string Container { get; set;}
        
        public string Key { get; set;}
        
        public Object Value { get; set;}
        
        public long Version { get; set;}
    }
}
