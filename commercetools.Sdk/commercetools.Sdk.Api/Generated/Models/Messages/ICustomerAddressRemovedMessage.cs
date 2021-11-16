using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.CustomerAddressRemovedMessage))]
    public partial interface ICustomerAddressRemovedMessage : IMessage
    {
        IAddress Address { get; set;}
    }
}
