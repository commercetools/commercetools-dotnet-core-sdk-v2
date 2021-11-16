namespace commercetools.Api.Models.Customers
{
    public partial class CustomerChangeEmailAction : ICustomerChangeEmailAction
    {
        public string Action { get; set;}
        
        public string Email { get; set;}
        public CustomerChangeEmailAction()
        { 
           this.Action = "changeEmail";
        }
    }
}
