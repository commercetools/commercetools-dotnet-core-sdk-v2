using commercetools.Sdk.Api.Models.BusinessUnits;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class BusinessUnitAssociateAddedMessagePayload : IBusinessUnitAssociateAddedMessagePayload
    {
        public string Type { get; set; }

        public IAssociate Associate { get; set; }
        public BusinessUnitAssociateAddedMessagePayload()
        {
            this.Type = "BusinessUnitAssociateAdded";
        }
    }
}
