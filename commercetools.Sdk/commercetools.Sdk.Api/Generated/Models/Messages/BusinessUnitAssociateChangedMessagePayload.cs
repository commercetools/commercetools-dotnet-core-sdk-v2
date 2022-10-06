using commercetools.Sdk.Api.Models.BusinessUnits;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class BusinessUnitAssociateChangedMessagePayload : IBusinessUnitAssociateChangedMessagePayload
    {
        public string Type { get; set; }

        public IAssociate Associate { get; set; }
        public BusinessUnitAssociateChangedMessagePayload()
        {
            this.Type = "BusinessUnitAssociateChanged";
        }
    }
}
