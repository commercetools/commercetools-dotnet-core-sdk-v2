using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.CustomerDateOfBirthSetMessagePayload))]
    public partial interface ICustomerDateOfBirthSetMessagePayload : IMessagePayload
    {
        Date? DateOfBirth { get; set; }

    }
}
