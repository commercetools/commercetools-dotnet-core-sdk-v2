

namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyPaymentSetMethodInfoMethodAction : IMyPaymentSetMethodInfoMethodAction
    {
        public string Action { get; set; }

        public string Method { get; set; }
        public MyPaymentSetMethodInfoMethodAction()
        {
            this.Action = "setMethodInfoMethod";
        }
    }
}
