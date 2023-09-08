using commercetools.Sdk.Api.Models.Types;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class BusinessUnitAddressCustomTypeSetMessagePayload : IBusinessUnitAddressCustomTypeSetMessagePayload
    {
        public string Type { get; set; }

        public ICustomFields CustomFields { get; set; }

        public string OldTypeId { get; set; }
        public BusinessUnitAddressCustomTypeSetMessagePayload()
        {
            this.Type = "BusinessUnitAddressCustomTypeSet";
        }
    }
}
