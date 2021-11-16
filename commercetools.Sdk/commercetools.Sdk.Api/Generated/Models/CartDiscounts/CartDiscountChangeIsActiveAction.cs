namespace commercetools.Api.Models.CartDiscounts
{
    public partial class CartDiscountChangeIsActiveAction : ICartDiscountChangeIsActiveAction
    {
        public string Action { get; set;}
        
        public bool IsActive { get; set;}
        public CartDiscountChangeIsActiveAction()
        { 
           this.Action = "changeIsActive";
        }
    }
}
