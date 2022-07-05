namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class KeyReference : IKeyReference
    {
        public string Key { get; set; }

        public IReferenceTypeId TypeId { get; set; }
    }
}
