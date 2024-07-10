using commercetools.Sdk.Api.Models.BusinessUnits;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class BusinessUnitStatusChangedMessagePayload : IBusinessUnitStatusChangedMessagePayload
    {
        public string Type { get; set; }

        public IBusinessUnitStatus Active { get; set; }
        public BusinessUnitStatusChangedMessagePayload()
        {
            this.Type = "BusinessUnitStatusChanged";
        }
    }
}
