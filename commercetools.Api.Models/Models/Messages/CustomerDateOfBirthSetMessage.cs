using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Messages
{
    public class CustomerDateOfBirthSetMessage : Message
    {
        public DateTime DateOfBirth { get; set;}
    }
}
