using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Categories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Categories.CategorySetDescriptionAction))]
    public partial interface ICategorySetDescriptionAction : ICategoryUpdateAction
    {
        ILocalizedString Description { get; set; }

    }
}
