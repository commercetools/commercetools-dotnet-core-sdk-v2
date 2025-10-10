

namespace commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations
{

    public partial class SetDisplayInfoUpdateAction : ISetDisplayInfoUpdateAction
    {
        public string Action { get; set; }

        public IDisplayInfo DisplayInfo { get; set; }
        public SetDisplayInfoUpdateAction()
        {
            this.Action = "setDisplayInfo";
        }
    }
}
