namespace commercetools.ImportApi.Models.Common
{
    public partial class KeyReference : IKeyReference
    {
        public string Key { get; set;}
        
        public IReferenceType TypeId { get; set;}
    }
}
