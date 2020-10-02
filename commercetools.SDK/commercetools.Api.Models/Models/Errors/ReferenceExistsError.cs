using commercetools.Api.Models.Common;
using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DiscriminatorValue("ReferenceExists")]
    public partial class ReferenceExistsError : ErrorObject
    {
        public string ReferencedBy { get; set;}
        
        [JsonIgnore]
        public ReferenceTypeId ReferencedByAsEnum => this.ReferencedBy.GetEnum<ReferenceTypeId>();
        public ReferenceExistsError()
        { 
           this.Code = "ReferenceExists";
        }
    }
}
