using commercetools.Sdk.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductTailorings
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductTailorings.ProductVariantTailoring))]
    public partial interface IProductVariantTailoring
    {
        long Id { get; set; }

        IList<IImage> Images { get; set; }
        IEnumerable<IImage> ImagesEnumerable { set => Images = value.ToList(); }


        IList<IAsset> Assets { get; set; }
        IEnumerable<IAsset> AssetsEnumerable { set => Assets = value.ToList(); }


    }
}
