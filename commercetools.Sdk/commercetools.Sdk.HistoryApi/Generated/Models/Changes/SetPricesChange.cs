using commercetools.HistoryApi.Models.Changes;
using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
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
