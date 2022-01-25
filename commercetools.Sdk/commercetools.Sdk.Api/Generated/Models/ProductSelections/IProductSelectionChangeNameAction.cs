using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductSelections
{
    [DeserializeAs(typeof(commercetools.Api.Models.ProductSelections.ProductSelectionChangeNameAction))]
    public partial interface IProductSelectionChangeNameAction : IProductSelectionUpdateAction
    {
        ILocalizedString Name { get; set; }
    }
}
