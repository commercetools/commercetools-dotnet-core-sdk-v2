using commercetools.Api.Models.Common;
using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    public  partial class ReferenceExistsError : IReferenceExistsError
    {
        public string Code { get; set;}
        
        public string Message { get; set;}
        
        public string ReferencedBy { get; set;}
        
        [JsonIgnore]
        public ReferenceTypeId ReferencedByAsEnum => this.ReferencedBy.GetEnum<ReferenceTypeId>();
        public ReferenceExistsError()
        { 
           this.Code = "ReferenceExists";
        }
    }
}
