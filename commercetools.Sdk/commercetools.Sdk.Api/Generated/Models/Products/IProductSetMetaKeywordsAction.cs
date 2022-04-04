using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.ProductSetMetaKeywordsAction))]
    public partial interface IProductSetMetaKeywordsAction : IProductUpdateAction
    {
        ILocalizedString MetaKeywords { get; set; }

        bool? Staged { get; set; }
    }
}
