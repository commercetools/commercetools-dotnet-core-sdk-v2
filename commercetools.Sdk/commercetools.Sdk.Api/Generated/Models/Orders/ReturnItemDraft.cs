using commercetools.Api.Models.Types;


namespace commercetools.Api.Models.Orders
{
    public partial class ReturnItemDraft : IReturnItemDraft
    {
        public long Quantity { get; set; }

        public string LineItemId { get; set; }

        public string CustomLineItemId { get; set; }

        public string Comment { get; set; }

        public IReturnShipmentState ShipmentState { get; set; }

        public ICustomFieldsDraft Custom { get; set; }
    }
}
