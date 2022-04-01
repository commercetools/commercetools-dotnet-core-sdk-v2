using commercetools.Sdk.Api.Models.Orders;
using System;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    public partial class StagedOrderAddReturnInfoAction : IStagedOrderAddReturnInfoAction
    {
        public string Action { get; set; }

        public string ReturnTrackingId { get; set; }

        public List<IReturnItemDraft> Items { get; set; }

        public DateTime? ReturnDate { get; set; }
        public StagedOrderAddReturnInfoAction()
        {
            this.Action = "addReturnInfo";
        }
    }
}
