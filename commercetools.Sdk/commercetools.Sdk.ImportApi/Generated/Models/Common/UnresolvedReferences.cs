namespace commercetools.Sdk.ImportApi.Models.Common
{

    public partial class UnresolvedReferences : IUnresolvedReferences
    {
        public string Key { get; set; }

        public IReferenceType TypeId { get; set; }
    }
}
