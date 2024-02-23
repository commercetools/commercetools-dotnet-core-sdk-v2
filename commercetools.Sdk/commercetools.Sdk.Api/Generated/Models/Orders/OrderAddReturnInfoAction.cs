using System;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class OrderAddReturnInfoAction : IOrderAddReturnInfoAction
    {
        public string Action { get; set; }

        public string ReturnTrackingId { get; set; }

        public IList<IReturnItemDraft> Items { get; set; }
        public IEnumerable<IReturnItemDraft> ItemsEnumerable { set => Items = value.ToList(); }


        public DateTime? ReturnDate { get; set; }
        public OrderAddReturnInfoAction()
        {
            this.Action = "addReturnInfo";
        }
    }
}
