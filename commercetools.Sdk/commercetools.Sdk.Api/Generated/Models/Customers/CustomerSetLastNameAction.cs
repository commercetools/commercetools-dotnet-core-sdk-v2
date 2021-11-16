namespace commercetools.Api.Models.Customers
{
    public partial class CustomerSetLastNameAction : ICustomerSetLastNameAction
    {
        public string Action { get; set;}
        
        public string LastName { get; set;}
        public CustomerSetLastNameAction()
        { 
           this.Action = "setLastName";
        }
    }
}
