using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Categories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Categories.CategoryChangeNameAction))]
    public partial interface ICategoryChangeNameAction : ICategoryUpdateAction
    {
        ILocalizedString Name { get; set; }
    }
}
