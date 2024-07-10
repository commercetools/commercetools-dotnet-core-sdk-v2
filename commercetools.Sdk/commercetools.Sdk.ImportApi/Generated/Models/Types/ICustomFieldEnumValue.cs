using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Types
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Types.CustomFieldEnumValue))]
    public partial interface ICustomFieldEnumValue
    {
        string Key { get; set; }

        string Label { get; set; }

    }
}
