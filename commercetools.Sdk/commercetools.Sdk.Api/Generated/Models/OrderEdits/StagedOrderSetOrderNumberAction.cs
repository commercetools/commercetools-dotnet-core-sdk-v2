namespace commercetools.Sdk.Api.Models.OrderEdits
{
    public partial class StagedOrderSetOrderNumberAction : IStagedOrderSetOrderNumberAction
    {
        public string Action { get; set; }

        public string OrderNumber { get; set; }
        public StagedOrderSetOrderNumberAction()
        {
            this.Action = "setOrderNumber";
        }
    }
}
