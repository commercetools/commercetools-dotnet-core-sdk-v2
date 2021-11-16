using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Messages
{
    public partial class DeliveryAddressSetMessagePayload : IDeliveryAddressSetMessagePayload
    {
        public string Type { get; set; }

        public string DeliveryId { get; set; }

        public IAddress Address { get; set; }

        public IAddress OldAddress { get; set; }
        public DeliveryAddressSetMessagePayload()
        {
            this.Type = "DeliveryAddressSet";
        }
    }
}
