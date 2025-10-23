

namespace commercetools.Sdk.HistoryApi.Models.Common
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
