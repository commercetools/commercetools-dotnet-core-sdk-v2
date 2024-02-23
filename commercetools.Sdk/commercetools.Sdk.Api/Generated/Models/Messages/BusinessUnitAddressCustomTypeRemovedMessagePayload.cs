namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class BusinessUnitAddressCustomTypeRemovedMessagePayload : IBusinessUnitAddressCustomTypeRemovedMessagePayload
    {
        public string Type { get; set; }

        public string OldTypeId { get; set; }
        public BusinessUnitAddressCustomTypeRemovedMessagePayload()
        {
            this.Type = "BusinessUnitAddressCustomTypeRemoved";
        }
    }
}
