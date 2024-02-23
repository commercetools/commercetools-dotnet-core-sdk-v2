using commercetools.Sdk.Api.Models.BusinessUnits;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class BusinessUnitParentChangedMessagePayload : IBusinessUnitParentChangedMessagePayload
    {
        public string Type { get; set; }

        public IBusinessUnitKeyReference OldParentUnit { get; set; }

        public IBusinessUnitKeyReference NewParentUnit { get; set; }
        public BusinessUnitParentChangedMessagePayload()
        {
            this.Type = "BusinessUnitParentChanged";
        }
    }
}
