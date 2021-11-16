namespace commercetools.Api.Models.ProductDiscounts
{
    public partial class ProductDiscountChangeIsActiveAction : IProductDiscountChangeIsActiveAction
    {
        public string Action { get; set;}
        
        public bool IsActive { get; set;}
        public ProductDiscountChangeIsActiveAction()
        { 
           this.Action = "changeIsActive";
        }
    }
}
