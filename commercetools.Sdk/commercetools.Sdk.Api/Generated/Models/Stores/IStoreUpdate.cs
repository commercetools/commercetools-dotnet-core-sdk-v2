using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Stores
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Stores.StoreUpdate))]
    public partial interface IStoreUpdate
    {
        long Version { get; set; }

        List<IStoreUpdateAction> Actions { get; set; }
    }
}
