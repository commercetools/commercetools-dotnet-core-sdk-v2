

namespace commercetools.Sdk.ImportApi.Models.Common
{

    public partial class StateKeyReference : IStateKeyReference
    {
        public string Key { get; set; }

        public IReferenceType TypeId { get; set; }
        public StateKeyReference()
        {
            this.TypeId = IReferenceType.FindEnum("state");
        }
    }
}
