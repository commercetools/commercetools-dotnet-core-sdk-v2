namespace commercetools.Api.Models.OrderEdits
{
    public partial class StagedOrderAddDiscountCodeAction : IStagedOrderAddDiscountCodeAction
    {
        public string Action { get; set;}
        
        public string Code { get; set;}
        public StagedOrderAddDiscountCodeAction()
        { 
           this.Action = "addDiscountCode";
        }
    }
}
