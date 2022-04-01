using commercetools.Sdk.Api.Models.Stores;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Messages
{
    public partial class StoreProductSelectionsChangedMessagePayload : IStoreProductSelectionsChangedMessagePayload
    {
        public string Type { get; set; }

        public List<IProductSelectionSetting> AddedProductSelections { get; set; }

        public List<IProductSelectionSetting> RemovedProductSelections { get; set; }

        public List<IProductSelectionSetting> UpdatedProductSelections { get; set; }
        public StoreProductSelectionsChangedMessagePayload()
        {
            this.Type = "StoreProductSelectionsChanged";
        }
    }
}
