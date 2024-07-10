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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Types.TypeChangeLocalizedEnumValueOrderAction))]
    public partial interface ITypeChangeLocalizedEnumValueOrderAction : ITypeUpdateAction
    {
        string FieldName { get; set; }

        IList<string> Keys { get; set; }
        IEnumerable<string> KeysEnumerable { set => Keys = value.ToList(); }


    }
}
