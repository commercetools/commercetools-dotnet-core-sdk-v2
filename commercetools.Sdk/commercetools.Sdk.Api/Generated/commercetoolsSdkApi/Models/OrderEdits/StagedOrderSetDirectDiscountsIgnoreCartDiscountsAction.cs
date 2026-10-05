namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class StagedOrderSetDirectDiscountsIgnoreCartDiscountsAction : IStagedOrderSetDirectDiscountsIgnoreCartDiscountsAction
    {
        public string Action { get; set; }

        public bool? DirectDiscountsIgnoreCartDiscounts { get; set; }
        public StagedOrderSetDirectDiscountsIgnoreCartDiscountsAction()
        {
            this.Action = "setDirectDiscountsIgnoreCartDiscounts";
        }
    }
}
