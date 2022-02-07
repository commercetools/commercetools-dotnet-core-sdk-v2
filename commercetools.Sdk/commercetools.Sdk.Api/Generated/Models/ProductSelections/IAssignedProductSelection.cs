using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductSelections
{
    [DeserializeAs(typeof(commercetools.Api.Models.ProductSelections.AssignedProductSelection))]
    public partial interface IAssignedProductSelection
    {
        IProductSelectionReference ProductSelection { get; set; }
    }
}
