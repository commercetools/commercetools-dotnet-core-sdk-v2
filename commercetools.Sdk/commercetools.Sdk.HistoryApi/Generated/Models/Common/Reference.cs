namespace commercetools.HistoryApi.Models.Common
{
    public partial class Reference : IReference
    {
        public string Id { get; set;}
        
        public IReferenceTypeId TypeId { get; set;}
    }
}
