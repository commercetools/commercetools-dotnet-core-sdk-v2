

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class BusinessUnitDeletedMessagePayload : IBusinessUnitDeletedMessagePayload
    {
        public string Type { get; set; }
        public BusinessUnitDeletedMessagePayload()
        {
            this.Type = "BusinessUnitDeleted";
        }
    }
}
