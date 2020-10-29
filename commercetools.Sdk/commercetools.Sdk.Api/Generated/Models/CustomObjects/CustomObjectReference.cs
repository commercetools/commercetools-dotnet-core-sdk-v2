using commercetools.Api.Models.Common;
using commercetools.Api.Models.CustomObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CustomObjects
{
    public partial class CustomObjectReference : ICustomObjectReference
    {
        public string TypeId { get; set;}
        
        [JsonIgnore]
        public ReferenceTypeId TypeIdAsEnum => this.TypeId.GetEnum<ReferenceTypeId>();
        
        public string Id { get; set;}
        
        public ICustomObject Obj { get; set;}
        public CustomObjectReference()
        { 
           this.TypeId = "key-value-document";
        }
    }
}
