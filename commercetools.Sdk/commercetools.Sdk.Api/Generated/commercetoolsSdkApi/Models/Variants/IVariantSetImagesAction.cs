using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Variants
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Variants.VariantSetImagesAction))]
    public partial interface IVariantSetImagesAction : IVariantUpdateAction
    {
        IList<IImage> Images { get; set; }

        IEnumerable<IImage> ImagesEnumerable { set => Images = value.ToList(); }

        bool? Staged { get; set; }

    }
}
