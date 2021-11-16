namespace commercetools.Api.Models.Carts
{
    public partial class CartChangeTaxModeAction : ICartChangeTaxModeAction
    {
        public string Action { get; set;}
        
        public ITaxMode TaxMode { get; set;}
        public CartChangeTaxModeAction()
        { 
           this.Action = "changeTaxMode";
        }
    }
}
