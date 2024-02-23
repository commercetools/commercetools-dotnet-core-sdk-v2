using commercetools.Sdk.Api.Models.BusinessUnits;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class BusinessUnitCreatedMessagePayload : IBusinessUnitCreatedMessagePayload
    {
        public string Type { get; set; }

        public IBusinessUnit BusinessUnit { get; set; }
        public BusinessUnitCreatedMessagePayload()
        {
            this.Type = "BusinessUnitCreated";
        }
    }
}
