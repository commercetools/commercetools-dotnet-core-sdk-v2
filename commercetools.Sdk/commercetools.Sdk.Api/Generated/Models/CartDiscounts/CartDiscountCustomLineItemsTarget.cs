namespace commercetools.Api.Models.CartDiscounts
{
    public partial class CartDiscountCustomLineItemsTarget : ICartDiscountCustomLineItemsTarget
    {
        public string Type { get; set;}
        
        public string Predicate { get; set;}
        public CartDiscountCustomLineItemsTarget()
        { 
           this.Type = "customLineItems";
        }
    }
}
