using commercetools.Api.Models.Types;


namespace commercetools.Api.Models.Me
{
    public partial class MyCustomerSetCustomTypeAction : IMyCustomerSetCustomTypeAction
    {
        public string Action { get; set;}
        
        public ITypeResourceIdentifier Type { get; set;}
        
        public IFieldContainer Fields { get; set;}
        public MyCustomerSetCustomTypeAction()
        { 
           this.Action = "setCustomType";
        }
    }
}
