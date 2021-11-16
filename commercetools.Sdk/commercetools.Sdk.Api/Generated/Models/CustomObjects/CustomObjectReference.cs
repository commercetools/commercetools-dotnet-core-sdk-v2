using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.CustomObjects
{
    public partial class CustomObjectReference : ICustomObjectReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public ICustomObject Obj { get; set; }
        public CustomObjectReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("key-value-document");
        }
    }
}
