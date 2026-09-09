using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Products;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.VariantImagesSetMessagePayload))]
    public partial interface IVariantImagesSetMessagePayload : IMessagePayload
    {
        IProductReference Product { get; set; }

        IList<IImage> Images { get; set; }

        IEnumerable<IImage> ImagesEnumerable { set => Images = value.ToList(); }

        IList<IImage> OldImages { get; set; }

        IEnumerable<IImage> OldImagesEnumerable { set => OldImages = value.ToList(); }

        bool Staged { get; set; }

    }
}
