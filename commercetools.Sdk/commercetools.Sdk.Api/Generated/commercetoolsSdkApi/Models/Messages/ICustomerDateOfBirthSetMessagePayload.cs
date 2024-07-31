using commercetools.Base.Models;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.CustomerDateOfBirthSetMessagePayload))]
    public partial interface ICustomerDateOfBirthSetMessagePayload : IMessagePayload
    {
        Date? DateOfBirth { get; set; }

    }
}
