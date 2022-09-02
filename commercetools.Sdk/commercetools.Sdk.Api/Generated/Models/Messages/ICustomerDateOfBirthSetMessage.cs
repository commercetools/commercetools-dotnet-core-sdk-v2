using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.CustomerDateOfBirthSetMessage))]
    public partial interface ICustomerDateOfBirthSetMessage : IMessage
    {
        Date? DateOfBirth { get; set; }

    }
}
