using commercetools.Api.Models.Common;
using commercetools.Api.Models.CustomObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.CustomObjects
{
    [DiscriminatorValue("key-value-document")]
    public class CustomObjectReference : Reference
    {
        public CustomObject Obj { get; set;}
    }
}
