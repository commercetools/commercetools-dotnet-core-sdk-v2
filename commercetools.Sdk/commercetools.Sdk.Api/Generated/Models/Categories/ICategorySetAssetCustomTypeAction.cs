using commercetools.Api.Models.Categories;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Categories
{
    [DeserializeAs(typeof(commercetools.Api.Models.Categories.CategorySetAssetCustomTypeAction))]
    public partial interface ICategorySetAssetCustomTypeAction : ICategoryUpdateAction
    {
        string AssetId { get; set; }

        string AssetKey { get; set; }

        ITypeResourceIdentifier Type { get; set; }

        Object Fields { get; set; }
    }
}
