using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;


namespace commercetools.Api.Models.CustomObjects
{
    public partial class CustomObjectDraft 
    {
        public string Container { get; set;}
        
        public string Key { get; set;}
        
        public Object Value { get; set;}
        
        public long Version { get; set;}
    }
}
