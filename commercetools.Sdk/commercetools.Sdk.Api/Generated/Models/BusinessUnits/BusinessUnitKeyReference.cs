using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.BusinessUnits
{

    public partial class BusinessUnitKeyReference : IBusinessUnitKeyReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Key { get; set; }
        public BusinessUnitKeyReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("business-unit");
        }
    }
}
