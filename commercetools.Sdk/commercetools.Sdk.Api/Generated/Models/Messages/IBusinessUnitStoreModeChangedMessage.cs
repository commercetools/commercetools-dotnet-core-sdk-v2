using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Messages;
using commercetools.Sdk.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
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
