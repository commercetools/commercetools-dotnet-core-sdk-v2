

namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyPaymentSetMethodInfoInterfaceAccountAction : IMyPaymentSetMethodInfoInterfaceAccountAction
    {
        public string Action { get; set; }

        public string InterfaceAccount { get; set; }
        public MyPaymentSetMethodInfoInterfaceAccountAction()
        {
            this.Action = "setMethodInfoInterfaceAccount";
        }
    }
}
