

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class BusinessUnitCustomFieldRemovedMessagePayload : IBusinessUnitCustomFieldRemovedMessagePayload
    {
        public string Type { get; set; }

        public string Name { get; set; }
        public BusinessUnitCustomFieldRemovedMessagePayload()
        {
            this.Type = "BusinessUnitCustomFieldRemoved";
        }
    }
}
