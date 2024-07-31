using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;
using System.Linq;

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
