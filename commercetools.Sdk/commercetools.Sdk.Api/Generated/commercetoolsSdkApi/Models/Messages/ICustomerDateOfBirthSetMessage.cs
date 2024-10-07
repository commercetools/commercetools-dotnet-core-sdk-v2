using commercetools.Base.Models;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.CustomerDateOfBirthSetMessage))]
    public partial interface ICustomerDateOfBirthSetMessage : IMessage
    {
        Date? DateOfBirth { get; set; }

    }
}
