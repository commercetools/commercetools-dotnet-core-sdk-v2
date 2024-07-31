using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.ProductAddExternalImageAction))]
    public partial interface IProductAddExternalImageAction : IProductUpdateAction
    {
        long? VariantId { get; set; }

        string Sku { get; set; }

        IImage Image { get; set; }

        bool? Staged { get; set; }

    }
}
