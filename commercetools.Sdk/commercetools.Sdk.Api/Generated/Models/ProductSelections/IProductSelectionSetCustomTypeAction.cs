using commercetools.Api.Models.Types;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductSelections
{
    [DeserializeAs(typeof(commercetools.Api.Models.ProductSelections.ProductSelectionSetCustomTypeAction))]
    public partial interface IProductSelectionSetCustomTypeAction : IProductSelectionUpdateAction
    {
        ITypeResourceIdentifier Type { get; set; }

        IFieldContainer Fields { get; set; }
    }
}
