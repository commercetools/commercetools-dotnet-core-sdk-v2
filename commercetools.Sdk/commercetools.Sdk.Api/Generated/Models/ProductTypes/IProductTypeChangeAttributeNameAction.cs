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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangeAttributeNameAction))]
    public partial interface IProductTypeChangeAttributeNameAction : IProductTypeUpdateAction
    {
        string AttributeName { get; set; }

        string NewAttributeName { get; set; }

    }
}
