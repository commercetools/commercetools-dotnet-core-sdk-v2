using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSelections
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSelections.ProductSelectionSetKeyAction))]
    public partial interface IProductSelectionSetKeyAction : IProductSelectionUpdateAction
    {
        string Key { get; set; }

    }
}
