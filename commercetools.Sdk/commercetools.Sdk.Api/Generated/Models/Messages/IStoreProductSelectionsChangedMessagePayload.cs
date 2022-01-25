using commercetools.Api.Models.Stores;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.StoreProductSelectionsChangedMessagePayload))]
    public partial interface IStoreProductSelectionsChangedMessagePayload : IMessagePayload
    {
        List<IProductSelectionSetting> AddedProductSelections { get; set; }

        List<IProductSelectionSetting> RemovedProductSelections { get; set; }

        List<IProductSelectionSetting> UpdatedProductSelections { get; set; }
    }
}
