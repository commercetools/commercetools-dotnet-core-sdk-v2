using commercetools.Api.Models.Products;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductSelections
{
    [DeserializeAs(typeof(commercetools.Api.Models.ProductSelections.AssignedProductReference))]
    public partial interface IAssignedProductReference
    {
        IProductReference Product { get; set; }
    }
}
