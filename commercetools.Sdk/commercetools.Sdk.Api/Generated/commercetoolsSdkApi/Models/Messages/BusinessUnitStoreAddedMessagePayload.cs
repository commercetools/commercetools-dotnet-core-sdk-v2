using commercetools.Sdk.Api.Models.Stores;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class BusinessUnitStoreAddedMessagePayload : IBusinessUnitStoreAddedMessagePayload
    {
        public string Type { get; set; }

        public IStoreKeyReference Store { get; set; }
        public BusinessUnitStoreAddedMessagePayload()
        {
            this.Type = "BusinessUnitStoreAdded";
        }
    }
}
