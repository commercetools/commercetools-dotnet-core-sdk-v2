using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.CustomerBillingAddressAddedMessage))]
    public partial interface ICustomerBillingAddressAddedMessage : IMessage
    {
        IAddress Address { get; set; }

    }
}
