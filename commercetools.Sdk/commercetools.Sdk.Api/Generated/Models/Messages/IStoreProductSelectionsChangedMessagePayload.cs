using commercetools.Sdk.Api.Models.Stores;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StoreProductSelectionsChangedMessagePayload))]
    public partial interface IStoreProductSelectionsChangedMessagePayload : IMessagePayload
    {
        List<IProductSelectionSetting> AddedProductSelections { get; set; }

        List<IProductSelectionSetting> RemovedProductSelections { get; set; }

        List<IProductSelectionSetting> UpdatedProductSelections { get; set; }

    }
}
