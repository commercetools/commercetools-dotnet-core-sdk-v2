using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Types
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Types.TypeAddEnumValueAction))]
    public partial interface ITypeAddEnumValueAction : ITypeUpdateAction
    {
        string FieldName { get; set; }

        ICustomFieldEnumValue Value { get; set; }

    }
}
