using commercetools.Api.Models.Carts;


namespace commercetools.Api.Models.Me
{
    public partial class MyCartSetLineItemShippingDetailsAction : IMyCartSetLineItemShippingDetailsAction
    {
        public string Action { get; set; }

        public string LineItemId { get; set; }

        public IItemShippingDetailsDraft ShippingDetails { get; set; }
        public MyCartSetLineItemShippingDetailsAction()
        {
            this.Action = "setLineItemShippingDetails";
        }
    }
}
