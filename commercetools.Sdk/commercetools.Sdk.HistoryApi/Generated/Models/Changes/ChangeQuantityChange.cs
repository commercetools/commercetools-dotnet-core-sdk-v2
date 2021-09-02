using commercetools.HistoryApi.Models.ChangeValues;
using commercetools.HistoryApi.Models.Changes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class ChangeQuantityChange : IChangeQuantityChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IInventoryQuantityValue NextValue { get; set; }

        public IInventoryQuantityValue PreviousValue { get; set; }
        public ChangeQuantityChange()
        {
            this.Type = "ChangeQuantityChange";
        }
    }
}
