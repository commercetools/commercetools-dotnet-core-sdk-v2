using commercetools.Sdk.Api.Models.Products;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ProductSelections
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSelections.ProductSelectionAddProductAction))]
    public partial interface IProductSelectionAddProductAction : IProductSelectionUpdateAction
    {
        IProductResourceIdentifier Product { get; set; }
    }
}
