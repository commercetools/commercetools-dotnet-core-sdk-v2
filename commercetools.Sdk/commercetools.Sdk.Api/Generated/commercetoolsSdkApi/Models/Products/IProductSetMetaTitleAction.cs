using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.ProductSetMetaTitleAction))]
    public partial interface IProductSetMetaTitleAction : IProductUpdateAction
    {
        ILocalizedString MetaTitle { get; set; }

        bool? Staged { get; set; }

    }
}
