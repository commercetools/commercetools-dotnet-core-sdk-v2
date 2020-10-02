using commercetools.Api.Models.Common;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    [DiscriminatorValue("type")]
    public partial class TypeReference : Reference
    {
        public Type Obj { get; set;}
        public TypeReference()
        { 
           this.TypeId = "type";
        }
    }
}
