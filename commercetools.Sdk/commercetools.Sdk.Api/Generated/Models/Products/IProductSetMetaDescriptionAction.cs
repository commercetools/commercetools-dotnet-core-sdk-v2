using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.ProductSetMetaDescriptionAction))]
    public partial interface IProductSetMetaDescriptionAction : IProductUpdateAction
    {
        ILocalizedString MetaDescription { get; set; }

        bool? Staged { get; set; }

    }
}
