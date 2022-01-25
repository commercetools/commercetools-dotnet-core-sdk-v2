using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Stores
{
    [DeserializeAs(typeof(commercetools.Api.Models.Stores.StoreRemoveProductSelectionAction))]
    public partial interface IStoreRemoveProductSelectionAction : IStoreUpdateAction
    {
        IResourceIdentifier ProductSelection { get; set; }
    }
}
