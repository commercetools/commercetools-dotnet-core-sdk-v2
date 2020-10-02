using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DiscriminatorValue("ConcurrentModification")]
    public partial class ConcurrentModificationError : ErrorObject
    {
        public long CurrentVersion { get; set;}
        public ConcurrentModificationError()
        { 
           this.Code = "ConcurrentModification";
        }
    }
}
