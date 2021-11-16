using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Me
{
    public partial class MyCustomerChangeAddressAction : IMyCustomerChangeAddressAction
    {
        public string Action { get; set;}
        
        public string AddressId { get; set;}
        
        public string AddressKey { get; set;}
        
        public IBaseAddress Address { get; set;}
        public MyCustomerChangeAddressAction()
        { 
           this.Action = "changeAddress";
        }
    }
}
