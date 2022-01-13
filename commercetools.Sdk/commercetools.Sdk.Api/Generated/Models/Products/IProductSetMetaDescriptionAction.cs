using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Api.Models.Products.ProductSetMetaDescriptionAction))]
    public partial interface IProductSetMetaDescriptionAction : IProductUpdateAction
    {
        ILocalizedString MetaDescription { get; set; }

        bool? Staged { get; set; }
    }
}
