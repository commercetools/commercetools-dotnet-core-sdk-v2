using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class ReturnInfoDraft : IReturnInfoDraft
    {
        public IList<IReturnItemDraft> Items { get; set; }

        public IEnumerable<IReturnItemDraft> ItemsEnumerable { set => Items = value.ToList(); }

        public string ReturnTrackingId { get; set; }

        public DateTime? ReturnDate { get; set; }
    }
}
