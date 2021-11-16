namespace commercetools.Api.Models.Customers
{
    public partial class CustomerSetKeyAction : ICustomerSetKeyAction
    {
        public string Action { get; set;}
        
        public string Key { get; set;}
        public CustomerSetKeyAction()
        { 
           this.Action = "setKey";
        }
    }
}
