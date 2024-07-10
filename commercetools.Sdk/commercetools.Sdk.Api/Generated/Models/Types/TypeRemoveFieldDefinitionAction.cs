using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Types
{

    public partial class TypeRemoveFieldDefinitionAction : ITypeRemoveFieldDefinitionAction
    {
        public string Action { get; set; }

        public string FieldName { get; set; }
        public TypeRemoveFieldDefinitionAction()
        {
            this.Action = "removeFieldDefinition";
        }
    }
}
