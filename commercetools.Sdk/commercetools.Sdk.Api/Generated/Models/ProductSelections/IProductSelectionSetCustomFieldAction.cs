using commercetools.Sdk.Api.Models.ProductSelections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSelections
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSelections.ProductSelectionSetCustomFieldAction))]
    public partial interface IProductSelectionSetCustomFieldAction : IProductSelectionUpdateAction
    {
        string Name { get; set; }

        Object Value { get; set; }

    }
}
