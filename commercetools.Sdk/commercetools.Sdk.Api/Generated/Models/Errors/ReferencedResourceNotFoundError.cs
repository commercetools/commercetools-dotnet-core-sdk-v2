using commercetools.Api.Models.Common;
using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    public  partial class ReferencedResourceNotFoundError : IReferencedResourceNotFoundError
    {
        public string Code { get; set;}
        
        public string Message { get; set;}
        
        public string TypeId { get; set;}
        
        [JsonIgnore]
        public ReferenceTypeId TypeIdAsEnum => this.TypeId.GetEnum<ReferenceTypeId>();
        
        public string Id { get; set;}
        
        public string Key { get; set;}
        public ReferencedResourceNotFoundError()
        { 
           this.Code = "ReferencedResourceNotFound";
        }
    }
}
