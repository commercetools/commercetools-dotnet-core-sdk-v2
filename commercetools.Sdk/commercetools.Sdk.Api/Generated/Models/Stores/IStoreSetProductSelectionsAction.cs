using commercetools.Sdk.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Stores
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Stores.StoreSetProductSelectionsAction))]
    public partial interface IStoreSetProductSelectionsAction : IStoreUpdateAction
    {
        IList<IProductSelectionSettingDraft> ProductSelections { get; set; }
        IEnumerable<IProductSelectionSettingDraft> ProductSelectionsEnumerable { set => ProductSelections = value.ToList(); }


    }
}
