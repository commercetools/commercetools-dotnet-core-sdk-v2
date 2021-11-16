namespace commercetools.Api.Models.Carts
{
    public partial class CartSetAnonymousIdAction : ICartSetAnonymousIdAction
    {
        public string Action { get; set;}
        
        public string AnonymousId { get; set;}
        public CartSetAnonymousIdAction()
        { 
           this.Action = "setAnonymousId";
        }
    }
}
