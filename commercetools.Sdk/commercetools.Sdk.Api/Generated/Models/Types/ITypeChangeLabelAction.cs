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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Types.TypeChangeLabelAction))]
    public partial interface ITypeChangeLabelAction : ITypeUpdateAction
    {
        string FieldName { get; set; }

        ILocalizedString Label { get; set; }

    }
}
