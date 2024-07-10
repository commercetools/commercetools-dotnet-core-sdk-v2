using commercetools.Sdk.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


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
