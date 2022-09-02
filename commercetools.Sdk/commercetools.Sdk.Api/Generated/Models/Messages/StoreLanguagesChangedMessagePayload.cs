using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class StoreLanguagesChangedMessagePayload : IStoreLanguagesChangedMessagePayload
    {
        public string Type { get; set; }

        public List<string> AddedLanguages { get; set; }

        public List<string> RemovedLanguages { get; set; }
        public StoreLanguagesChangedMessagePayload()
        {
            this.Type = "StoreLanguagesChanged";
        }
    }
}
