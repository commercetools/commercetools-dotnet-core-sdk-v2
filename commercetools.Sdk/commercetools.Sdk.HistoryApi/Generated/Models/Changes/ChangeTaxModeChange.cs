using commercetools.Sdk.HistoryApi.Models.Changes;
using commercetools.Sdk.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class ChangeTaxModeChange : IChangeTaxModeChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public ITaxMode PreviousValue { get; set; }

        public ITaxMode NextValue { get; set; }
        public ChangeTaxModeChange()
        {
            this.Type = "ChangeTaxModeChange";
        }
    }
}
