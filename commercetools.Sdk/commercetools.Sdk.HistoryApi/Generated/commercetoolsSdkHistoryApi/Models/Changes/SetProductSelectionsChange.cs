using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetProductSelectionsChange : ISetProductSelectionsChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IList<IProductSelectionSetting> PreviousValue { get; set; }
        public IEnumerable<IProductSelectionSetting> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }


        public IList<IProductSelectionSetting> NextValue { get; set; }
        public IEnumerable<IProductSelectionSetting> NextValueEnumerable { set => NextValue = value.ToList(); }

        public SetProductSelectionsChange()
        {
            this.Type = "SetProductSelectionsChange";
        }
    }
}
