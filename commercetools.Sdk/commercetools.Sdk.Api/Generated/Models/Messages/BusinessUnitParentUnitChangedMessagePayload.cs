using commercetools.Sdk.Api.Models.BusinessUnits;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class BusinessUnitParentUnitChangedMessagePayload : IBusinessUnitParentUnitChangedMessagePayload
    {
        public string Type { get; set; }

        public IBusinessUnitKeyReference OldParentUnit { get; set; }

        public IBusinessUnitKeyReference NewParentUnit { get; set; }
        public BusinessUnitParentUnitChangedMessagePayload()
        {
            this.Type = "BusinessUnitParentUnitChanged";
        }
    }
}
