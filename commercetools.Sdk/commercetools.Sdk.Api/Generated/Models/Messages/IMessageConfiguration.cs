using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.MessageConfiguration))]
    public partial interface IMessageConfiguration 
    {
        bool Enabled { get; set;}
        
        int? DeleteDaysAfterCreation { get; set;}
    }
}
