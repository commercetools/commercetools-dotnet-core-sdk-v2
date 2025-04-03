using commercetools.Sdk.Api.Models.BusinessUnits;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class BusinessUnitTopLevelUnitSetMessagePayload : IBusinessUnitTopLevelUnitSetMessagePayload
    {
        public string Type { get; set; }

        public IBusinessUnitKeyReference TopLevelUnit { get; set; }

        public IBusinessUnitKeyReference OldTopLevelUnit { get; set; }
        public BusinessUnitTopLevelUnitSetMessagePayload()
        {
            this.Type = "BusinessUnitTopLevelUnitSet";
        }
    }
}
