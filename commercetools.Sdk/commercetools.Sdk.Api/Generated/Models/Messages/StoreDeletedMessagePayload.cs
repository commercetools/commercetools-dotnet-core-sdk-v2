namespace commercetools.Api.Models.Messages
{
    public partial class StoreDeletedMessagePayload : IStoreDeletedMessagePayload
    {
        public string Type { get; set;}
        public StoreDeletedMessagePayload()
        { 
           this.Type = "StoreDeleted";
        }
    }
}
