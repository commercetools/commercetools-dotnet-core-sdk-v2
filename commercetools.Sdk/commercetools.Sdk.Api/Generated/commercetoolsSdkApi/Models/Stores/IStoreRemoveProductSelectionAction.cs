using commercetools.Sdk.Api.Models.ProductSelections;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Stores
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Stores.StoreRemoveProductSelectionAction))]
    public partial interface IStoreRemoveProductSelectionAction : IStoreUpdateAction
    {
        IProductSelectionResourceIdentifier ProductSelection { get; set; }

    }
}
