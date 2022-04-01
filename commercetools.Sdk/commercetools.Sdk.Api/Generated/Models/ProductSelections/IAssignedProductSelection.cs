using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ProductSelections
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSelections.AssignedProductSelection))]
    public partial interface IAssignedProductSelection
    {
        IProductSelectionReference ProductSelection { get; set; }
    }
}
