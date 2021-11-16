namespace commercetools.Api.Models.Me
{
    public partial class MyCustomerSetMiddleNameAction : IMyCustomerSetMiddleNameAction
    {
        public string Action { get; set;}
        
        public string MiddleName { get; set;}
        public MyCustomerSetMiddleNameAction()
        { 
           this.Action = "setMiddleName";
        }
    }
}
