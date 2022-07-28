using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Stores
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Stores.StoreSetProductSelectionsAction))]
    public partial interface IStoreSetProductSelectionsAction : IStoreUpdateAction
    {
        List<IProductSelectionSettingDraft> ProductSelections { get; set; }

    }
}
