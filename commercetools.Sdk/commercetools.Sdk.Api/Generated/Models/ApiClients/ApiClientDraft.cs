namespace commercetools.Api.Models.ApiClients
{
    public partial class ApiClientDraft : IApiClientDraft
    {
        public string Name { get; set;}
        
        public string Scope { get; set;}
        
        public long? DeleteDaysAfterCreation { get; set;}
    }
}
