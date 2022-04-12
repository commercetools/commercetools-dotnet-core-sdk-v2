namespace commercetools.Sdk.ImportApi.Models.OrderPatches
{
    public partial class ReturnItemDraft : IReturnItemDraft
    {
        public decimal Quantity { get; set; }

        public string LineItemId { get; set; }

        public string CustomLineItemId { get; set; }

        public string Comment { get; set; }

        public IReturnShipmentState ShipmentState { get; set; }
    }
}
