using commercetools.Api.Models.Types;


namespace commercetools.Api.Models.Orders
{
    public partial class OrderSetLineItemCustomTypeAction : IOrderSetLineItemCustomTypeAction
    {
        public string Action { get; set; }

        public string LineItemId { get; set; }

        public ITypeResourceIdentifier Type { get; set; }

        public IFieldContainer Fields { get; set; }
        public OrderSetLineItemCustomTypeAction()
        {
            this.Action = "setLineItemCustomType";
        }
    }
}
