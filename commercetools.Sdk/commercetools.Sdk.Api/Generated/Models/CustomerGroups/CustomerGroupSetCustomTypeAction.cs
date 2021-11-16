using commercetools.Api.Models.Types;


namespace commercetools.Api.Models.CustomerGroups
{
    public partial class CustomerGroupSetCustomTypeAction : ICustomerGroupSetCustomTypeAction
    {
        public string Action { get; set;}
        
        public ITypeResourceIdentifier Type { get; set;}
        
        public IFieldContainer Fields { get; set;}
        public CustomerGroupSetCustomTypeAction()
        { 
           this.Action = "setCustomType";
        }
    }
}
