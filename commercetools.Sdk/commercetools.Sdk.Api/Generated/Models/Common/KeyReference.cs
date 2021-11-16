namespace commercetools.Api.Models.Common
{
    public partial class KeyReference : IKeyReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Key { get; set; }
    }
}
