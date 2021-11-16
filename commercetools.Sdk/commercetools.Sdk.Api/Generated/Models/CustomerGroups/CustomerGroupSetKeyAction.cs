namespace commercetools.Api.Models.CustomerGroups
{
    public partial class CustomerGroupSetKeyAction : ICustomerGroupSetKeyAction
    {
        public string Action { get; set;}
        
        public string Key { get; set;}
        public CustomerGroupSetKeyAction()
        { 
           this.Action = "setKey";
        }
    }
}
