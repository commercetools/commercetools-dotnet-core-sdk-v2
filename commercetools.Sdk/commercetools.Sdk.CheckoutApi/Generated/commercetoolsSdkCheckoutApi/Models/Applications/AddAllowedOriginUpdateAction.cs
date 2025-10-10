

namespace commercetools.Sdk.CheckoutApi.Models.Applications
{

    public partial class AddAllowedOriginUpdateAction : IAddAllowedOriginUpdateAction
    {
        public string Action { get; set; }

        public string Origin { get; set; }
        public AddAllowedOriginUpdateAction()
        {
            this.Action = "addAllowedOrigin";
        }
    }
}
