using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Stores
{
    [DeserializeAs(typeof(commercetools.Api.Models.Stores.StoreChangeProductSelectionAction))]
    public partial interface IStoreChangeProductSelectionAction : IStoreUpdateAction
    {
        IResourceIdentifier ProductSelection { get; set; }

        bool? Active { get; set; }
    }
}
