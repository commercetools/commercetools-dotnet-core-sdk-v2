

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class BusinessUnitNameChangedMessagePayload : IBusinessUnitNameChangedMessagePayload
    {
        public string Type { get; set; }

        public string Name { get; set; }
        public BusinessUnitNameChangedMessagePayload()
        {
            this.Type = "BusinessUnitNameChanged";
        }
    }
}
