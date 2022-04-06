using commercetools.Sdk.ImportApi.Models.Common;


namespace commercetools.Sdk.ImportApi.Models.OrderPatches
{
    public partial class DeliveryAddressDraft : IDeliveryAddressDraft
    {
        public string DeliveryId { get; set; }

        public IAddress Address { get; set; }
    }
}
