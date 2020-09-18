using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    [DiscriminatorValue("Set")]
    public class CustomFieldSetType : FieldType
    {
        public FieldType ElementType { get; set;}
    }
}
