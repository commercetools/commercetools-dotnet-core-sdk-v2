using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.CustomerAddressRemovedMessage))]
    public partial interface ICustomerAddressRemovedMessage : IMessage
    {
        IAddress Address { get; set; }

    }
}
