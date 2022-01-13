namespace commercetools.Api.Models.ShippingMethods
{
    public partial class ShippingMethodSetDescriptionAction : IShippingMethodSetDescriptionAction
    {
        public string Action { get; set; }

        public string Description { get; set; }
        public ShippingMethodSetDescriptionAction()
        {
            this.Action = "setDescription";
        }
    }
}
