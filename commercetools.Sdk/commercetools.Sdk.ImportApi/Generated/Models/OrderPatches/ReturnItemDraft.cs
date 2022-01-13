namespace commercetools.ImportApi.Models.OrderPatches
{
    public partial class ReturnItemDraft : IReturnItemDraft
    {
        public double Quantity { get; set; }

        public string LineItemId { get; set; }

        public string CustomLineItemId { get; set; }

        public string Comment { get; set; }

        public IReturnShipmentState ShipmentState { get; set; }
    }
}
