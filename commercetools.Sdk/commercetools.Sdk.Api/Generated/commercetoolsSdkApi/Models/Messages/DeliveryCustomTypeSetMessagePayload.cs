using commercetools.Sdk.Api.Models.Types;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class DeliveryCustomTypeSetMessagePayload : IDeliveryCustomTypeSetMessagePayload
    {
        public string Type { get; set; }

        public ICustomFields CustomFields { get; set; }

        public string PreviousTypeId { get; set; }

        public string DeliveryId { get; set; }
        public DeliveryCustomTypeSetMessagePayload()
        {
            this.Type = "DeliveryCustomTypeSet";
        }
    }
}
