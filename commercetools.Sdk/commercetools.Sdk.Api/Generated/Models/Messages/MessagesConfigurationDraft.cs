using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class MessagesConfigurationDraft : IMessagesConfigurationDraft
    {
        public bool Enabled { get; set; }

        public int DeleteDaysAfterCreation { get; set; }
    }
}
