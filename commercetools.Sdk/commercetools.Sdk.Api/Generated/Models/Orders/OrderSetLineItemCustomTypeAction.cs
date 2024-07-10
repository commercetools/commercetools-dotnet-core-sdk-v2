using commercetools.Sdk.Api.Models.Types;


namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class OrderSetLineItemCustomTypeAction : IOrderSetLineItemCustomTypeAction
    {
        public string Action { get; set; }

        public string LineItemId { get; set; }

        public string LineItemKey { get; set; }

        public ITypeResourceIdentifier Type { get; set; }

        public IFieldContainer Fields { get; set; }
        public OrderSetLineItemCustomTypeAction()
        {
            this.Action = "setLineItemCustomType";
        }
    }
}
