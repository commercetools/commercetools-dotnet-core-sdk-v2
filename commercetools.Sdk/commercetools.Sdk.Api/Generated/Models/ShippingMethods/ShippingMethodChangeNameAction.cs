namespace commercetools.Api.Models.ShippingMethods
{
    public partial class ShippingMethodChangeNameAction : IShippingMethodChangeNameAction
    {
        public string Action { get; set; }

        public string Name { get; set; }
        public ShippingMethodChangeNameAction()
        {
            this.Action = "changeName";
        }
    }
}
