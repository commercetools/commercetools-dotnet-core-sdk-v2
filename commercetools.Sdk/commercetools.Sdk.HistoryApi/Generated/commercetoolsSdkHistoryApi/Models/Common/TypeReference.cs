

namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class TypeReference : ITypeReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }
        public TypeReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("type");
        }
    }
}
