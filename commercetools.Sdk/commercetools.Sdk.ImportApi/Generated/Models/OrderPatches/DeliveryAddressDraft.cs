using commercetools.ImportApi.Models.Common;


namespace commercetools.ImportApi.Models.OrderPatches
{
    public partial class DeliveryAddressDraft : IDeliveryAddressDraft
    {
        public string DeliveryId { get; set;}
        
        public IAddress Address { get; set;}
    }
}
