using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public IList<IProductSelectionSetting> AddedProductSelections { get; set; }

        public IEnumerable<IProductSelectionSetting> AddedProductSelectionsEnumerable { set => AddedProductSelections = value.ToList(); }

        public IList<IProductSelectionSetting> RemovedProductSelections { get; set; }

        public IEnumerable<IProductSelectionSetting> RemovedProductSelectionsEnumerable { set => RemovedProductSelections = value.ToList(); }

        public IList<IProductSelectionSetting> UpdatedProductSelections { get; set; }

        public IEnumerable<IProductSelectionSetting> UpdatedProductSelectionsEnumerable { set => UpdatedProductSelections = value.ToList(); }
        public StoreProductSelectionsChangedMessage()
        {
            this.Type = "StoreProductSelectionsChanged";
        }
    }
}
