using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class StagedOrderChangeCustomLineItemMoneyAction : IStagedOrderChangeCustomLineItemMoneyAction
    {
        public string Action { get; set; }

        public string CustomLineItemId { get; set; }

        public IMoney Money { get; set; }
        public StagedOrderChangeCustomLineItemMoneyAction()
        {
            this.Action = "changeCustomLineItemMoney";
        }
    }
}
