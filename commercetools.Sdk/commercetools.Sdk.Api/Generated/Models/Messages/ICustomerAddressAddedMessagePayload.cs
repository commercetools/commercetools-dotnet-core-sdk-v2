using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.CustomerAddressAddedMessagePayload))]
    public partial interface ICustomerAddressAddedMessagePayload : IMessagePayload
    {
        IAddress Address { get; set;}
    }
}
