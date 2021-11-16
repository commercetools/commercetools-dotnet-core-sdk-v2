using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Categories
{
    [DeserializeAs(typeof(commercetools.Api.Models.Categories.CategorySetDescriptionAction))]
    public partial interface ICategorySetDescriptionAction : ICategoryUpdateAction
    {
        ILocalizedString Description { get; set;}
    }
}
