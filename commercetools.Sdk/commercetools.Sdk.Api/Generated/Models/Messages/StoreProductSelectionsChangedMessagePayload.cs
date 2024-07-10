using commercetools.Sdk.Api.Models.Messages;
using commercetools.Sdk.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class StoreProductSelectionsChangedMessagePayload : IStoreProductSelectionsChangedMessagePayload
    {
        public string Type { get; set; }

        public IList<IProductSelectionSetting> AddedProductSelections { get; set; }
        public IEnumerable<IProductSelectionSetting> AddedProductSelectionsEnumerable { set => AddedProductSelections = value.ToList(); }


        public IList<IProductSelectionSetting> RemovedProductSelections { get; set; }
        public IEnumerable<IProductSelectionSetting> RemovedProductSelectionsEnumerable { set => RemovedProductSelections = value.ToList(); }


        public IList<IProductSelectionSetting> UpdatedProductSelections { get; set; }
        public IEnumerable<IProductSelectionSetting> UpdatedProductSelectionsEnumerable { set => UpdatedProductSelections = value.ToList(); }

        public StoreProductSelectionsChangedMessagePayload()
        {
            this.Type = "StoreProductSelectionsChanged";
        }
    }
}
