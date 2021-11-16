using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.CustomerAddressRemovedMessagePayload))]
    public partial interface ICustomerAddressRemovedMessagePayload : IMessagePayload
    {
        IAddress Address { get; set;}
    }
}
