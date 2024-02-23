using commercetools.Sdk.Api.Models.Types;


namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class OrderSetParcelCustomTypeAction : IOrderSetParcelCustomTypeAction
    {
        public string Action { get; set; }

        public string ParcelId { get; set; }

        public string ParcelKey { get; set; }

        public ITypeResourceIdentifier Type { get; set; }

        public IFieldContainer Fields { get; set; }
        public OrderSetParcelCustomTypeAction()
        {
            this.Action = "setParcelCustomType";
        }
    }
}
