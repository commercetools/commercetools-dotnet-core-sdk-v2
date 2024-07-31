

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class BusinessUnitCustomTypeRemovedMessagePayload : IBusinessUnitCustomTypeRemovedMessagePayload
    {
        public string Type { get; set; }

        public string OldTypeId { get; set; }
        public BusinessUnitCustomTypeRemovedMessagePayload()
        {
            this.Type = "BusinessUnitCustomTypeRemoved";
        }
    }
}
