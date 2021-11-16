using commercetools.Api.Models.Common;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Api.Models.Products.ProductAddVariantAction))]
    public partial interface IProductAddVariantAction : IProductUpdateAction
    {
        string Sku { get; set; }

        string Key { get; set; }

        List<IPriceDraft> Prices { get; set; }

        List<IImage> Images { get; set; }

        List<IAttribute> Attributes { get; set; }

        bool? Staged { get; set; }

        List<IAsset> Assets { get; set; }
    }
}
