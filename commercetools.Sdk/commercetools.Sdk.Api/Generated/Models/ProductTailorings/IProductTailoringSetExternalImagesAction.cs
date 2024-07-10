using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.ProductTailorings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductTailorings
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetExternalImagesAction))]
    public partial interface IProductTailoringSetExternalImagesAction : IProductTailoringUpdateAction
    {
        long? VariantId { get; set; }

        string Sku { get; set; }

        IList<IImage> Images { get; set; }
        IEnumerable<IImage> ImagesEnumerable { set => Images = value.ToList(); }


        bool? Staged { get; set; }

    }
}
