using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Stores
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Stores.StoreRemoveProductSelectionAction))]
    public partial interface IStoreRemoveProductSelectionAction : IStoreUpdateAction
    {
        IResourceIdentifier ProductSelection { get; set; }
    }
}
