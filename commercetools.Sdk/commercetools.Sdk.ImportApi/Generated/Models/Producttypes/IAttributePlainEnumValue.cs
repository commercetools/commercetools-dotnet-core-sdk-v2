using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Producttypes
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Producttypes.AttributePlainEnumValue))]
    public partial interface IAttributePlainEnumValue
    {
        string Key { get; set; }

        string Label { get; set; }

    }
}
