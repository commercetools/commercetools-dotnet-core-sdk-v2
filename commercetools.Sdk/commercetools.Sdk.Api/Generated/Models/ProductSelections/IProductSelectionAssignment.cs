using commercetools.Api.Models.Products;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductSelections
{
    [DeserializeAs(typeof(commercetools.Api.Models.ProductSelections.ProductSelectionAssignment))]
    public partial interface IProductSelectionAssignment
    {
        IProductReference Product { get; set; }

        IProductSelectionReference ProductSelection { get; set; }
    }
}
