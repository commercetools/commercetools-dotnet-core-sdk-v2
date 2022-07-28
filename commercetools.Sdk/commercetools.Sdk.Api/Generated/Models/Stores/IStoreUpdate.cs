using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Stores
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Stores.StoreUpdate))]
    public partial interface IStoreUpdate : commercetools.Sdk.Api.Models.IResourceUpdate<IStoreUpdate, IStoreUpdateAction>
    {
        new long Version { get; set; }
        new List<IStoreUpdateAction> Actions { get; set; }

    }
}
