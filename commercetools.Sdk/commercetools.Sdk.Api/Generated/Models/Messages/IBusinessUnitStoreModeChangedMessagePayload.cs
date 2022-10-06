using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Sdk.Api.Models.Stores;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitStoreModeChangedMessagePayload))]
    public partial interface IBusinessUnitStoreModeChangedMessagePayload : IMessagePayload
    {
        List<IStoreKeyReference> Stores { get; set; }

        IBusinessUnitStoreMode StoreMode { get; set; }

        List<IStoreKeyReference> OldStores { get; set; }

        IBusinessUnitStoreMode OldStoreMode { get; set; }

    }
}
