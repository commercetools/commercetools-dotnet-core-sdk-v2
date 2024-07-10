using commercetools.Sdk.ImportApi.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Types
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Types.CustomFieldLocalizedEnumType))]
    public partial interface ICustomFieldLocalizedEnumType : IFieldType
    {
        IList<ICustomFieldLocalizedEnumValue> Values { get; set; }
        IEnumerable<ICustomFieldLocalizedEnumValue> ValuesEnumerable { set => Values = value.ToList(); }


    }
}
