using commercetools.Sdk.Api.Models.Types;


namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyPaymentSetMethodInfoCustomTypeAction : IMyPaymentSetMethodInfoCustomTypeAction
    {
        public string Action { get; set; }

        public ITypeResourceIdentifier Type { get; set; }

        public IFieldContainer Fields { get; set; }
        public MyPaymentSetMethodInfoCustomTypeAction()
        {
            this.Action = "setMethodInfoCustomType";
        }
    }
}
