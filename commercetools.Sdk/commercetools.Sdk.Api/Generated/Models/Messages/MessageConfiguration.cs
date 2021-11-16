using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    public partial class MessageConfiguration : IMessageConfiguration
    {
        public bool Enabled { get; set;}
        
        public int? DeleteDaysAfterCreation { get; set;}
    }
}
