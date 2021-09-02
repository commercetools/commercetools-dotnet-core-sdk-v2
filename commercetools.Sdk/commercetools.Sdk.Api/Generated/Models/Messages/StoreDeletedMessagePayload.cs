using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    public partial class StoreDeletedMessagePayload : IStoreDeletedMessagePayload
    {
        public string Type { get; set; }
        public StoreDeletedMessagePayload()
        {
            this.Type = "StoreDeleted";
        }
    }
}
