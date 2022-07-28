using commercetools.Sdk.Api.Models.ProductSelections;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Stores
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Stores.StoreAddProductSelectionAction))]
    public partial interface IStoreAddProductSelectionAction : IStoreUpdateAction
    {
        IProductSelectionResourceIdentifier ProductSelection { get; set; }

        bool? Active { get; set; }

    }
}
