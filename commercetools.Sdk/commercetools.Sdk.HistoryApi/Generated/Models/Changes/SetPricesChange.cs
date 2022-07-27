using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetPricesChange : ISetPricesChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public string CatalogData { get; set; }

        public string Variant { get; set; }

        public List<IPrice> PreviousValue { get; set; }

        public List<IPrice> NextValue { get; set; }
        public SetPricesChange()
        {
            this.Type = "SetPricesChange";
        }
    }
}
