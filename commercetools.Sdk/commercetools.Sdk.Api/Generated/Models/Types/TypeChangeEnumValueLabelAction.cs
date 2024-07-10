using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Types
{

    public partial class TypeChangeEnumValueLabelAction : ITypeChangeEnumValueLabelAction
    {
        public string Action { get; set; }

        public string FieldName { get; set; }

        public ICustomFieldEnumValue Value { get; set; }
        public TypeChangeEnumValueLabelAction()
        {
            this.Action = "changeEnumValueLabel";
        }
    }
}
