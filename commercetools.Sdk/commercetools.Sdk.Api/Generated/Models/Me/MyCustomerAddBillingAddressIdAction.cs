namespace commercetools.Api.Models.Me
{
    public partial class MyCustomerAddBillingAddressIdAction : IMyCustomerAddBillingAddressIdAction
    {
        public string Action { get; set;}
        
        public string AddressId { get; set;}
        
        public string AddressKey { get; set;}
        public MyCustomerAddBillingAddressIdAction()
        { 
           this.Action = "addBillingAddressId";
        }
    }
}
