using commercetools.HistoryApi.Models.ChangeValues;
using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.ChangeValues
{
    public partial class ChangeValueAbsoluteChangeValue : IChangeValueAbsoluteChangeValue
    {
        public string Type { get; set; }

        public List<IMoney> Money { get; set; }
        public ChangeValueAbsoluteChangeValue()
        {
            this.Type = "absolute";
        }
    }
}
