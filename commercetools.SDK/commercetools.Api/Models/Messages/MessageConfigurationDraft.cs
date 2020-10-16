using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;


namespace commercetools.Api.Models.Messages
{
    public partial class MessageConfigurationDraft 
    {
        public bool Enabled { get; set;}
        
        public int DeleteDaysAfterCreation { get; set;}
    }
}
