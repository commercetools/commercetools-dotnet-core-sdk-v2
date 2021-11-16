using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.CustomerAddressChangedMessagePayload))]
    public partial interface ICustomerAddressChangedMessagePayload : IMessagePayload
    {
        IAddress Address { get; set;}
    }
}
