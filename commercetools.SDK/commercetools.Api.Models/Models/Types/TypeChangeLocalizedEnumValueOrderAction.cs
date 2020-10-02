using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    [DiscriminatorValue("changeLocalizedEnumValueOrder")]
    public partial class TypeChangeLocalizedEnumValueOrderAction : TypeUpdateAction
    {
        public string FieldName { get; set;}
        
        public List<string> Keys { get; set;}
        public TypeChangeLocalizedEnumValueOrderAction()
        { 
           this.Action = "changeLocalizedEnumValueOrder";
        }
    }
}
