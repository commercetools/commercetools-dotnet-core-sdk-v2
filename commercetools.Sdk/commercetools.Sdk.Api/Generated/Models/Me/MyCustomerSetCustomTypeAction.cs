using commercetools.Sdk.Api.Models.Types;


namespace commercetools.Sdk.Api.Models.Me
{
    public partial class MyCustomerSetCustomTypeAction : IMyCustomerSetCustomTypeAction
    {
        public string Action { get; set; }

        public ITypeResourceIdentifier Type { get; set; }

        public IFieldContainer Fields { get; set; }
        public MyCustomerSetCustomTypeAction()
        {
            this.Action = "setCustomType";
        }
    }
}
