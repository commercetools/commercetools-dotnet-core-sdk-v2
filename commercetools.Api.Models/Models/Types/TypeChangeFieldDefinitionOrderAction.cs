using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Types
{
    public class TypeChangeFieldDefinitionOrderAction : TypeUpdateAction
    {
        public List<string> FieldNames { get; set;}
    }
}
