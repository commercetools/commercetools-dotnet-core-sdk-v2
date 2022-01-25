using commercetools.Api.Models.Products;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductSelections
{
    [DeserializeAs(typeof(commercetools.Api.Models.ProductSelections.ProductSelectionRemoveProductAction))]
    public partial interface IProductSelectionRemoveProductAction : IProductSelectionUpdateAction
    {
        IProductResourceIdentifier Product { get; set; }
    }
}
