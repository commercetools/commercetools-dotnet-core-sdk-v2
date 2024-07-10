using commercetools.Sdk.Api.Models.Categories;
using commercetools.Sdk.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Categories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Categories.CategorySetAssetDescriptionAction))]
    public partial interface ICategorySetAssetDescriptionAction : ICategoryUpdateAction
    {
        string AssetId { get; set; }

        string AssetKey { get; set; }

        ILocalizedString Description { get; set; }

    }
}
