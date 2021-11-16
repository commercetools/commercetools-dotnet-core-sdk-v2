using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.CustomerDateOfBirthSetMessagePayload))]
    public partial interface ICustomerDateOfBirthSetMessagePayload : IMessagePayload
    {
        DateTime DateOfBirth { get; set; }
    }
}
