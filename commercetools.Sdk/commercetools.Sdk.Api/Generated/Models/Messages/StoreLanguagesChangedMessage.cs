using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class StoreLanguagesChangedMessage : IStoreLanguagesChangedMessage
    {
        public string Id { get; set; }

        public long Version { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastModifiedAt { get; set; }

        public ILastModifiedBy LastModifiedBy { get; set; }

        public ICreatedBy CreatedBy { get; set; }

        public long SequenceNumber { get; set; }

        public IReference Resource { get; set; }

        public long ResourceVersion { get; set; }

        public string Type { get; set; }

        public IUserProvidedIdentifiers ResourceUserProvidedIdentifiers { get; set; }

        public IList<string> AddedLanguages { get; set; }
        public IEnumerable<string> AddedLanguagesEnumerable { set => AddedLanguages = value.ToList(); }


        public IList<string> RemovedLanguages { get; set; }
        public IEnumerable<string> RemovedLanguagesEnumerable { set => RemovedLanguages = value.ToList(); }

        public StoreLanguagesChangedMessage()
        {
            this.Type = "StoreLanguagesChanged";
        }
    }
}
