using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Categories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Categories.CategorySetDescriptionAction))]
    public partial interface ICategorySetDescriptionAction : ICategoryUpdateAction
    {
        ILocalizedString Description { get; set; }

    }
}
