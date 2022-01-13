using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Api.Models.Products.ProductSetMetaTitleAction))]
    public partial interface IProductSetMetaTitleAction : IProductUpdateAction
    {
        ILocalizedString MetaTitle { get; set; }

        bool? Staged { get; set; }
    }
}
