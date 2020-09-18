using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    public class MessageConfiguration 
    {
        public bool Enabled { get; set;}
        
        public int DeleteDaysAfterCreation { get; set;}
    }
}
