using commercetools.Sdk.Api.Models.Stores;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StoreProductSelectionsChangedMessage))]
    public partial interface IStoreProductSelectionsChangedMessage : IMessage
    {
        List<IProductSelectionSetting> AddedProductSelections { get; set; }

        List<IProductSelectionSetting> RemovedProductSelections { get; set; }

        List<IProductSelectionSetting> UpdatedProductSelections { get; set; }
    }
}
