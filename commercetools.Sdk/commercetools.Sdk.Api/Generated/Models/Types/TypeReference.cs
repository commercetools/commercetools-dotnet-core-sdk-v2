using commercetools.Api.Models.Common;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    public partial class TypeReference : ITypeReference
    {
        public IReferenceTypeId TypeId { get; set;}
        
        public string Id { get; set;}
        
        public IType Obj { get; set;}
        public TypeReference()
        { 
           this.TypeId = IReferenceTypeId.FindEnum("type");
        }
    }
}
