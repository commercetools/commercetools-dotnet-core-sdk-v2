using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.CustomerAddressAddedMessage))]
    public partial interface ICustomerAddressAddedMessage : IMessage
    {
        IAddress Address { get; set;}
    }
}
