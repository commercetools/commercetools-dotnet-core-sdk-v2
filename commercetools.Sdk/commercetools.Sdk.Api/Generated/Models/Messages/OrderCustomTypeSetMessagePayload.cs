using commercetools.Sdk.Api.Models.Types;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class OrderCustomTypeSetMessagePayload : IOrderCustomTypeSetMessagePayload
    {
        public string Type { get; set; }

        public ICustomFields CustomFields { get; set; }

        public string PreviousTypeId { get; set; }
        public OrderCustomTypeSetMessagePayload()
        {
            this.Type = "OrderCustomTypeSet";
        }
    }
}
