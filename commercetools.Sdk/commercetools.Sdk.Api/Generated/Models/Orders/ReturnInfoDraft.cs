using System;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Orders
{
    public partial class ReturnInfoDraft : IReturnInfoDraft
    {
        public List<IReturnItemDraft> Items { get; set; }

        public string ReturnTrackingId { get; set; }

        public DateTime? ReturnDate { get; set; }
    }
}
