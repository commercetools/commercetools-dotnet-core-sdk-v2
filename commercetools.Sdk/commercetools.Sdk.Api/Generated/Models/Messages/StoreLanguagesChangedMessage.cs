using commercetools.Sdk.Api.Models.Common;
using System;
using System.Collections.Generic;


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

        public List<string> AddedLanguages { get; set; }

        public List<string> RemovedLanguages { get; set; }
        public StoreLanguagesChangedMessage()
        {
            this.Type = "StoreLanguagesChanged";
        }
    }
}
