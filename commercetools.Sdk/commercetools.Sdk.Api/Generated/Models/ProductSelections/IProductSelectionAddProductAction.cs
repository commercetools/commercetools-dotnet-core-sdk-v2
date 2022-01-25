using commercetools.Api.Models.Products;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductSelections
{
    [DeserializeAs(typeof(commercetools.Api.Models.ProductSelections.ProductSelectionAddProductAction))]
    public partial interface IProductSelectionAddProductAction : IProductSelectionUpdateAction
    {
        IProductResourceIdentifier Product { get; set; }
    }
}
