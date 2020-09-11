using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Types
{
    public class TypeChangeInputHintAction : TypeUpdateAction
    {
        public string FieldName { get; set;}
        
        public TypeTextInputHint InputHint { get; set;}
    }
}
