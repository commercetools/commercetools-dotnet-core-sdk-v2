using commercetools.Sdk.Api.Models.Types;


namespace commercetools.Sdk.Api.Models.Orders
{
    public partial class OrderSetBillingAddressCustomTypeAction : IOrderSetBillingAddressCustomTypeAction
    {
        public string Action { get; set; }

        public ITypeResourceIdentifier Type { get; set; }

        public IFieldContainer Fields { get; set; }
        public OrderSetBillingAddressCustomTypeAction()
        {
            this.Action = "setBillingAddressCustomType";
        }
    }
}
