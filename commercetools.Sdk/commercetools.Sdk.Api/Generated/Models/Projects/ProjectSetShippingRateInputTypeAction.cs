namespace commercetools.Sdk.Api.Models.Projects
{

    public partial class ProjectSetShippingRateInputTypeAction : IProjectSetShippingRateInputTypeAction
    {
        public string Action { get; set; }

        public IShippingRateInputType ShippingRateInputType { get; set; }
        public ProjectSetShippingRateInputTypeAction()
        {
            this.Action = "setShippingRateInputType";
        }
    }
}
