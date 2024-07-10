using commercetools.Sdk.ImportApi.Models.Customfields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Customfields
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Customfields.LocalizedEnumSetField))]
    public partial interface ILocalizedEnumSetField : ICustomField
    {
        IList<string> Value { get; set; }
        IEnumerable<string> ValueEnumerable { set => Value = value.ToList(); }


    }
}
