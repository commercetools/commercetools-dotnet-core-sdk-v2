using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CustomObjects
{
    public partial class CustomObjectDraft : ICustomObjectDraft
    {
        public string Container { get; set;}
        
        public string Key { get; set;}
        
        public Object Value { get; set;}
        
        public long? Version { get; set;}
    }
}
