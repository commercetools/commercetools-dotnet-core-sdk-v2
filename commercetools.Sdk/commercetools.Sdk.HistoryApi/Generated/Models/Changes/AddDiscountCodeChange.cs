using commercetools.HistoryApi.Models.Changes;
using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class AddDiscountCodeChange : IAddDiscountCodeChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IDiscountCodeInfo NextValue { get; set; }
        public AddDiscountCodeChange()
        {
            this.Type = "AddDiscountCodeChange";
        }
    }
}
