using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Categories
{
    [DeserializeAs(typeof(commercetools.Api.Models.Categories.CategoryChangeNameAction))]
    public partial interface ICategoryChangeNameAction : ICategoryUpdateAction
    {
        ILocalizedString Name { get; set; }
    }
}
