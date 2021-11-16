namespace commercetools.Api.Models.Carts
{
    public partial class CartSetLocaleAction : ICartSetLocaleAction
    {
        public string Action { get; set;}
        
        public string Locale { get; set;}
        public CartSetLocaleAction()
        { 
           this.Action = "setLocale";
        }
    }
}
