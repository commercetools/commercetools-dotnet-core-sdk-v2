using commercetools.Sdk.Api.Models.Stores;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StoreProductSelectionsChangedMessagePayload))]
    public partial interface IStoreProductSelectionsChangedMessagePayload : IMessagePayload
    {
        IList<IProductSelectionSetting> AddedProductSelections { get; set; }

        IEnumerable<IProductSelectionSetting> AddedProductSelectionsEnumerable { set => AddedProductSelections = value.ToList(); }

        IList<IProductSelectionSetting> RemovedProductSelections { get; set; }

        IEnumerable<IProductSelectionSetting> RemovedProductSelectionsEnumerable { set => RemovedProductSelections = value.ToList(); }

        IList<IProductSelectionSetting> UpdatedProductSelections { get; set; }

        IEnumerable<IProductSelectionSetting> UpdatedProductSelectionsEnumerable { set => UpdatedProductSelections = value.ToList(); }

    }
}
