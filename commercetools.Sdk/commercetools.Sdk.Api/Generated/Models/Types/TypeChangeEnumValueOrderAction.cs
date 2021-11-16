using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    public partial class TypeChangeEnumValueOrderAction : ITypeChangeEnumValueOrderAction
    {
        public string Action { get; set;}
        
        public string FieldName { get; set;}
        
        public List<string> Keys { get; set;}
        public TypeChangeEnumValueOrderAction()
        { 
           this.Action = "changeEnumValueOrder";
        }
    }
}
