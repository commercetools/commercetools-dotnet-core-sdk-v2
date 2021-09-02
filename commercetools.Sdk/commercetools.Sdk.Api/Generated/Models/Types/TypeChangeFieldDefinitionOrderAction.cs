using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    public partial class TypeChangeFieldDefinitionOrderAction : ITypeChangeFieldDefinitionOrderAction
    {
        public string Action { get; set; }

        public List<string> FieldNames { get; set; }
        public TypeChangeFieldDefinitionOrderAction()
        {
            this.Action = "changeFieldDefinitionOrder";
        }
    }
}
