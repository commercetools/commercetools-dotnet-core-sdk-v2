using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Producttypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Producttypes
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Producttypes.AttributeDefinition))]
    public partial interface IAttributeDefinition
    {
        IAttributeType Type { get; set; }

        string Name { get; set; }

        ILocalizedString Label { get; set; }

        bool IsRequired { get; set; }

        IAttributeConstraintEnum AttributeConstraint { get; set; }

        ILocalizedString InputTip { get; set; }

        ITextInputHint InputHint { get; set; }

        bool? IsSearchable { get; set; }

    }
}
