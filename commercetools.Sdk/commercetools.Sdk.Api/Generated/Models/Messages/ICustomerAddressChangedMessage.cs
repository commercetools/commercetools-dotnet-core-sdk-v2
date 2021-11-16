using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.CustomerAddressChangedMessage))]
    public partial interface ICustomerAddressChangedMessage : IMessage
    {
        IAddress Address { get; set; }
    }
}
