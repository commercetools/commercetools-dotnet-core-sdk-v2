namespace commercetools.Api.Models.Me
{
    public partial class MyCartSetCustomerEmailAction : IMyCartSetCustomerEmailAction
    {
        public string Action { get; set;}
        
        public string Email { get; set;}
        public MyCartSetCustomerEmailAction()
        { 
           this.Action = "setCustomerEmail";
        }
    }
}
