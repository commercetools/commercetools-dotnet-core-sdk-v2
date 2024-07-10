using commercetools.Sdk.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


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
