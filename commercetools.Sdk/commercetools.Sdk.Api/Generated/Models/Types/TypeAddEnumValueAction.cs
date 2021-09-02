using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    public partial class TypeAddEnumValueAction : ITypeAddEnumValueAction
    {
        public string Action { get; set; }

        public string FieldName { get; set; }

        public ICustomFieldEnumValue Value { get; set; }
        public TypeAddEnumValueAction()
        {
            this.Action = "addEnumValue";
        }
    }
}
