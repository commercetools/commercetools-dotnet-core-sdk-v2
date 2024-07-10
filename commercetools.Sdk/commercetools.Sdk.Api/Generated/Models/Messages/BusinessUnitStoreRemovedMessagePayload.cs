using commercetools.Sdk.Api.Models.Stores;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class BusinessUnitStoreRemovedMessagePayload : IBusinessUnitStoreRemovedMessagePayload
    {
        public string Type { get; set; }

        public IStoreKeyReference Store { get; set; }
        public BusinessUnitStoreRemovedMessagePayload()
        {
            this.Type = "BusinessUnitStoreRemoved";
        }
    }
}
