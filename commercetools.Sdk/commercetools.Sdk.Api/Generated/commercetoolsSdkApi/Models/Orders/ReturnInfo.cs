using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class ReturnInfo : IReturnInfo
    {
        public IList<IReturnItem> Items { get; set; }

        public IEnumerable<IReturnItem> ItemsEnumerable { set => Items = value.ToList(); }

        public string ReturnTrackingId { get; set; }

        public DateTime? ReturnDate { get; set; }
    }
}
