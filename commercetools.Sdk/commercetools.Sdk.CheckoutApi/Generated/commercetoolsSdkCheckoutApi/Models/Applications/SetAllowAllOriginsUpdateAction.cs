

namespace commercetools.Sdk.CheckoutApi.Models.Applications
{

    public partial class SetAllowAllOriginsUpdateAction : ISetAllowAllOriginsUpdateAction
    {
        public string Action { get; set; }

        public bool AllowAll { get; set; }
        public SetAllowAllOriginsUpdateAction()
        {
            this.Action = "setAllowAllOrigins";
        }
    }
}
