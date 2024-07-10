using commercetools.Sdk.Api.Models.Common;
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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Types.FieldDefinition))]
    public partial interface IFieldDefinition
    {
        IFieldType Type { get; set; }

        string Name { get; set; }

        ILocalizedString Label { get; set; }

        bool Required { get; set; }

        ITypeTextInputHint InputHint { get; set; }

    }
}
