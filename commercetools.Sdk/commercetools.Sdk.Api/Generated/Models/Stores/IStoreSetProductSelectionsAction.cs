using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Stores
{
    [DeserializeAs(typeof(commercetools.Api.Models.Stores.StoreSetProductSelectionsAction))]
    public partial interface IStoreSetProductSelectionsAction : IStoreUpdateAction
    {
        List<IProductSelectionSettingDraft> ProductSelections { get; set; }
    }
}
