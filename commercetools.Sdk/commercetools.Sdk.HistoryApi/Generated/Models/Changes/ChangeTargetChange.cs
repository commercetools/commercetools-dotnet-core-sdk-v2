using commercetools.HistoryApi.Models.ChangeValues;
using commercetools.HistoryApi.Models.Changes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class ChangeTargetChange : IChangeTargetChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IChangeTargetChangeValue NextValue { get; set; }

        public IChangeTargetChangeValue PreviousValue { get; set; }
        public ChangeTargetChange()
        {
            this.Type = "ChangeTargetChange";
        }
    }
}
