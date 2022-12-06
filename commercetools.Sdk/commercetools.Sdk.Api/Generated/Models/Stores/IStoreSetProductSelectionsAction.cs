using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Stores
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Stores.StoreSetProductSelectionsAction))]
    public partial interface IStoreSetProductSelectionsAction : IStoreUpdateAction
    {
        IList<IProductSelectionSettingDraft> ProductSelections { get; set; }
        IEnumerable<IProductSelectionSettingDraft> ProductSelectionsEnumerable { set => ProductSelections = value.ToList(); }


    }
}
