using commercetools.HistoryApi.Models.Changes;
using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class ChangeTaxCalculationModeChange : IChangeTaxCalculationModeChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public ITaxCalculationMode PreviousValue { get; set; }

        public ITaxCalculationMode NextValue { get; set; }
        public ChangeTaxCalculationModeChange()
        {
            this.Type = "ChangeTaxCalculationModeChange";
        }
    }
}
