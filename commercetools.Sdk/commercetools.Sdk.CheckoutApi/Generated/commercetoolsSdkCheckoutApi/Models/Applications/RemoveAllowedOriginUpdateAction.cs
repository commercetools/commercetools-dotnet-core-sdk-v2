

namespace commercetools.Sdk.CheckoutApi.Models.Applications
{

    public partial class RemoveAllowedOriginUpdateAction : IRemoveAllowedOriginUpdateAction
    {
        public string Action { get; set; }

        public string Origin { get; set; }
        public RemoveAllowedOriginUpdateAction()
        {
            this.Action = "removeAllowedOrigin";
        }
    }
}
