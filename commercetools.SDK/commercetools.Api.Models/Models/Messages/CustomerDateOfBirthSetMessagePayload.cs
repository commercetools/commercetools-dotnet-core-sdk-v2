using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("CustomerDateOfBirthSet")]
    public class CustomerDateOfBirthSetMessagePayload : MessagePayload
    {
        public DateTime DateOfBirth { get; set;}
    }
}
