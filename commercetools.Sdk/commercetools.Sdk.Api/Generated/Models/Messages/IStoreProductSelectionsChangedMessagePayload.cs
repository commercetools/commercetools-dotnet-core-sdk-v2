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
