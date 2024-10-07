

namespace commercetools.Sdk.ImportApi.Models.Common
{

    public partial class TypeKeyReference : ITypeKeyReference
    {
        public string Key { get; set; }

        public IReferenceType TypeId { get; set; }
        public TypeKeyReference()
        {
            this.TypeId = IReferenceType.FindEnum("type");
        }
    }
}
