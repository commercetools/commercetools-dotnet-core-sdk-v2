using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.ProductChangeSlugAction))]
    public partial interface IProductChangeSlugAction : IProductUpdateAction
    {
        ILocalizedString Slug { get; set; }

        bool? Staged { get; set; }

    }
}
