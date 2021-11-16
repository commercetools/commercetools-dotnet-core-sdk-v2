namespace commercetools.Api.Models.CustomerGroups
{
    public partial class CustomerGroupChangeNameAction : ICustomerGroupChangeNameAction
    {
        public string Action { get; set;}
        
        public string Name { get; set;}
        public CustomerGroupChangeNameAction()
        { 
           this.Action = "changeName";
        }
    }
}
