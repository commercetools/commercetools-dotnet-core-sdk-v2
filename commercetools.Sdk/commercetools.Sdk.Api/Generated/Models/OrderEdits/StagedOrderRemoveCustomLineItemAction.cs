namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class StagedOrderRemoveCustomLineItemAction : IStagedOrderRemoveCustomLineItemAction
    {
        public string Action { get; set; }

        public string CustomLineItemId { get; set; }
        public StagedOrderRemoveCustomLineItemAction()
        {
            this.Action = "removeCustomLineItem";
        }
    }
}
