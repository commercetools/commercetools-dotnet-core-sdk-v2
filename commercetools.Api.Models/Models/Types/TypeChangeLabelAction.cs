using commercetools.Api.Models.Common;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Types
{
    public class TypeChangeLabelAction : TypeUpdateAction
    {
        public string FieldName { get; set;}
        
        public LocalizedString Label { get; set;}
    }
}
