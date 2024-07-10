using commercetools.Sdk.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.FieldDefinition))]
    public partial interface IFieldDefinition
    {
        IFieldType Type { get; set; }

        string Name { get; set; }

        ILocalizedString Label { get; set; }

        ITextInputHint InputHint { get; set; }

    }
}
