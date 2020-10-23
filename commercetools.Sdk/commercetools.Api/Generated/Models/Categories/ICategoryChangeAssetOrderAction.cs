using commercetools.Api.Generated.Models.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Categories
{
    public interface ICategoryChangeAssetOrderAction : ICategoryUpdateAction
    {
        List<string> AssetOrder { get; set;}
    }
}
