using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ProductSelections
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSelections.ProductSelectionSetKeyAction))]
    public partial interface IProductSelectionSetKeyAction : IProductSelectionUpdateAction
    {
        string Key { get; set; }
    }
}
