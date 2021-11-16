namespace commercetools.Api.Models.Carts
{
    public partial class CartSetCustomerEmailAction : ICartSetCustomerEmailAction
    {
        public string Action { get; set;}
        
        public string Email { get; set;}
        public CartSetCustomerEmailAction()
        { 
           this.Action = "setCustomerEmail";
        }
    }
}
