using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class ReturnInfo : IReturnInfo
    {
        public IList<IReturnItem> Items { get; set; }

        public IEnumerable<IReturnItem> ItemsEnumerable { set => Items = value.ToList(); }

        public string ReturnTrackingId { get; set; }

        public string ReturnDate { get; set; }
    }
}
