namespace commercetools.ImportApi.Models.Common
{
    public partial class CustomObjectKeyReference : ICustomObjectKeyReference
    {
        public string Key { get; set; }

        public IReferenceType TypeId { get; set; }

        public string Container { get; set; }
        public CustomObjectKeyReference()
        {
            this.TypeId = IReferenceType.FindEnum("key-value-document");
        }
    }
}
