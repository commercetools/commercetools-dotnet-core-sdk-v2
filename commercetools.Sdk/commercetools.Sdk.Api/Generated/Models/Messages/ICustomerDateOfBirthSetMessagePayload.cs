using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.CustomerDateOfBirthSetMessagePayload))]
    public partial interface ICustomerDateOfBirthSetMessagePayload : IMessagePayload
    {
        Date? DateOfBirth { get; set; }

    }
}
