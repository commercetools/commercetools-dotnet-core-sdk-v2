using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Orders
{
    public partial class OrderImportLineItemStateAction : IOrderImportLineItemStateAction
    {
        public string Action { get; set; }

        public string LineItemId { get; set; }

        public List<IItemState> State { get; set; }
        public OrderImportLineItemStateAction()
        {
            this.Action = "importLineItemState";
        }
    }
}
