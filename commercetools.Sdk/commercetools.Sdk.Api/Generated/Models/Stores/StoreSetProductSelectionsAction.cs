using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Stores
{

    public partial class StoreSetProductSelectionsAction : IStoreSetProductSelectionsAction
    {
        public string Action { get; set; }

        public IList<IProductSelectionSettingDraft> ProductSelections { get; set; }
        public IEnumerable<IProductSelectionSettingDraft> ProductSelectionsEnumerable { set => ProductSelections = value.ToList(); }

        public StoreSetProductSelectionsAction()
        {
            this.Action = "setProductSelections";
        }
    }
}
