

namespace commercetools.Sdk.ImportApi.Models.Common
{

    public partial class BusinessUnitKeyReference : IBusinessUnitKeyReference
    {
        public string Key { get; set; }

        public IReferenceType TypeId { get; set; }
        public BusinessUnitKeyReference()
        {
            this.TypeId = IReferenceType.FindEnum("business-unit");
        }
    }
}
