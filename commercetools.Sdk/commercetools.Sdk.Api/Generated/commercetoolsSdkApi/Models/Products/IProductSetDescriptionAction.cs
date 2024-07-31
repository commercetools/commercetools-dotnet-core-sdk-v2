using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.ProductSetDescriptionAction))]
    public partial interface IProductSetDescriptionAction : IProductUpdateAction
    {
        ILocalizedString Description { get; set; }

        bool? Staged { get; set; }

    }
}
