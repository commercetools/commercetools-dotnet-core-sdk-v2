using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.OrderBillingAddressSetMessage))]
    public partial interface IOrderBillingAddressSetMessage : IMessage
    {
        IAddress Address { get; set; }

        IAddress OldAddress { get; set; }
    }
}
