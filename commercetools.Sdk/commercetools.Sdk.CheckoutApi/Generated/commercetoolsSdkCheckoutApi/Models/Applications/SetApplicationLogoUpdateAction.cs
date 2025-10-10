

namespace commercetools.Sdk.CheckoutApi.Models.Applications
{

    public partial class SetApplicationLogoUpdateAction : ISetApplicationLogoUpdateAction
    {
        public string Action { get; set; }

        public IApplicationLogo Logo { get; set; }
        public SetApplicationLogoUpdateAction()
        {
            this.Action = "setApplicationLogo";
        }
    }
}
