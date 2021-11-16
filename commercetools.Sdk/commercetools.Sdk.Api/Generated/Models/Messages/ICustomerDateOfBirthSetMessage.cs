using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.CustomerDateOfBirthSetMessage))]
    public partial interface ICustomerDateOfBirthSetMessage : IMessage
    {
        DateTime? DateOfBirth { get; set;}
    }
}
