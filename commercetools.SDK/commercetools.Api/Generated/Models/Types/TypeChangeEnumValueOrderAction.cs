using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    [DiscriminatorValue("changeEnumValueOrder")]
    public partial class TypeChangeEnumValueOrderAction : TypeUpdateAction
    {
        public string FieldName { get; set;}
        
        public List<string> Keys { get; set;}
        public TypeChangeEnumValueOrderAction()
        { 
           this.Action = "changeEnumValueOrder";
        }
    }
}
