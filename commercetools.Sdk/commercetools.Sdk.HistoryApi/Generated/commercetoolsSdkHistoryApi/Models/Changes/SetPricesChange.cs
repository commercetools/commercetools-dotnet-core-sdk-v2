using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetPricesChange : ISetPricesChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IList<IPrice> PreviousValue { get; set; }

        public IEnumerable<IPrice> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }

        public IList<IPrice> NextValue { get; set; }

        public IEnumerable<IPrice> NextValueEnumerable { set => NextValue = value.ToList(); }

        public string CatalogData { get; set; }

        public string Variant { get; set; }
        public SetPricesChange()
        {
            this.Type = "SetPricesChange";
        }
    }
}
