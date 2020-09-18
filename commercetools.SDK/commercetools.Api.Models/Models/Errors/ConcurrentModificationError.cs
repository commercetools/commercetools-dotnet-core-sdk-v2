using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DiscriminatorValue("ConcurrentModification")]
    public class ConcurrentModificationError : ErrorObject
    {
        public long CurrentVersion { get; set;}
    }
}
