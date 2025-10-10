

namespace commercetools.Sdk.CheckoutApi.Models.Applications
{

    public partial class SetApplicationStatusUpdateAction : ISetApplicationStatusUpdateAction
    {
        public string Action { get; set; }

        public IApplicationStatus Status { get; set; }
        public SetApplicationStatusUpdateAction()
        {
            this.Action = "setStatus";
        }
    }
}
