using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetProductSelectionsChange : ISetProductSelectionsChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public List<IProductSelectionSetting> PreviousValue { get; set; }

        public List<IProductSelectionSetting> NextValue { get; set; }
        public SetProductSelectionsChange()
        {
            this.Type = "SetProductSelectionsChange";
        }
    }
}
