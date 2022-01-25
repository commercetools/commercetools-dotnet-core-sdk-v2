using System.Collections.Generic;


namespace commercetools.Api.Models.Stores
{
    public partial class StoreSetProductSelectionsAction : IStoreSetProductSelectionsAction
    {
        public string Action { get; set; }

        public List<IProductSelectionSettingDraft> ProductSelections { get; set; }
        public StoreSetProductSelectionsAction()
        {
            this.Action = "setProductSelections";
        }
    }
}
