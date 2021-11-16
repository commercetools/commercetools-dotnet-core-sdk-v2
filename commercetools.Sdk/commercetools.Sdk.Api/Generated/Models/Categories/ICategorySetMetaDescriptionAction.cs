using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Categories
{
    [DeserializeAs(typeof(commercetools.Api.Models.Categories.CategorySetMetaDescriptionAction))]
    public partial interface ICategorySetMetaDescriptionAction : ICategoryUpdateAction
    {
        ILocalizedString MetaDescription { get; set; }
    }
}
