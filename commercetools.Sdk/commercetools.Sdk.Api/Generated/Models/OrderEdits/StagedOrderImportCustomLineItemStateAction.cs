using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class StagedOrderImportCustomLineItemStateAction : IStagedOrderImportCustomLineItemStateAction
    {
        public string Action { get; set; }

        public string CustomLineItemId { get; set; }

        public List<IItemState> State { get; set; }
        public StagedOrderImportCustomLineItemStateAction()
        {
            this.Action = "importCustomLineItemState";
        }
    }
}
