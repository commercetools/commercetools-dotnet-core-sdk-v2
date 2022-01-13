using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.OrderBillingAddressSetMessagePayload))]
    public partial interface IOrderBillingAddressSetMessagePayload : IMessagePayload
    {
        IAddress Address { get; set; }

        IAddress OldAddress { get; set; }
    }
}
