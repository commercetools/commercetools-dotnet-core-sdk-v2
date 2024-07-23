using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.BusinessUnits
{

    public partial class BusinessUnitReference : IBusinessUnitReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public IBusinessUnit Obj { get; set; }
        public BusinessUnitReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("business-unit");
        }
    }
}
