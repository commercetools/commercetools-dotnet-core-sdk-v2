using commercetools.Api.Models.Common;
using commercetools.Api.Models.CustomObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.CustomObjects
{
    [DiscriminatorValue("key-value-document")]
    public partial class CustomObjectReference : Reference
    {
        public CustomObject Obj { get; set;}
        public CustomObjectReference()
        { 
           this.TypeId = "key-value-document";
        }
    }
}
