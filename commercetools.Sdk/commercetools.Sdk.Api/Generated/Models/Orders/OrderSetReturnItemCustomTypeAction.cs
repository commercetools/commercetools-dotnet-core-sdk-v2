using commercetools.Api.Models.Types;


namespace commercetools.Api.Models.Orders
{
    public partial class OrderSetReturnItemCustomTypeAction : IOrderSetReturnItemCustomTypeAction
    {
        public string Action { get; set; }

        public string ReturnItemId { get; set; }

        public ITypeResourceIdentifier Type { get; set; }

        public IFieldContainer Fields { get; set; }
        public OrderSetReturnItemCustomTypeAction()
        {
            this.Action = "setReturnItemCustomType";
        }
    }
}
