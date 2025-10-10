

namespace commercetools.Sdk.CheckoutApi.Models.Applications
{

    public partial class SetAllowedOriginsUpdateAction : ISetAllowedOriginsUpdateAction
    {
        public string Action { get; set; }

        public IAllowedOrigins AllowedOrigins { get; set; }
        public SetAllowedOriginsUpdateAction()
        {
            this.Action = "setAllowedOrigins";
        }
    }
}
