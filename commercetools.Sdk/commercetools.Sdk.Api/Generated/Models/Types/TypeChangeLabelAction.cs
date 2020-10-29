using commercetools.Api.Models.Common;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    public partial class TypeChangeLabelAction : ITypeChangeLabelAction
    {
        public string Action { get; set;}
        
        public string FieldName { get; set;}
        
        public ILocalizedString Label { get; set;}
        public TypeChangeLabelAction()
        { 
           this.Action = "changeLabel";
        }
    }
}
