namespace commercetools.Api.Models.Common
{
    public partial class ResourceIdentifier : IResourceIdentifier
    {
        public IReferenceTypeId TypeId { get; set;}
        
        public string Id { get; set;}
        
        public string Key { get; set;}
    }
}
