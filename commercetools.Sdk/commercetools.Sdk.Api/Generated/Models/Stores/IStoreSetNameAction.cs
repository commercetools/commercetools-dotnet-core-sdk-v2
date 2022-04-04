using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Stores
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Stores.StoreSetNameAction))]
    public partial interface IStoreSetNameAction : IStoreUpdateAction
    {
        ILocalizedString Name { get; set; }
    }
}
