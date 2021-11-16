using System;
using System.Collections.Generic;


namespace commercetools.Api.Models.Orders
{
    public partial class OrderAddReturnInfoAction : IOrderAddReturnInfoAction
    {
        public string Action { get; set; }

        public string ReturnTrackingId { get; set; }

        public List<IReturnItemDraft> Items { get; set; }

        public DateTime? ReturnDate { get; set; }
        public OrderAddReturnInfoAction()
        {
            this.Action = "addReturnInfo";
        }
    }
}
