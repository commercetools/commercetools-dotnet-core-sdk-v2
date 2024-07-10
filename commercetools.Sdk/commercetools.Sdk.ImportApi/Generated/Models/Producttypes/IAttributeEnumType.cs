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
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Producttypes.AttributeEnumType))]
    public partial interface IAttributeEnumType : IAttributeType
    {
        IList<IAttributePlainEnumValue> Values { get; set; }
        IEnumerable<IAttributePlainEnumValue> ValuesEnumerable { set => Values = value.ToList(); }


    }
}
