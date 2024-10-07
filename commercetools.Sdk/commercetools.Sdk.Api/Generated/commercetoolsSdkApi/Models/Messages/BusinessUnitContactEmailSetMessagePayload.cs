

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class BusinessUnitContactEmailSetMessagePayload : IBusinessUnitContactEmailSetMessagePayload
    {
        public string Type { get; set; }

        public string ContactEmail { get; set; }
        public BusinessUnitContactEmailSetMessagePayload()
        {
            this.Type = "BusinessUnitContactEmailSet";
        }
    }
}
