using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Types
{

    public partial class TypeAddLocalizedEnumValueAction : ITypeAddLocalizedEnumValueAction
    {
        public string Action { get; set; }

        public string FieldName { get; set; }

        public ICustomFieldLocalizedEnumValue Value { get; set; }
        public TypeAddLocalizedEnumValueAction()
        {
            this.Action = "addLocalizedEnumValue";
        }
    }
}
