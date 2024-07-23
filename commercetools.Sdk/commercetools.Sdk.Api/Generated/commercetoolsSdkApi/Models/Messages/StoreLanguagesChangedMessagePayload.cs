using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class StoreLanguagesChangedMessagePayload : IStoreLanguagesChangedMessagePayload
    {
        public string Type { get; set; }

        public IList<string> AddedLanguages { get; set; }
        public IEnumerable<string> AddedLanguagesEnumerable { set => AddedLanguages = value.ToList(); }


        public IList<string> RemovedLanguages { get; set; }
        public IEnumerable<string> RemovedLanguagesEnumerable { set => RemovedLanguages = value.ToList(); }

        public StoreLanguagesChangedMessagePayload()
        {
            this.Type = "StoreLanguagesChanged";
        }
    }
}
