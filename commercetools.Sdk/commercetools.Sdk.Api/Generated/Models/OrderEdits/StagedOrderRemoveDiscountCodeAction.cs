using commercetools.Api.Models.DiscountCodes;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class StagedOrderRemoveDiscountCodeAction : IStagedOrderRemoveDiscountCodeAction
    {
        public string Action { get; set; }

        public IDiscountCodeReference DiscountCode { get; set; }
        public StagedOrderRemoveDiscountCodeAction()
        {
            this.Action = "removeDiscountCode";
        }
    }
}
