using commercetools.Sdk.HistoryApi.Models.ChangeValues;
using commercetools.Sdk.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.HistoryApi.Models.ChangeValues
{

    public partial class ChangeValueAbsoluteChangeValue : IChangeValueAbsoluteChangeValue
    {
        public string Type { get; set; }

        public IList<IMoney> Money { get; set; }
        public IEnumerable<IMoney> MoneyEnumerable { set => Money = value.ToList(); }

        public ChangeValueAbsoluteChangeValue()
        {
            this.Type = "absolute";
        }
    }
}
