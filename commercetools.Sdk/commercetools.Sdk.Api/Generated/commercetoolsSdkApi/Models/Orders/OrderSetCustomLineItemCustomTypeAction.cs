using commercetools.Sdk.Api.Models.Types;


namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class OrderSetCustomLineItemCustomTypeAction : IOrderSetCustomLineItemCustomTypeAction
    {
        public string Action { get; set; }

        public string CustomLineItemId { get; set; }

        public string CustomLineItemKey { get; set; }

        public ITypeResourceIdentifier Type { get; set; }

        public IFieldContainer Fields { get; set; }
        public OrderSetCustomLineItemCustomTypeAction()
        {
            this.Action = "setCustomLineItemCustomType";
        }
    }
}
