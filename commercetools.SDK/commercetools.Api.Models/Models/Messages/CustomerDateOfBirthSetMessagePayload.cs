using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("CustomerDateOfBirthSet")]
    public partial class CustomerDateOfBirthSetMessagePayload : MessagePayload
    {
        public DateTime DateOfBirth { get; set;}
        public CustomerDateOfBirthSetMessagePayload()
        { 
           this.Type = "CustomerDateOfBirthSet";
        }
    }
}
