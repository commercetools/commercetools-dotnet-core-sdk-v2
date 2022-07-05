using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Stores;
using System;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class StoreProductSelectionsChangedMessage : IStoreProductSelectionsChangedMessage
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

        public List<IProductSelectionSetting> AddedProductSelections { get; set; }

        public List<IProductSelectionSetting> RemovedProductSelections { get; set; }

        public List<IProductSelectionSetting> UpdatedProductSelections { get; set; }
        public StoreProductSelectionsChangedMessage()
        {
            this.Type = "StoreProductSelectionsChanged";
        }
    }
}
