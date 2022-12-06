using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Sdk.Api.Models.Stores;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitStoreModeChangedMessage))]
    public partial interface IBusinessUnitStoreModeChangedMessage : IMessage
    {
        IList<IStoreKeyReference> Stores { get; set; }
        IEnumerable<IStoreKeyReference> StoresEnumerable { set => Stores = value.ToList(); }


        IBusinessUnitStoreMode StoreMode { get; set; }

        IList<IStoreKeyReference> OldStores { get; set; }
        IEnumerable<IStoreKeyReference> OldStoresEnumerable { set => OldStores = value.ToList(); }


        IBusinessUnitStoreMode OldStoreMode { get; set; }

    }
}
