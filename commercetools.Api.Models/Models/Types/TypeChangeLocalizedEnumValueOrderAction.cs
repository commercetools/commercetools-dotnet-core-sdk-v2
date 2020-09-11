using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Types
{
    public class TypeChangeLocalizedEnumValueOrderAction : TypeUpdateAction
    {
        public string FieldName { get; set;}
        
        public List<string> Keys { get; set;}
    }
}
