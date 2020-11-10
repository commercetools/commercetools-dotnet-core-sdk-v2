using commercetools.Api.Models.Common;
using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    public partial class MaxResourceLimitExceededError : IMaxResourceLimitExceededError
    {
        public string Code { get; set;}
        
        public string Message { get; set;}
        
        public string ExceededResource { get; set;}
        
        [JsonIgnore]
        public ReferenceTypeId ExceededResourceAsEnum => this.ExceededResource.GetEnum<ReferenceTypeId>();
        public MaxResourceLimitExceededError()
        { 
           this.Code = "MaxResourceLimitExceeded";
        }
    }
}
