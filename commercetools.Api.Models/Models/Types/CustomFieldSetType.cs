using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Types
{
    public class CustomFieldSetType : FieldType
    {
        public FieldType ElementType { get; set;}
    }
}
