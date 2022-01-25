using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductSelections
{
    [DeserializeAs(typeof(commercetools.Api.Models.ProductSelections.ProductSelectionSetKeyAction))]
    public partial interface IProductSelectionSetKeyAction : IProductSelectionUpdateAction
    {
        string Key { get; set; }
    }
}
