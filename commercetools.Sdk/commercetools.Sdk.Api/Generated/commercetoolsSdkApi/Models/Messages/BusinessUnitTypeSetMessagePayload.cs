using commercetools.Sdk.Api.Models.BusinessUnits;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class BusinessUnitTypeSetMessagePayload : IBusinessUnitTypeSetMessagePayload
    {
        public string Type { get; set; }

        public IBusinessUnitKeyReference ParentUnit { get; set; }

        public IBusinessUnitKeyReference OldParentUnit { get; set; }

        public IBusinessUnitType UnitType { get; set; }

        public IBusinessUnitType OldUnitType { get; set; }
        public BusinessUnitTypeSetMessagePayload()
        {
            this.Type = "BusinessUnitTypeSet";
        }
    }
}
