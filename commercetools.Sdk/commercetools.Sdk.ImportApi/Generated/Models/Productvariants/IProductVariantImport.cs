using commercetools.Sdk.ImportApi.Models.Common;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Productvariants
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Productvariants.ProductVariantImport))]
    public partial interface IProductVariantImport : IImportResource
    {
        string Sku { get; set; }

        bool IsMasterVariant { get; set; }

        List<IAttribute> Attributes { get; set; }

        List<IImage> Images { get; set; }

        List<IAsset> Assets { get; set; }

        bool? Publish { get; set; }

        IProductKeyReference Product { get; set; }

    }
}
