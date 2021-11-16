using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Categories
{
    [DeserializeAs(typeof(commercetools.Api.Models.Categories.CategorySetMetaKeywordsAction))]
    public partial interface ICategorySetMetaKeywordsAction : ICategoryUpdateAction
    {
        ILocalizedString MetaKeywords { get; set;}
    }
}
