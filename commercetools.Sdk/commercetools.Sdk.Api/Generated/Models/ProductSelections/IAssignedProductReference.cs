using commercetools.Sdk.Api.Models.Products;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ProductSelections
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSelections.AssignedProductReference))]
    public partial interface IAssignedProductReference
    {
        IProductReference Product { get; set; }
    }
}
