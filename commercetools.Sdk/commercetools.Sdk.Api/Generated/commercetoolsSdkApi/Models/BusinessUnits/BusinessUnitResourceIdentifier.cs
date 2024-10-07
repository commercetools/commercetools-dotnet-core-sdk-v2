using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.BusinessUnits
{

    public partial class BusinessUnitResourceIdentifier : IBusinessUnitResourceIdentifier
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public string Key { get; set; }
        public BusinessUnitResourceIdentifier()
        {
            this.TypeId = IReferenceTypeId.FindEnum("business-unit");
        }
    }
}
