using commercetools.Sdk.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Types
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Types.CustomFieldLocalizedEnumValue))]
    public partial interface ICustomFieldLocalizedEnumValue
    {
        string Key { get; set; }

        ILocalizedString Label { get; set; }

    }
}
