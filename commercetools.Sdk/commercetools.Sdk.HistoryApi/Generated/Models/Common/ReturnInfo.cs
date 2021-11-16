using System.Collections.Generic;


namespace commercetools.HistoryApi.Models.Common
{
    public partial class ReturnInfo : IReturnInfo
    {
        public List<IReturnItem> Items { get; set; }

        public string ReturnTrackingId { get; set; }

        public string ReturnDate { get; set; }
    }
}
