using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    [DeserializeAs(typeof(commercetools.Api.Models.Types.TypeAddEnumValueAction))]
    public partial interface ITypeAddEnumValueAction : ITypeUpdateAction
    {
        string FieldName { get; set; }

        ICustomFieldEnumValue Value { get; set; }
    }
}
