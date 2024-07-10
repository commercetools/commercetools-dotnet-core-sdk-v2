using commercetools.Sdk.Api.Models.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Categories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Categories.CategorySetAssetCustomFieldAction))]
    public partial interface ICategorySetAssetCustomFieldAction : ICategoryUpdateAction
    {
        string AssetId { get; set; }

        string AssetKey { get; set; }

        string Name { get; set; }

        Object Value { get; set; }

    }
}
