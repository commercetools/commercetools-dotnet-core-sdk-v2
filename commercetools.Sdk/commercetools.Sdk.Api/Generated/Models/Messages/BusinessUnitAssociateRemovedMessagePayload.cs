using commercetools.Sdk.Api.Models.BusinessUnits;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class BusinessUnitAssociateRemovedMessagePayload : IBusinessUnitAssociateRemovedMessagePayload
    {
        public string Type { get; set; }

        public IAssociate Associate { get; set; }
        public BusinessUnitAssociateRemovedMessagePayload()
        {
            this.Type = "BusinessUnitAssociateRemoved";
        }
    }
}
