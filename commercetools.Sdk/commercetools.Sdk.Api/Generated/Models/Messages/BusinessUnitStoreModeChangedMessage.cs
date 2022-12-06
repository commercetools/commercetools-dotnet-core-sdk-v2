using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class BusinessUnitStoreModeChangedMessage : IBusinessUnitStoreModeChangedMessage
    {
        public string Id { get; set; }

        public long Version { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastModifiedAt { get; set; }

        public ILastModifiedBy LastModifiedBy { get; set; }

        public ICreatedBy CreatedBy { get; set; }

        public long SequenceNumber { get; set; }

        public IReference Resource { get; set; }

        public long ResourceVersion { get; set; }

        public string Type { get; set; }

        public IUserProvidedIdentifiers ResourceUserProvidedIdentifiers { get; set; }

        public IList<IStoreKeyReference> Stores { get; set; }
        public IEnumerable<IStoreKeyReference> StoresEnumerable { set => Stores = value.ToList(); }


        public IBusinessUnitStoreMode StoreMode { get; set; }

        public IList<IStoreKeyReference> OldStores { get; set; }
        public IEnumerable<IStoreKeyReference> OldStoresEnumerable { set => OldStores = value.ToList(); }


        public IBusinessUnitStoreMode OldStoreMode { get; set; }
        public BusinessUnitStoreModeChangedMessage()
        {
            this.Type = "BusinessUnitStoreModeChanged";
        }
    }
}
