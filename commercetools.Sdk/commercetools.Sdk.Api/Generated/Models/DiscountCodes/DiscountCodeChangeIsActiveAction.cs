namespace commercetools.Api.Models.DiscountCodes
{
    public partial class DiscountCodeChangeIsActiveAction : IDiscountCodeChangeIsActiveAction
    {
        public string Action { get; set;}
        
        public bool IsActive { get; set;}
        public DiscountCodeChangeIsActiveAction()
        { 
           this.Action = "changeIsActive";
        }
    }
}
