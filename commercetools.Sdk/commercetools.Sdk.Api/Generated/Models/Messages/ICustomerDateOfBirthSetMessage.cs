using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.CustomerDateOfBirthSetMessage))]
    public partial interface ICustomerDateOfBirthSetMessage : IMessage
    {
        DateTime? DateOfBirth { get; set; }

    }
}
