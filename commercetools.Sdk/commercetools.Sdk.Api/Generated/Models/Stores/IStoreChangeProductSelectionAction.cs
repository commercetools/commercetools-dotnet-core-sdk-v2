using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Stores
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Stores.StoreChangeProductSelectionAction))]
    public partial interface IStoreChangeProductSelectionAction : IStoreUpdateAction
    {
        IResourceIdentifier ProductSelection { get; set; }

        bool? Active { get; set; }
    }
}
