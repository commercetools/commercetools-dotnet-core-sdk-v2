using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Categories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Categories.CategorySetMetaDescriptionAction))]
    public partial interface ICategorySetMetaDescriptionAction : ICategoryUpdateAction
    {
        ILocalizedString MetaDescription { get; set; }
    }
}
