using commercetools.Sdk.Api.Models.ProductTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeRemoveEnumValuesAction))]
    public partial interface IProductTypeRemoveEnumValuesAction : IProductTypeUpdateAction
    {
        string AttributeName { get; set; }

        IList<string> Keys { get; set; }
        IEnumerable<string> KeysEnumerable { set => Keys = value.ToList(); }


    }
}
