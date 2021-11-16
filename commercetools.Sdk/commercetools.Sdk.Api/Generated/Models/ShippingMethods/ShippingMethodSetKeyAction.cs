namespace commercetools.Api.Models.ShippingMethods
{
    public partial class ShippingMethodSetKeyAction : IShippingMethodSetKeyAction
    {
        public string Action { get; set;}
        
        public string Key { get; set;}
        public ShippingMethodSetKeyAction()
        { 
           this.Action = "setKey";
        }
    }
}
