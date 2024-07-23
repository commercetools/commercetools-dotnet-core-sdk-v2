using commercetools.Sdk.Api.Models.BusinessUnits;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class BusinessUnitAssociateModeChangedMessagePayload : IBusinessUnitAssociateModeChangedMessagePayload
    {
        public string Type { get; set; }

        public IBusinessUnitAssociateMode AssociateMode { get; set; }

        public IBusinessUnitAssociateMode OldAssociateMode { get; set; }
        public BusinessUnitAssociateModeChangedMessagePayload()
        {
            this.Type = "BusinessUnitAssociateModeChanged";
        }
    }
}
