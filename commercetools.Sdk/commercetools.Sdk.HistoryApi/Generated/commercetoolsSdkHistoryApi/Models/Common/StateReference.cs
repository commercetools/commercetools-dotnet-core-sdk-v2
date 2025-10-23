

namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class StateReference : IStateReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }
        public StateReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("state");
        }
    }
}
