

namespace commercetools.Sdk.CheckoutApi.Models.Applications
{

    public partial class SetApplicationNameUpdateAction : ISetApplicationNameUpdateAction
    {
        public string Action { get; set; }

        public string Name { get; set; }
        public SetApplicationNameUpdateAction()
        {
            this.Action = "setName";
        }
    }
}
